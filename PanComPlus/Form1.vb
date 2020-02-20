Imports System.IO

Public Class Form1
    Public MaxDevice As Integer = 240
    Public MaxPanel As Integer = 8
    Public MaxAntenna As Integer = 8
    Public Length_RSSILine = 49

    Public FilterType_None = 0
    Public FilterType_RSSI = 1
    Public FilterType_MisMatch = 2
    Public FilterType_Notlocal = 3

    Public StatusOK = 1
    Public StatusNotLocal = 2
    Public StatusMismatch = 3
    Public StatusDoubleLocal = 4
    Public StatusIdenticalRSSI = 5

    Public Structure VerifyTableData
        Public Property Panel As Integer
        Public Property Device As Integer
        Public Property Antenna As Integer
        Public Property RSSI As Integer
        Public Property Count As Integer
        Public Property MaxCount As Integer
        Public Property Local As Boolean
    End Structure

    Public Structure RSSIInfo
        Public BestPanel As Integer
        Public BestPanelRSSI As Integer
        Public NextBestPanel As Integer
        Public NextBestPanelRSSI As Integer
        Public LocalPanel As Integer
        Public LocalPanelRSSI As Integer
        Public Status As Integer
    End Structure

    Dim SystemDevices As New List(Of VerifyTableData)

    Dim DeviceFiltered As New List(Of VerifyTableData)

    Dim T As New DataTable
    Public PPBind As New BindingSource()


    Private Sub ButtonProcessFiles_Click(sender As Object, e As EventArgs) Handles ButtonProcessFiles.Click

        Const Is_Device As Integer = 1
        Const Is_Panel As Integer = 2

        Dim found, Panel, L, A As Integer
        Dim Line, N, Field As String
        Dim sr As StreamReader
        Dim DeviceOrPanel As Integer

        Dim V As New VerifyTableData With {.Antenna = 0, .Count = 0, .Device = 0, .Local = False, .MaxCount = 0, .Panel = 0, .RSSI = 999}

        SystemDevices.Clear()

        Try
            For Each f As String In OpenFileDialog1.FileNames

                sr = New StreamReader(f)
                DeviceOrPanel = 0
                Do
                    Line = sr.ReadLine()
                    If Line IsNot Nothing Then
                        found = InStr(Line, "Panel:")
                        If found > 0 Then
                            N = Mid(Line, (found + 6), 2)
                            Panel = Convert.ToDecimal(N)
                        Else
                            found = InStr(Line, "Dev")

                            If found > 0 Then
                                DeviceOrPanel = Is_Device
                            Else
                                found = InStr(Line, "Pan")
                                If found > 0 Then
                                    DeviceOrPanel = Is_Panel
                                End If
                            End If
                        End If

                        If found = 0 Then
                            L = Len(Line)
                            If L >= Length_RSSILine Then
                                If DeviceOrPanel = Is_Device Then
                                    Field = Mid(Line, 1, 3)
                                    N = Convert.ToDecimal(Field)
                                    If (N > 0 And N <= MaxDevice) Then
                                        Field = Mid(Line, 6, 2)
                                        A = Convert.ToDecimal(Field)

                                        If (A > 0 And A <= MaxAntenna) Then
                                            'Device
                                            V.Device = N

                                            'Panel
                                            V.Panel = Panel

                                            'Antenna
                                            V.Antenna = A

                                            'RSSI
                                            Field = Mid(Line, 10, 3)
                                            If Field <> "---" Then
                                                V.RSSI = Convert.ToDecimal(Field)
                                            Else
                                                V.RSSI = -100
                                            End If

                                            'Count
                                            Field = Mid(Line, 14, 5)
                                            V.Count = Convert.ToDecimal(Field)

                                            'Max Count
                                            Field = Mid(Line, 20, 5)
                                            V.MaxCount = Convert.ToDecimal(Field)

                                            'Logged
                                            Field = Mid(Line, 52, 5)
                                            V.Local = False
                                            If Field = "Local" Then
                                                V.Local = True
                                            End If

                                            SystemDevices.Add(V)

                                        End If
                                    End If
                                ElseIf DeviceOrPanel = Is_Panel Then
                                    Field = Mid(Line, 1, 3)
                                    N = Convert.ToDecimal(Field)
                                    If (N <= MaxPanel) Then
                                        ''RSSI
                                        'Field = Mid(Line, 10, 3)
                                        'If Field <> "---" Then
                                        '    ThisSystem.Panels(N - 1).Antennas.AntennaRSSI = Convert.ToDecimal(Field)
                                        'End If

                                        ''Count
                                        'Field = Mid(Line, 14, 5)
                                        'ThisSystem.Panels(N - 1).Antennas.Count = Convert.ToDecimal(Field)

                                        ''Max Count
                                        'Field = Mid(Line, 20, 5)
                                        'ThisSystem.Panels(N - 1).Antennas.Count = Convert.ToDecimal(Field)

                                        ''Logged
                                        'Field = Mid(Line, 52, 5)
                                        'If Field = "Local" Then
                                        '    ThisSystem.Panels(N - 1).Antennas.Local = True
                                        'End If

                                    End If

                                End If
                            End If
                        End If
                    End If

                Loop Until Line Is Nothing
            Next

        Catch ex As Exception
            MsgBox("Except")
        End Try


    End Sub
    Private Sub ProcessFilterRSSI(FilterType As Integer)

        Dim RSSIData As RSSIInfo
        Dim AllRSSIData As New List(Of RSSIInfo)
        Dim LowRSSIData As New List(Of RSSIInfo)

        Me.DataGridView1.Rows.Clear()

        For Device As Integer = 1 To MaxDevice
            For Each Entry As VerifyTableData In SystemDevices
                If Entry.Device = Device Then
                    DeviceFiltered.Add(Entry)
                End If
            Next


            If DeviceFiltered.Count > 0 Then

                Dim orderByResult = From s In DeviceFiltered
                                    Order By s.Local Descending
                                    Select s

                RSSIData.LocalPanel = 0
                RSSIData.Status = StatusOK

                If orderByResult.First.Local = True Then
                    RSSIData.LocalPanel = orderByResult.First.Panel
                    RSSIData.LocalPanelRSSI = orderByResult.First.RSSI
                    If DeviceFiltered.Count > 1 Then
                        If orderByResult.ElementAt(1).Local = True Then
                            RSSIData.Status = StatusDoubleLocal
                        End If
                    End If
                Else
                    RSSIData.Status = StatusNotLocal
                End If

                orderByResult = From s In DeviceFiltered
                                Order By s.RSSI Descending
                                Select s

                RSSIData.BestPanel = orderByResult.First.Panel
                RSSIData.BestPanelRSSI = orderByResult.First.RSSI

                If RSSIData.LocalPanel > 0 Then

                    If RSSIData.LocalPanel >= RSSIData.BestPanel Then
                        RSSIData.Status = StatusOK
                    Else
                        RSSIData.Status = StatusMismatch
                    End If

                End If


                If FilterType = FilterType_None Then


                    If DeviceFiltered.Count > 1 Then
                        RSSIData.NextBestPanel = orderByResult.ElementAt(1).Panel
                        RSSIData.NextBestPanelRSSI = orderByResult.ElementAt(1).RSSI

                        If RSSIData.LocalPanel > 0 Then
                            If RSSIData.NextBestPanelRSSI = RSSIData.LocalPanelRSSI Then
                                RSSIData.Status = StatusIdenticalRSSI
                            End If
                        End If
                    End If

                    Dim BestStr As String
                    If RSSIData.BestPanelRSSI = -100 Then
                        BestStr = "---"
                    Else
                        BestStr = RSSIData.BestPanel.ToString + " (" + RSSIData.BestPanelRSSI.ToString + ")"
                    End If

                    Dim NextBestStr As String
                    If RSSIData.NextBestPanelRSSI = -100 Then
                        NextBestStr = "---"
                    Else
                        NextBestStr = RSSIData.NextBestPanel.ToString + " (" + RSSIData.NextBestPanelRSSI.ToString + ")"
                    End If

                    Dim LocalPanelStr As String
                    If RSSIData.Status = StatusNotLocal Then
                        LocalPanelStr = "---"
                    Else
                        LocalPanelStr = RSSIData.LocalPanel.ToString + " (" + RSSIData.LocalPanelRSSI.ToString + ")"
                    End If

                    Dim MismatchStr As String = ""

                    Select Case RSSIData.Status
                        Case StatusOK
                            MismatchStr = "OK"
                        Case StatusDoubleLocal
                            MismatchStr = "Double Local"
                        Case StatusMismatch
                            MismatchStr = "Mismatch"
                        Case StatusNotLocal
                            MismatchStr = "Not Local"
                        Case StatusIdenticalRSSI
                            MismatchStr = "Identical"
                    End Select

                    Me.DataGridView1.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, MismatchStr)
                    'Me.DataGridView1.Rows.Add(Device, RSSIData.BestPanel, RSSIData.NextBestPanel, RSSIData.LocalPanel)

                    T.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, MismatchStr)

                    Me.PPBind.DataSource = T
                    Form2.DataGridView1.DataSource = Me.PPBind

                    'DataGridView2.DataSource = T

                    FilteredCount.Text = Me.DataGridView1.RowCount - 1

                ElseIf FilterType = FilterType_RSSI Then
                    If (RSSIData.BestPanelRSSI > -100 And RSSIData.BestPanelRSSI < RSSITrackBar.Value) Then

                        If DeviceFiltered.Count > 1 Then
                            RSSIData.NextBestPanel = orderByResult.ElementAt(1).Panel
                            RSSIData.NextBestPanelRSSI = orderByResult.ElementAt(1).RSSI

                            If RSSIData.LocalPanel > 0 Then
                                If RSSIData.NextBestPanelRSSI = RSSIData.LocalPanelRSSI Then
                                    RSSIData.Status = StatusIdenticalRSSI
                                End If
                            End If
                        End If

                        Dim BestStr As String
                        If RSSIData.BestPanelRSSI = -100 Then
                            BestStr = "---"
                        Else
                            BestStr = RSSIData.BestPanel.ToString + " (" + RSSIData.BestPanelRSSI.ToString + ")"
                        End If

                        Dim NextBestStr As String
                        If RSSIData.NextBestPanelRSSI = -100 Then
                            NextBestStr = "---"
                        Else
                            NextBestStr = RSSIData.NextBestPanel.ToString + " (" + RSSIData.NextBestPanelRSSI.ToString + ")"
                        End If

                        Dim LocalPanelStr As String
                        If RSSIData.Status = StatusNotLocal Then
                            LocalPanelStr = "---"
                        Else
                            LocalPanelStr = RSSIData.LocalPanel.ToString + " (" + RSSIData.LocalPanelRSSI.ToString + ")"
                        End If

                        Dim MismatchStr As String = ""

                        Select Case RSSIData.Status
                            Case StatusOK
                                MismatchStr = "OK"
                            Case StatusDoubleLocal
                                MismatchStr = "Double Local"
                            Case StatusMismatch
                                MismatchStr = "Mismatch"
                            Case StatusNotLocal
                                MismatchStr = "Not Local"
                            Case StatusIdenticalRSSI
                                MismatchStr = "Identical"
                        End Select

                        Me.DataGridView1.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, MismatchStr)
                        'Me.DataGridView1.Rows.Add(Device, RSSIData.BestPanel, RSSIData.NextBestPanel, RSSIData.LocalPanel)

                        FilteredCount.Text = Me.DataGridView1.RowCount - 1

                        T.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, MismatchStr)

                        Me.PPBind.DataSource = T

                    End If
                ElseIf FilterType = FilterType_MisMatch Then
                    If (RSSIData.Status = StatusMismatch) Then

                        If DeviceFiltered.Count > 1 Then
                            RSSIData.NextBestPanel = orderByResult.ElementAt(1).Panel
                            RSSIData.NextBestPanelRSSI = orderByResult.ElementAt(1).RSSI

                            'If RSSIData.LocalPanel > 0 Then
                            '    If RSSIData.NextBestPanelRSSI = RSSIData.LocalPanelRSSI Then
                            '        RSSIData.Status = StatusIdenticalRSSI
                            '    End If
                            'End If
                        End If

                        Dim BestStr As String
                        If RSSIData.BestPanelRSSI = -100 Then
                            BestStr = "---"
                        Else
                            BestStr = RSSIData.BestPanel.ToString + " (" + RSSIData.BestPanelRSSI.ToString + ")"
                        End If

                        Dim NextBestStr As String
                        If RSSIData.NextBestPanelRSSI = -100 Then
                            NextBestStr = "---"
                        Else
                            NextBestStr = RSSIData.NextBestPanel.ToString + " (" + RSSIData.NextBestPanelRSSI.ToString + ")"
                        End If

                        Dim LocalPanelStr As String
                        If RSSIData.Status = StatusNotLocal Then
                            LocalPanelStr = "---"
                        Else
                            LocalPanelStr = RSSIData.LocalPanel.ToString + " (" + RSSIData.LocalPanelRSSI.ToString + ")"
                        End If

                        Dim MismatchStr As String = ""

                        Select Case RSSIData.Status
                            Case StatusOK
                                MismatchStr = "OK"
                            Case StatusDoubleLocal
                                MismatchStr = "Double Local"
                            Case StatusMismatch
                                MismatchStr = "Mismatch"
                            Case StatusNotLocal
                                MismatchStr = "Not Local"
                            Case StatusIdenticalRSSI
                                MismatchStr = "Identical"
                        End Select

                        Me.DataGridView1.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, MismatchStr)
                        'Me.DataGridView1.Rows.Add(Device, RSSIData.BestPanel, RSSIData.NextBestPanel, RSSIData.LocalPanel)

                        FilteredCount.Text = Me.DataGridView1.RowCount - 1

                    End If
                ElseIf FilterType = FilterType_Notlocal Then
                    If (RSSIData.Status = StatusNotLocal) Then

                        If DeviceFiltered.Count > 1 Then
                            RSSIData.NextBestPanel = orderByResult.ElementAt(1).Panel
                            RSSIData.NextBestPanelRSSI = orderByResult.ElementAt(1).RSSI

                            If RSSIData.LocalPanel > 0 Then
                                If RSSIData.NextBestPanelRSSI = RSSIData.LocalPanelRSSI Then
                                    RSSIData.Status = StatusIdenticalRSSI
                                End If
                            End If
                        End If

                        Dim BestStr As String
                        If RSSIData.BestPanelRSSI = -100 Then
                            BestStr = "---"
                        Else
                            BestStr = RSSIData.BestPanel.ToString + " (" + RSSIData.BestPanelRSSI.ToString + ")"
                        End If

                        Dim NextBestStr As String
                        If RSSIData.NextBestPanelRSSI = -100 Then
                            NextBestStr = "---"
                        Else
                            NextBestStr = RSSIData.NextBestPanel.ToString + " (" + RSSIData.NextBestPanelRSSI.ToString + ")"
                        End If

                        Dim LocalPanelStr As String
                        If RSSIData.Status = StatusNotLocal Then
                            LocalPanelStr = "---"
                        Else
                            LocalPanelStr = RSSIData.LocalPanel.ToString + " (" + RSSIData.LocalPanelRSSI.ToString + ")"
                        End If

                        Dim MismatchStr As String = ""

                        Select Case RSSIData.Status
                            Case StatusOK
                                MismatchStr = "OK"
                            Case StatusDoubleLocal
                                MismatchStr = "Double Local"
                            Case StatusMismatch
                                MismatchStr = "Mismatch"
                            Case StatusNotLocal
                                MismatchStr = "Not Local"
                            Case StatusIdenticalRSSI
                                MismatchStr = "Identical"
                        End Select

                        Me.DataGridView1.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, MismatchStr)
                        'Me.DataGridView1.Rows.Add(Device, RSSIData.BestPanel, RSSIData.NextBestPanel, RSSIData.LocalPanel)

                        FilteredCount.Text = Me.DataGridView1.RowCount - 1

                    End If
                End If

            End If

            DeviceFiltered.Clear()

        Next

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        SliderValue.Text = RSSITrackBar.Value

        'DataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        For Each c As DataGridViewColumn In DataGridView1.Columns
            c.Width = 60
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

        ButtonProcessFiles.Enabled = False
        ButtonMismatch.Enabled = False
        ButtonNotLocal.Enabled = False
        ButtonLowRSSI.Enabled = False
        ButtonAllData.Enabled = False

        OpenFileDialog1.FileName = ""

        T.Columns.Add("Device", Type.GetType("System.Int16"))
        T.Columns.Add("LocalPanel", Type.GetType("System.String"))
        T.Columns.Add("BestPanel", Type.GetType("System.String"))
        T.Columns.Add("NextBestPanel", Type.GetType("System.String"))
        T.Columns.Add("Status", Type.GetType("System.String"))


        'DataGridView2.DataSource = T

    End Sub

    Private Sub ButtonLowRSSI_Click(sender As Object, e As EventArgs) Handles ButtonLowRSSI.Click

        'Dim x, y As Integer

        'Dim frm As New Form2

        'frm.Show()

        'x = (Screen.PrimaryScreen.WorkingArea.Width - frm.Width) / 2
        'y = (Screen.PrimaryScreen.WorkingArea.Height - frm.Height) / 2

        'frm.Location = New Point(x, y)

        'frm.DataGridView1.DataSource = T

        ProcessFilterRSSI(FilterType_RSSI)

        'Dim RSSIData As RSSIInfo
        'Dim AllRSSIData As New List(Of RSSIInfo)
        'Dim LowRSSIData As New List(Of RSSIInfo)

        'DataGridView1.Rows.Clear()

        'For Device As Integer = 1 To MaxDevice
        '    For Each Entry As VerifyTableData In SystemDevices
        '        If Entry.Device = Device Then

        '            DeviceFiltered.Add(Entry)

        '        End If
        '    Next


        '    If DeviceFiltered.Count > 0 Then

        '        Dim orderByResult = From s In DeviceFiltered
        '                            Order By s.RSSI Descending
        '                            Select s


        '        RSSIData.BestPanel = orderByResult.First.Panel
        '        RSSIData.BestPanelRSSI = orderByResult.First.RSSI

        '        If (RSSIData.BestPanelRSSI > -100 And RSSIData.BestPanelRSSI <= RSSITrackBar.Value) Then

        '            If DeviceFiltered.Count > 1 Then
        '                RSSIData.NextBestPanel = orderByResult.ElementAt(1).Panel
        '                RSSIData.NextBestPanelRSSI = orderByResult.ElementAt(1).RSSI
        '            End If

        '            Dim BestStr As String
        '            BestStr = RSSIData.BestPanel.ToString + " (" + RSSIData.BestPanelRSSI.ToString + ")"

        '            Dim NextBestStr As String
        '            NextBestStr = RSSIData.NextBestPanel.ToString + " (" + RSSIData.NextBestPanelRSSI.ToString + ")"

        '            Me.DataGridView1.Rows.Add(Device, BestStr, NextBestStr, RSSIData.LocalPanel)
        '            'Me.DataGridView1.Rows.Add(Device, RSSIData.BestPanel, RSSIData.NextBestPanel, RSSIData.LocalPanel)

        '            FilteredCount.Text = DataGridView1.RowCount

        '        End If

        '    End If

        '    DeviceFiltered.Clear()

        'Next


    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles RSSITrackBar.Scroll
        SliderValue.Text = RSSITrackBar.Value

        ProcessFilterRSSI(FilterType_RSSI)

    End Sub

    Private Sub ButtonAllData_Click(sender As Object, e As EventArgs) Handles ButtonAllData.Click

        'Dim x, y As Integer

        'Dim frm As New Form2

        'frm.Show()

        'x = (Screen.PrimaryScreen.WorkingArea.Width - frm.Width) / 2
        'y = (Screen.PrimaryScreen.WorkingArea.Height - frm.Height) / 2

        'frm.Location = New Point(x, y)

        'frm.DataGridView1.DataSource = T

        ProcessFilterRSSI(FilterType_None)

        TextBox2.Visible = False

        'Dim RSSIData As RSSIInfo
        'Dim AllRSSIData As New List(Of RSSIInfo)
        'Dim LowRSSIData As New List(Of RSSIInfo)



        'DataGridView1.Rows.Clear()

        'For Device As Integer = 1 To MaxDevice
        '    For Each Entry As VerifyTableData In SystemDevices
        '        If Entry.Device = Device Then
        '            DeviceFiltered.Add(Entry)
        '        End If
        '    Next

        '    If DeviceFiltered.Count > 0 Then

        '        Dim orderByResult = From s In DeviceFiltered
        '                            Order By s.RSSI Descending
        '                            Select s


        '        RSSIData.BestPanel = orderByResult.First.Panel
        '        RSSIData.BestPanelRSSI = orderByResult.First.RSSI

        '        If DeviceFiltered.Count > 1 Then
        '            RSSIData.NextBestPanel = orderByResult.ElementAt(1).Panel
        '            RSSIData.NextBestPanelRSSI = orderByResult.ElementAt(1).RSSI
        '        End If

        '        Dim BestStr As String
        '        BestStr = RSSIData.BestPanel.ToString + " (" + RSSIData.BestPanelRSSI.ToString + ")"

        '        Dim NextBestStr As String
        '        NextBestStr = RSSIData.NextBestPanel.ToString + " (" + RSSIData.NextBestPanelRSSI.ToString + ")"

        '        Me.DataGridView1.Rows.Add(Device, BestStr, NextBestStr, RSSIData.LocalPanel)
        '        'Me.DataGridView1.Rows.Add(Device, RSSIData.BestPanel, RSSIData.NextBestPanel, RSSIData.LocalPanel)

        '    End If


        '    DeviceFiltered.Clear()

        'Next

    End Sub

    Private Sub ButtonMismatch_Click(sender As Object, e As EventArgs) Handles ButtonMismatch.Click

        'Dim x, y As Integer

        'Dim frm As New Form2

        'frm.Show()

        'x = (Screen.PrimaryScreen.WorkingArea.Width - frm.Width) / 2
        'y = (Screen.PrimaryScreen.WorkingArea.Height - frm.Height) / 2

        'frm.Location = New Point(x, y)

        'frm.DataGridView1.DataSource = T

        ProcessFilterRSSI(FilterType_MisMatch)

    End Sub

    Private Sub ButtonNotLocal_Click(sender As Object, e As EventArgs) Handles ButtonNotLocal.Click

        'Dim x, y As Integer

        'Dim frm As New Form2

        'frm.Show()

        'x = (Screen.PrimaryScreen.WorkingArea.Width - frm.Width) / 2
        'y = (Screen.PrimaryScreen.WorkingArea.Height - frm.Height) / 2

        'frm.Location = New Point(x, y)

        'frm.DataGridView1.DataSource = T

        ProcessFilterRSSI(FilterType_Notlocal)

    End Sub

    Private Sub OpenFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFilesToolStripMenuItem.Click


        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then

            ButtonProcessFiles.Enabled = False
            ButtonAllData.Enabled = False
            ButtonLowRSSI.Enabled = False
            ButtonMismatch.Enabled = False
            ButtonNotLocal.Enabled = False

            RSSITrackBar.Enabled = False
            SliderValue.Enabled = False
            FilteredCount.Enabled = False
        Else
            TextBox1.Text = ""
            For Each f As String In OpenFileDialog1.FileNames
                TextBox1.Text += f + vbCrLf
            Next

            ButtonProcessFiles.Enabled = True
            ButtonAllData.Enabled = True
            ButtonLowRSSI.Enabled = True
            ButtonMismatch.Enabled = True
            ButtonNotLocal.Enabled = True

            RSSITrackBar.Enabled = True
            SliderValue.Enabled = True
            FilteredCount.Enabled = True

            TextBox1.TextAlign = HorizontalAlignment.Left

        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub


End Class

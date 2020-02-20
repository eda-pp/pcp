Imports System.ComponentModel
Imports System.IO
Imports System.Text

Public Class Form1
    Public MaxDevice As Integer = 480
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
    Public StatusLowRSSI = 6
    Public StatusLocal = 7

    Public TableTypeAll = 1
    Public TableTypeNotLocal = 2
    Public TableTypeMisMatch = 3
    Public TableTypeGoodRSSI = 4
    Public TableTypeLowRSSI = 5
    Public TableTypePanelAll = 6
    Public TableTypePanelLocal = 7
    Public TableTypePanelGoodRSSI = 8


    Public ColWidth = 80

    Dim AllCount, LowCount, NotLocalCount, MismatchCount As Integer

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
        Public BestAntenna As Integer
        Public BestPanelRSSI As Integer
        Public NextBestPanel As Integer
        Public NextBestAntenna As Integer
        Public NextBestPanelRSSI As Integer
        Public LocalPanel As Integer
        Public LocalAntenna As Integer
        Public LocalPanelRSSI As Integer
        Public Status As Integer
    End Structure

    Public Structure PanelRSSIInfo
        Public Panel As Integer
        Public Antenna As Integer
        Public OtherPanel As Integer
        Public Local As Boolean
        Public RSSI As Integer
        Public Status As Integer
    End Structure

    Dim FileNames As String()
    Dim FileFound(8) As Boolean

    Dim SystemDevices As New List(Of VerifyTableData)
    Dim SystemPanels As New List(Of VerifyTableData)

    Dim DeviceFiltered As New List(Of VerifyTableData)

    'Dim T As New DataTable

    Dim TableAllDevices As New DataTable
    Dim TableMismatchDevices As New DataTable
    Dim TableLowRSSIDevices As New DataTable
    Dim TableNotLocalDevices As New DataTable
    Dim TableGoodRSSIDevices As New DataTable

    Dim TableAllPanels As New DataTable
    Dim TableLocalPanels As New DataTable
    Dim TableGoodRSSIPanels As New DataTable

    Public PPBind As New BindingSource()

    Public Sub ProcessFiles(FileNames As String())

        Const Is_Device As Integer = 1
        Const Is_Panel As Integer = 2

        Dim found, Panel, L, A As Integer
        Dim Line, N, Field As String
        Dim sr As StreamReader
        Dim DeviceOrPanel As Integer

        Dim V As New VerifyTableData With {.Antenna = 0, .Count = 0, .Device = 0, .Local = False, .MaxCount = 0, .Panel = 0, .RSSI = 999}

        SystemDevices.Clear()
        SystemPanels.Clear()

        Try
            For Each f As String In FileNames '  OpenFileDialog1.FileNames

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
                                    'N = 0
                                    If Integer.TryParse(Field, vbNull) Then
                                        N = Convert.ToDecimal(Field)
                                    End If

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

                                    'N = 0
                                    If Integer.TryParse(Field, vbNull) Then
                                        N = Convert.ToDecimal(Field)
                                    End If

                                    If (N >= 1 And N <= MaxPanel) Then
                                        Field = Mid(Line, 6, 2)
                                        A = Convert.ToDecimal(Field)

                                        If A >= 1 And A <= MaxAntenna Then
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

                                            SystemPanels.Add(V)

                                        End If

                                    End If

                                End If
                            End If
                        End If
                    End If

                Loop Until Line Is Nothing
            Next

        Catch ex As Exception
            MsgBox("Process File Error")
        End Try

    End Sub

    Private Sub ProcessAll()

        Dim RSSIData As RSSIInfo
        Dim PanelRSSIData As PanelRSSIInfo

        TableAllDevices.Clear()
        TableNotLocalDevices.Clear()
        TableLowRSSIDevices.Clear()
        TableMismatchDevices.Clear()
        TableGoodRSSIDevices.Clear()

        TableAllPanels.Clear()
        TableLocalPanels.Clear()
        TableGoodRSSIPanels.Clear()

        Try

            For Device As Integer = 1 To MaxDevice

                DeviceFiltered.Clear()

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
                        RSSIData.LocalAntenna = orderByResult.First.Antenna
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
                    RSSIData.BestAntenna = orderByResult.First.Antenna

                    If RSSIData.LocalPanel > 0 Then

                        If RSSIData.LocalPanelRSSI >= RSSIData.BestPanelRSSI Then
                            RSSIData.Status = StatusOK
                        Else
                            RSSIData.Status = StatusMismatch
                        End If

                    End If


                    If DeviceFiltered.Count > 1 Then
                        RSSIData.NextBestPanel = orderByResult.ElementAt(1).Panel
                        RSSIData.NextBestPanelRSSI = orderByResult.ElementAt(1).RSSI
                        RSSIData.NextBestAntenna = orderByResult.ElementAt(1).Antenna
                    Else
                        RSSIData.NextBestPanel = 0
                        RSSIData.NextBestPanelRSSI = -100
                        RSSIData.NextBestAntenna = 0
                    End If

                    If RSSIData.Status = StatusOK Then
                        If (RSSIData.BestPanelRSSI > -100 And RSSIData.BestPanelRSSI < RSSITrackBar.Value) Then
                            RSSIData.Status = StatusLowRSSI
                        End If
                    End If

                    Dim BestStr As String
                    If RSSIData.BestPanelRSSI = -100 Then
                        BestStr = "--------"
                    Else
                        BestStr = "P" + RSSIData.BestPanel.ToString + "A" + RSSIData.BestAntenna.ToString + " (" + RSSIData.BestPanelRSSI.ToString + ")"
                    End If

                    Dim NextBestStr As String
                    If RSSIData.NextBestPanelRSSI = -100 Then
                        NextBestStr = "--------"
                    Else
                        NextBestStr = "P" + RSSIData.NextBestPanel.ToString + "A" + RSSIData.NextBestAntenna.ToString + " (" + RSSIData.NextBestPanelRSSI.ToString + ")"
                    End If

                    Dim LocalPanelStr As String
                    If RSSIData.Status = StatusNotLocal Then
                        LocalPanelStr = "--------"
                    Else
                        LocalPanelStr = "P" + RSSIData.LocalPanel.ToString + "A" + RSSIData.LocalAntenna.ToString + " (" + RSSIData.LocalPanelRSSI.ToString + ")"
                    End If

                    Dim StatusStr As String = ""

                    Select Case RSSIData.Status
                        Case StatusOK
                            StatusStr = "Good RSSI"
                        Case StatusDoubleLocal
                            StatusStr = "Double Local"
                        Case StatusMismatch
                            StatusStr = "Mismatch"
                        Case StatusNotLocal
                            StatusStr = "Not Local"
                        Case StatusIdenticalRSSI
                            StatusStr = "Identical"
                        Case StatusLowRSSI
                            StatusStr = "Low RSSI"
                    End Select

                    TableAllDevices.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, StatusStr)

                    If RSSIData.Status = StatusOK Then
                        TableGoodRSSIDevices.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, StatusStr)
                    ElseIf RSSIData.Status = StatusMismatch Then
                        TableMismatchDevices.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, StatusStr)
                    ElseIf RSSIData.Status = StatusNotLocal Then
                        TableNotLocalDevices.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, StatusStr)
                    ElseIf RSSIData.Status = StatusLowRSSI Then
                        TableLowRSSIDevices.Rows.Add(Device, LocalPanelStr, BestStr, NextBestStr, StatusStr)
                    End If

                End If

            Next

            Dim TextString As String

            TextString = "All (" + TableAllDevices.Rows.Count.ToString + ")"
            RadioButtonAll.Text = TextString

            TextString = "Good RSSI (" + TableGoodRSSIDevices.Rows.Count.ToString + ")"
            RadioButtonGoodRSSI.Text = TextString

            TextString = "Mismatch (" + TableMismatchDevices.Rows.Count.ToString + ")"
            RadioButtonMismatch.Text = TextString

            TextString = "Not Local (" + TableNotLocalDevices.Rows.Count.ToString + ")"
            RadioButtonNotLocal.Text = TextString

            TextString = "Low RSSI  (" + TableLowRSSIDevices.Rows.Count.ToString + ")"
            RadioButtonLowRSSI.Text = TextString


            Dim PanelStr As String

            For Each Entry As VerifyTableData In SystemPanels
                PanelRSSIData.Panel = Entry.Panel
                PanelRSSIData.Antenna = Entry.Antenna
                PanelRSSIData.OtherPanel = Entry.Device
                PanelRSSIData.RSSI = Entry.RSSI

                Dim LocalStr As String = ""
                If Entry.Local = True Then
                    PanelRSSIData.Status = StatusLocal
                    PanelRSSIData.Local = True
                    LocalStr = "YES"
                Else
                    PanelRSSIData.Status = StatusNotLocal
                    PanelRSSIData.Local = False
                    LocalStr = "NO"
                End If

                Dim StatusStr As String = ""

                If PanelRSSIData.RSSI >= RSSIPanelTrackBar.Value Then
                    StatusStr = "Good RSSI"
                Else
                    StatusStr = "Low RSSI"
                End If

                PanelStr = "P" + PanelRSSIData.Panel.ToString + "A" + PanelRSSIData.Antenna.ToString
                TableAllPanels.Rows.Add(PanelStr, PanelRSSIData.OtherPanel.ToString, PanelRSSIData.RSSI, LocalStr, StatusStr)
                If PanelRSSIData.Status = StatusLocal Then
                    TableLocalPanels.Rows.Add(PanelStr, PanelRSSIData.OtherPanel.ToString, PanelRSSIData.RSSI, LocalStr, StatusStr)
                End If
                If PanelRSSIData.RSSI >= RSSIPanelTrackBar.Value Then
                    TableGoodRSSIPanels.Rows.Add(PanelStr, PanelRSSIData.OtherPanel.ToString, PanelRSSIData.RSSI, LocalStr, StatusStr)
                End If
            Next


        Catch ex As Exception
            MsgBox("Process Data Error")
        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        OpenFileDialog1.FileName = ""

        TableAllDevices.Columns.Add("Device", Type.GetType("System.Int16"))
        TableAllDevices.Columns.Add("Local", Type.GetType("System.String"))
        TableAllDevices.Columns.Add("Best", Type.GetType("System.String"))
        TableAllDevices.Columns.Add("Next Best", Type.GetType("System.String"))
        TableAllDevices.Columns.Add("Status", Type.GetType("System.String"))

        TableGoodRSSIDevices.Columns.Add("Device", Type.GetType("System.Int16"))
        TableGoodRSSIDevices.Columns.Add("Local", Type.GetType("System.String"))
        TableGoodRSSIDevices.Columns.Add("Best", Type.GetType("System.String"))
        TableGoodRSSIDevices.Columns.Add("Next Best", Type.GetType("System.String"))
        TableGoodRSSIDevices.Columns.Add("Status", Type.GetType("System.String"))

        TableMismatchDevices.Columns.Add("Device", Type.GetType("System.Int16"))
        TableMismatchDevices.Columns.Add("Local", Type.GetType("System.String"))
        TableMismatchDevices.Columns.Add("Best", Type.GetType("System.String"))
        TableMismatchDevices.Columns.Add("Next Best", Type.GetType("System.String"))
        TableMismatchDevices.Columns.Add("Status", Type.GetType("System.String"))

        TableNotLocalDevices.Columns.Add("Device", Type.GetType("System.Int16"))
        TableNotLocalDevices.Columns.Add("Local", Type.GetType("System.String"))
        TableNotLocalDevices.Columns.Add("Best", Type.GetType("System.String"))
        TableNotLocalDevices.Columns.Add("Next Best", Type.GetType("System.String"))
        TableNotLocalDevices.Columns.Add("Status", Type.GetType("System.String"))

        TableLowRSSIDevices.Columns.Add("Device", Type.GetType("System.Int16"))
        TableLowRSSIDevices.Columns.Add("Local", Type.GetType("System.String"))
        TableLowRSSIDevices.Columns.Add("Best", Type.GetType("System.String"))
        TableLowRSSIDevices.Columns.Add("Next Best", Type.GetType("System.String"))
        TableLowRSSIDevices.Columns.Add("Status", Type.GetType("System.String"))

        TableAllPanels.Columns.Add("Panel1", Type.GetType("System.String"))
        TableAllPanels.Columns.Add("Panel2", Type.GetType("System.String"))
        TableAllPanels.Columns.Add("RSSI", Type.GetType("System.Int16"))
        TableAllPanels.Columns.Add("Local", Type.GetType("System.String"))
        TableAllPanels.Columns.Add("Status", Type.GetType("System.String"))

        TableGoodRSSIPanels.Columns.Add("Panel1", Type.GetType("System.String"))
        TableGoodRSSIPanels.Columns.Add("Panel2", Type.GetType("System.String"))
        TableGoodRSSIPanels.Columns.Add("RSSI", Type.GetType("System.Int16"))
        TableGoodRSSIPanels.Columns.Add("Local", Type.GetType("System.String"))
        TableGoodRSSIPanels.Columns.Add("Status", Type.GetType("System.String"))

        TableLocalPanels.Columns.Add("Panel1", Type.GetType("System.String"))
        TableLocalPanels.Columns.Add("Panel2", Type.GetType("System.String"))
        TableLocalPanels.Columns.Add("RSSI", Type.GetType("System.Int16"))
        TableLocalPanels.Columns.Add("Local", Type.GetType("System.String"))
        TableLocalPanels.Columns.Add("Status", Type.GetType("System.String"))


        DataGridView1.RowHeadersVisible = False
        DataGridView2.RowHeadersVisible = False

        Dim TextString As String

        TextString = "RSSI Level" + " (" + RSSITrackBar.Value.ToString + " dBm)"
        GroupBoxRSSILevel.Text = TextString

        TextString = "RSSI Level" + " (" + RSSIPanelTrackBar.Value.ToString + " dBm)"
        GroupBoxPanelRSSILevel.Text = TextString

        Me.PPBind.DataSource = TableAllPanels
        Me.DataGridView2.DataSource = Me.PPBind

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles RSSITrackBar.Scroll

        Dim TextString As String

        TextString = "RSSI Level" + " (" + RSSITrackBar.Value.ToString + " dBm)"
        GroupBoxRSSILevel.Text = TextString

        ProcessAll()

        DataGridView1.ClearSelection()

        If RadioButtonGoodRSSI.Checked = True Then
            Me.PPBind.DataSource = TableGoodRSSIDevices
        Else
            Me.PPBind.DataSource = TableLowRSSIDevices
        End If

        Me.DataGridView1.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView1.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub RadioButtonMismatch_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMismatch.CheckedChanged

        RSSITrackBar.Enabled = False

        DataGridView1.ClearSelection()

        Me.DataGridView2.Visible = False
        Me.DataGridView1.Visible = True

        Me.PPBind.DataSource = TableMismatchDevices
        Me.DataGridView1.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView1.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub RadioButtonNotLocal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNotLocal.CheckedChanged

        DataGridView1.ClearSelection()

        Me.DataGridView2.Visible = False
        Me.DataGridView1.Visible = True

        Me.PPBind.DataSource = TableNotLocalDevices
        Me.DataGridView1.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView1.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Public Sub RefreshDeviceAll()

        RSSITrackBar.Enabled = False

        DataGridView1.ClearSelection()

        Me.DataGridView2.Visible = False
        Me.DataGridView1.Visible = True

        Me.PPBind.DataSource = TableAllDevices
        Me.DataGridView1.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView1.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub RadioButtonAll_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAll.CheckedChanged

        RefreshDeviceAll()

    End Sub

    Private Sub RadioButtonLowRSSI_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonLowRSSI.CheckedChanged

        RSSITrackBar.Enabled = True

        DataGridView1.ClearSelection()

        Me.DataGridView2.Visible = False
        Me.DataGridView1.Visible = True

        Me.PPBind.DataSource = TableLowRSSIDevices
        Me.DataGridView1.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView1.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub RadioButtonGoodRSSI_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonGoodRSSI.CheckedChanged

        RSSITrackBar.Enabled = True

        DataGridView1.ClearSelection()

        Me.DataGridView2.Visible = False
        Me.DataGridView1.Visible = True

        Me.PPBind.DataSource = TableGoodRSSIDevices
        Me.DataGridView1.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView1.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub OpenFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFilesToolStripMenuItem.Click

        If OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then

            RSSITrackBar.Enabled = False

        Else

            TextBox1.Text = ""
            TextBox1.Font = New System.Drawing.Font("", 8)

            FileNames = OpenFileDialog1.FileNames

            For i As Integer = 0 To (FileFound.Length - 1)
                FileFound(i) = False
            Next

            For Each f As String In OpenFileDialog1.FileNames
                DuplicateFileCheck(f)

                TextBox1.Text += f + vbCrLf
            Next

            TextBox1.TextAlign = HorizontalAlignment.Left

            ProcessFiles(OpenFileDialog1.FileNames)

            TextBox2.Visible = False

            ProcessAll()

            GroupBox1.Enabled = True
            GroupBox2.Enabled = True

            If TabControl1.SelectedIndex = 0 Then
                RadioButtonAll.Checked = True
            ElseIf TabControl1.SelectedIndex = 1 Then
                RadioButtonPanelAll.Checked = True
            End If

            SaveToolStripMenuItem.Enabled = True
            SaveEverythingToolStripMenuItem.Enabled = True

        End If

    End Sub

    Private Sub SaveTableToTextFile(TableType As Integer)

        Dim Line As String
        Dim PathName As String = Path.GetDirectoryName(FileNames(0))
        Dim Filename As String = PathName + "\" + "pp.txt"

        Dim T As New DataTable

        PathName += "\PanComPlus"
        If Directory.Exists(PathName) = False Then
            IO.Directory.CreateDirectory(PathName)
        End If

        Select Case TableType
            Case TableTypeAll
                Filename = PathName + "\info_all.txt"
                T = TableAllDevices
            Case TableTypeNotLocal
                Filename = PathName + "\info_notlocal.txt"
                T = TableNotLocalDevices
            Case TableTypeMisMatch
                Filename = PathName + "\info_mismatch.txt"
                T = TableMismatchDevices
            Case TableTypeGoodRSSI
                Filename = PathName + "\info_goodrssi.txt"
                T = TableGoodRSSIDevices
            Case TableTypeLowRSSI
                Filename = PathName + "\info_lowrssi.txt"
                T = TableLowRSSIDevices
            Case TableTypePanelAll
                Filename = PathName + "\info_panel_all.txt"
                T = TableAllPanels
            Case TableTypePanelLocal
                Filename = PathName + "\info_panel_local.txt"
                T = TableLocalPanels
            Case TableTypePanelGoodRSSI
                Filename = PathName + "\info_panel_goodrssi.txt"
                T = TableGoodRSSIPanels
        End Select

        Using sw As New StreamWriter(Filename, False, Encoding.UTF8)

            Select Case TableType
                Case TableTypeGoodRSSI, TableTypeLowRSSI
                    Line = "RSSI Value: " + RSSITrackBar.Value.ToString("D2") + " dBm"
                    sw.WriteLine(Line)
                Case TableTypePanelGoodRSSI
                    Line = "RSSI Value: " + RSSIPanelTrackBar.Value.ToString("D2") + " dBm"
                    sw.WriteLine(Line)
            End Select

            Select Case TableType
                Case TableTypeAll, TableTypeNotLocal, TableTypeMisMatch, TableTypeGoodRSSI, TableTypeLowRSSI
                    Line = ""

                    For Each col As DataColumn In T.Columns
                        Dim h As String
                        h = col.Caption
                        h = h.PadRight(8)
                        Line += h + vbTab
                    Next
                    sw.WriteLine(Line)

                    For Each row As DataRow In T.Rows
                        Line = ""
                        For Each col As DataColumn In T.Columns
                            If col.ColumnName = "Device" Then
                                Dim x As Integer
                                x = row(col.ColumnName)

                                Dim s As String
                                s = x.ToString("D3")

                                Line += s + vbTab + vbTab
                            Else
                                Line += row(col.ColumnName).ToString() + vbTab
                            End If

                        Next
                        sw.WriteLine(Line)
                    Next

                Case TableTypePanelAll, TableTypePanelLocal, TableTypePanelGoodRSSI
                    Line = ""
                    For Each col As DataColumn In T.Columns
                        Dim h As String
                        h = col.Caption
                        Line += h + vbTab
                    Next
                    sw.WriteLine(Line)

                    For Each row As DataRow In T.Rows
                        Line = ""
                        For Each col As DataColumn In T.Columns
                            If col.ColumnName = "Device" Then
                                Dim x As Integer
                                x = row(col.ColumnName)

                                Dim s As String
                                s = x.ToString("D3")

                                Line += s + vbTab
                            Else
                                Line += row(col.ColumnName).ToString() + vbTab
                            End If
                        Next
                        sw.WriteLine(Line)
                    Next

            End Select

        End Using

    End Sub

    Private Sub SaveNotLocalToolStripMenuItem_Click(sender As Object, e As EventArgs)

        SaveTableToTextFile(TableTypeNotLocal)

    End Sub

    Private Sub SaveMismatchToolStripMenuItem_Click(sender As Object, e As EventArgs)

        SaveTableToTextFile(TableTypeMisMatch)

    End Sub

    Private Sub SaveGoodRSSIToolStripMenuItem_Click(sender As Object, e As EventArgs)

        SaveTableToTextFile(TableTypeGoodRSSI)

    End Sub

    Private Sub SaveLowRSSIToolStripMenuItem_Click(sender As Object, e As EventArgs)

        SaveTableToTextFile(TableTypeLowRSSI)

    End Sub

    Private Sub SaveEverythingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveEverythingToolStripMenuItem.Click

        SaveTableToTextFile(TableTypeAll)
        SaveTableToTextFile(TableTypeNotLocal)
        SaveTableToTextFile(TableTypeMisMatch)
        SaveTableToTextFile(TableTypeGoodRSSI)
        SaveTableToTextFile(TableTypeLowRSSI)

        SaveTableToTextFile(TableTypePanelAll)
        SaveTableToTextFile(TableTypePanelLocal)
        SaveTableToTextFile(TableTypePanelGoodRSSI)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Application.Exit()
        End

    End Sub

    Public Sub RefreshPanelAll()

        RSSIPanelTrackBar.Enabled = False

        DataGridView2.ClearSelection()

        Me.DataGridView1.Visible = False
        Me.DataGridView2.Visible = True

        Me.PPBind.DataSource = TableAllPanels
        Me.DataGridView2.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView2.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub RadioButtonPanelAll_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPanelAll.CheckedChanged

        RefreshPanelAll()

    End Sub

    Private Sub RadioButtonPanelLocal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPanelLocal.CheckedChanged

        RSSIPanelTrackBar.Enabled = False

        DataGridView2.ClearSelection()

        Me.DataGridView1.Visible = False
        Me.DataGridView2.Visible = True

        Me.PPBind.DataSource = TableLocalPanels
        Me.DataGridView2.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView2.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub RadioButtonPanelGoodRSSI_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonPanelGoodRSSI.CheckedChanged

        RSSIPanelTrackBar.Enabled = True

        DataGridView2.ClearSelection()

        Me.DataGridView1.Visible = False
        Me.DataGridView2.Visible = True

        Me.PPBind.DataSource = TableGoodRSSIPanels
        Me.DataGridView2.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView1.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub RSSIPanelTrackBar_Scroll(sender As Object, e As EventArgs) Handles RSSIPanelTrackBar.Scroll

        Dim TextString As String

        TextString = "RSSI Level" + " (" + RSSIPanelTrackBar.Value.ToString + " dBm)"
        GroupBoxPanelRSSILevel.Text = TextString

        ProcessAll()

        DataGridView2.ClearSelection()

        Me.PPBind.DataSource = TableGoodRSSIPanels

        Me.DataGridView2.DataSource = Me.PPBind

        For Each c As DataGridViewColumn In DataGridView2.Columns
            c.Width = ColWidth
            c.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub

    Private Sub TextBox1_DragEnter(sender As Object, e As DragEventArgs) Handles TextBox1.DragEnter

        If e.Data.GetDataPresent("FileDrop") AndAlso (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy Then
            'A file list is being dragged and it can be copied so provide feedback to the user.
            e.Effect = DragDropEffects.Copy
        End If

    End Sub

    Private Sub SaveAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveAllToolStripMenuItem1.Click

        SaveTableToTextFile(TableTypeAll)

    End Sub

    Private Sub SaveNotLocalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveNotLocalToolStripMenuItem1.Click

        SaveTableToTextFile(TableTypeNotLocal)

    End Sub

    Private Sub SaveMismatchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveMismatchToolStripMenuItem1.Click

        SaveTableToTextFile(TableTypeMisMatch)

    End Sub

    Private Sub SaveGoodRSSIToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SaveGoodRSSIToolStripMenuItem2.Click

        SaveTableToTextFile(TableTypeGoodRSSI)

    End Sub

    Private Sub SaveLowRSSIToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveLowRSSIToolStripMenuItem1.Click

        SaveTableToTextFile(TableTypeLowRSSI)

    End Sub

    Private Sub SaveAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAllToolStripMenuItem.Click

        SaveTableToTextFile(TableTypePanelAll)

    End Sub

    Private Sub SaveLocalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveLocalToolStripMenuItem.Click

        SaveTableToTextFile(TableTypePanelLocal)

    End Sub

    Private Sub SaveGoodRSSIToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveGoodRSSIToolStripMenuItem1.Click

        SaveTableToTextFile(TableTypePanelGoodRSSI)

    End Sub

    Private Sub DuplicateFileCheck(FileName As String)

        Dim N As Integer
        Dim F As String

        F = Path.GetFileName(FileName)
        F = Mid(F, 2, 1)
        If Integer.TryParse(F, vbNull) Then
            N = Convert.ToDecimal(F)
        End If

        If N > 0 Then
            If FileFound(N - 1) = False Then
                FileFound(N - 1) = True
            Else
                F = "Panel " + N.ToString + " - Duplicate File"
                MsgBox(F)
            End If
        End If

    End Sub

    Private Sub TextBox1_DragDrop(sender As Object, e As DragEventArgs) Handles TextBox1.DragDrop

        'The data can only be dropped if it is a file list and it can be copied.
        If e.Data.GetDataPresent("FileDrop") AndAlso
           (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy Then
            'Get the data.
            Dim filePaths As String() = DirectCast(e.Data.GetData("FileDrop"),
                                                  String())

            Dim upperBound As Integer = filePaths.GetUpperBound(0)
            Dim filePath As String

            TextBox1.Text = ""
            TextBox1.Font = New System.Drawing.Font("", 8)

            TextBox1.TextAlign = HorizontalAlignment.Left

            Array.Sort(filePaths)

            For i As Integer = 0 To (FileFound.Length - 1)
                FileFound(i) = False
            Next

            'For each file in the list, add to Text Box
            For index As Integer = 0 To upperBound
                filePath = filePaths(index)

                DuplicateFileCheck(filePath)

                TextBox1.Text += filePath + vbCrLf
            Next

            ProcessFiles(filePaths)

            FileNames = filePaths

            TextBox2.Visible = False

            ProcessAll()

            GroupBox1.Enabled = True
            GroupBox2.Enabled = True

            If TabControl1.SelectedIndex = 0 Then
                RadioButtonAll.Checked = True
            ElseIf TabControl1.SelectedIndex = 1 Then
                RadioButtonPanelAll.Checked = True
            End If

            SaveToolStripMenuItem.Enabled = True
            SaveEverythingToolStripMenuItem.Enabled = True

        End If

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 0 AndAlso IsNumeric(e.Value) Then

            e.Value = Format(e.Value, "D3")
        End If
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected

        If e.TabPageIndex = 0 Then
            RadioButtonAll.Checked = True
            RefreshDeviceAll()
        ElseIf e.TabPageIndex = 1 Then
            RadioButtonPanelAll.Checked = True
            RefreshPanelAll()
        End If

    End Sub


End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonProcessFiles = New System.Windows.Forms.Button()
        Me.ButtonLowRSSI = New System.Windows.Forms.Button()
        Me.ButtonMismatch = New System.Windows.Forms.Button()
        Me.RSSITrackBar = New System.Windows.Forms.TrackBar()
        Me.ButtonAllData = New System.Windows.Forms.Button()
        Me.SliderValue = New System.Windows.Forms.TextBox()
        Me.FilteredCount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonNotLocal = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mismatch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.RSSITrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ButtonProcessFiles
        '
        Me.ButtonProcessFiles.Location = New System.Drawing.Point(15, 168)
        Me.ButtonProcessFiles.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonProcessFiles.Name = "ButtonProcessFiles"
        Me.ButtonProcessFiles.Size = New System.Drawing.Size(122, 38)
        Me.ButtonProcessFiles.TabIndex = 0
        Me.ButtonProcessFiles.Text = "Process Files"
        Me.ButtonProcessFiles.UseVisualStyleBackColor = True
        '
        'ButtonLowRSSI
        '
        Me.ButtonLowRSSI.Location = New System.Drawing.Point(406, 397)
        Me.ButtonLowRSSI.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonLowRSSI.Name = "ButtonLowRSSI"
        Me.ButtonLowRSSI.Size = New System.Drawing.Size(72, 38)
        Me.ButtonLowRSSI.TabIndex = 1
        Me.ButtonLowRSSI.Text = "Low RSSI"
        Me.ButtonLowRSSI.UseVisualStyleBackColor = True
        '
        'ButtonMismatch
        '
        Me.ButtonMismatch.Location = New System.Drawing.Point(492, 348)
        Me.ButtonMismatch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonMismatch.Name = "ButtonMismatch"
        Me.ButtonMismatch.Size = New System.Drawing.Size(76, 38)
        Me.ButtonMismatch.TabIndex = 3
        Me.ButtonMismatch.Text = "Mismatch"
        Me.ButtonMismatch.UseVisualStyleBackColor = True
        '
        'RSSITrackBar
        '
        Me.RSSITrackBar.Location = New System.Drawing.Point(492, 413)
        Me.RSSITrackBar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RSSITrackBar.Maximum = 20
        Me.RSSITrackBar.Minimum = -20
        Me.RSSITrackBar.Name = "RSSITrackBar"
        Me.RSSITrackBar.Size = New System.Drawing.Size(233, 45)
        Me.RSSITrackBar.TabIndex = 5
        Me.RSSITrackBar.Tag = "3"
        Me.RSSITrackBar.Value = 10
        '
        'ButtonAllData
        '
        Me.ButtonAllData.Location = New System.Drawing.Point(406, 348)
        Me.ButtonAllData.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonAllData.Name = "ButtonAllData"
        Me.ButtonAllData.Size = New System.Drawing.Size(76, 38)
        Me.ButtonAllData.TabIndex = 7
        Me.ButtonAllData.Text = "All Data"
        Me.ButtonAllData.UseVisualStyleBackColor = True
        '
        'SliderValue
        '
        Me.SliderValue.Location = New System.Drawing.Point(332, 366)
        Me.SliderValue.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SliderValue.Name = "SliderValue"
        Me.SliderValue.Size = New System.Drawing.Size(34, 20)
        Me.SliderValue.TabIndex = 8
        '
        'FilteredCount
        '
        Me.FilteredCount.Location = New System.Drawing.Point(297, 320)
        Me.FilteredCount.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.FilteredCount.Name = "FilteredCount"
        Me.FilteredCount.Size = New System.Drawing.Size(33, 20)
        Me.FilteredCount.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(700, 397)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "+20"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(489, 397)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "-20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(532, 397)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "-10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(591, 397)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(644, 397)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "+10"
        '
        'ButtonNotLocal
        '
        Me.ButtonNotLocal.Location = New System.Drawing.Point(572, 348)
        Me.ButtonNotLocal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonNotLocal.Name = "ButtonNotLocal"
        Me.ButtonNotLocal.Size = New System.Drawing.Size(76, 38)
        Me.ButtonNotLocal.TabIndex = 15
        Me.ButtonNotLocal.Text = "Not Local"
        Me.ButtonNotLocal.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column4, Me.Column2, Me.Column3, Me.Mismatch})
        Me.DataGridView1.Location = New System.Drawing.Point(406, 27)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(400, 301)
        Me.DataGridView1.TabIndex = 16
        '
        'Column1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Device"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 70
        '
        'Column4
        '
        Me.Column4.HeaderText = "Local Panel"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Best Panel"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Next Best Panel"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Mismatch
        '
        Me.Mismatch.HeaderText = "Status"
        Me.Mismatch.Name = "Mismatch"
        Me.Mismatch.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 27)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(363, 116)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No Files Selected"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(823, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFilesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFilesToolStripMenuItem
        '
        Me.OpenFilesToolStripMenuItem.Name = "OpenFilesToolStripMenuItem"
        Me.OpenFilesToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.OpenFilesToolStripMenuItem.Text = "Open File(s)"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(406, 27)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(400, 283)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Will Appear Here"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Devices:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Mismatch:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Not Local:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 460)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonNotLocal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FilteredCount)
        Me.Controls.Add(Me.SliderValue)
        Me.Controls.Add(Me.ButtonAllData)
        Me.Controls.Add(Me.RSSITrackBar)
        Me.Controls.Add(Me.ButtonMismatch)
        Me.Controls.Add(Me.ButtonLowRSSI)
        Me.Controls.Add(Me.ButtonProcessFiles)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.Text = "PanComPlus 1.0"
        CType(Me.RSSITrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ButtonProcessFiles As Button
    Friend WithEvents ButtonLowRSSI As Button
    Friend WithEvents ButtonMismatch As Button
    Friend WithEvents RSSITrackBar As TrackBar
    Friend WithEvents ButtonAllData As Button
    Friend WithEvents SliderValue As TextBox
    Friend WithEvents FilteredCount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButtonNotLocal As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Mismatch As DataGridViewTextBoxColumn
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class

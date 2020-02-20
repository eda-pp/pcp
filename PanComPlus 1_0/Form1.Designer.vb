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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RSSITrackBar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveNotLocalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMismatchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveGoodRSSIToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLowRSSIToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveLocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveGoodRSSIToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveEverythingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBoxRSSILevel = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonGoodRSSI = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLowRSSI = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNotLocal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMismatch = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAll = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxPanelRSSILevel = New System.Windows.Forms.GroupBox()
        Me.RSSIPanelTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButtonPanelLocal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPanelGoodRSSI = New System.Windows.Forms.RadioButton()
        Me.RadioButtonPanelAll = New System.Windows.Forms.RadioButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.RSSITrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxRSSILevel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBoxPanelRSSILevel.SuspendLayout()
        CType(Me.RSSIPanelTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'RSSITrackBar
        '
        Me.RSSITrackBar.Location = New System.Drawing.Point(22, 40)
        Me.RSSITrackBar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RSSITrackBar.Maximum = 20
        Me.RSSITrackBar.Minimum = -20
        Me.RSSITrackBar.Name = "RSSITrackBar"
        Me.RSSITrackBar.Size = New System.Drawing.Size(283, 45)
        Me.RSSITrackBar.TabIndex = 5
        Me.RSSITrackBar.Tag = "3"
        Me.RSSITrackBar.Value = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "+20"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "-20"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "-10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(214, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "+10"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(406, 27)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(400, 402)
        Me.DataGridView1.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.AllowDrop = True
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(18, 26)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(363, 116)
        Me.TextBox1.TabIndex = 17
        Me.TextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No Files Selected"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.WordWrap = False
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
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFilesToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveEverythingToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenFilesToolStripMenuItem
        '
        Me.OpenFilesToolStripMenuItem.Name = "OpenFilesToolStripMenuItem"
        Me.OpenFilesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OpenFilesToolStripMenuItem.Text = "Open File(s)"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeviceToolStripMenuItem, Me.PanelToolStripMenuItem})
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SaveToolStripMenuItem.Text = "Save Individual"
        '
        'DeviceToolStripMenuItem
        '
        Me.DeviceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAllToolStripMenuItem1, Me.SaveNotLocalToolStripMenuItem1, Me.SaveMismatchToolStripMenuItem1, Me.SaveGoodRSSIToolStripMenuItem2, Me.SaveLowRSSIToolStripMenuItem1})
        Me.DeviceToolStripMenuItem.Name = "DeviceToolStripMenuItem"
        Me.DeviceToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.DeviceToolStripMenuItem.Text = "Device"
        '
        'SaveAllToolStripMenuItem1
        '
        Me.SaveAllToolStripMenuItem1.Name = "SaveAllToolStripMenuItem1"
        Me.SaveAllToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.SaveAllToolStripMenuItem1.Text = "Save All"
        '
        'SaveNotLocalToolStripMenuItem1
        '
        Me.SaveNotLocalToolStripMenuItem1.Name = "SaveNotLocalToolStripMenuItem1"
        Me.SaveNotLocalToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.SaveNotLocalToolStripMenuItem1.Text = "Save Not Local"
        '
        'SaveMismatchToolStripMenuItem1
        '
        Me.SaveMismatchToolStripMenuItem1.Name = "SaveMismatchToolStripMenuItem1"
        Me.SaveMismatchToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.SaveMismatchToolStripMenuItem1.Text = "Save Mismatch"
        '
        'SaveGoodRSSIToolStripMenuItem2
        '
        Me.SaveGoodRSSIToolStripMenuItem2.Name = "SaveGoodRSSIToolStripMenuItem2"
        Me.SaveGoodRSSIToolStripMenuItem2.Size = New System.Drawing.Size(155, 22)
        Me.SaveGoodRSSIToolStripMenuItem2.Text = "Save Good RSSI"
        '
        'SaveLowRSSIToolStripMenuItem1
        '
        Me.SaveLowRSSIToolStripMenuItem1.Name = "SaveLowRSSIToolStripMenuItem1"
        Me.SaveLowRSSIToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.SaveLowRSSIToolStripMenuItem1.Text = "Save Low RSSI"
        '
        'PanelToolStripMenuItem
        '
        Me.PanelToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAllToolStripMenuItem, Me.SaveLocalToolStripMenuItem, Me.SaveGoodRSSIToolStripMenuItem1})
        Me.PanelToolStripMenuItem.Name = "PanelToolStripMenuItem"
        Me.PanelToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PanelToolStripMenuItem.Text = "Panel"
        '
        'SaveAllToolStripMenuItem
        '
        Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
        Me.SaveAllToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveAllToolStripMenuItem.Text = "Save All"
        '
        'SaveLocalToolStripMenuItem
        '
        Me.SaveLocalToolStripMenuItem.Name = "SaveLocalToolStripMenuItem"
        Me.SaveLocalToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SaveLocalToolStripMenuItem.Text = "Save Local"
        '
        'SaveGoodRSSIToolStripMenuItem1
        '
        Me.SaveGoodRSSIToolStripMenuItem1.Name = "SaveGoodRSSIToolStripMenuItem1"
        Me.SaveGoodRSSIToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.SaveGoodRSSIToolStripMenuItem1.Text = "Save Good RSSI"
        '
        'SaveEverythingToolStripMenuItem
        '
        Me.SaveEverythingToolStripMenuItem.Enabled = False
        Me.SaveEverythingToolStripMenuItem.Name = "SaveEverythingToolStripMenuItem"
        Me.SaveEverythingToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SaveEverythingToolStripMenuItem.Text = "Save Everything"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(406, 27)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(400, 402)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data Will Appear Here"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBoxRSSILevel
        '
        Me.GroupBoxRSSILevel.Controls.Add(Me.RSSITrackBar)
        Me.GroupBoxRSSILevel.Controls.Add(Me.Label1)
        Me.GroupBoxRSSILevel.Controls.Add(Me.Label2)
        Me.GroupBoxRSSILevel.Controls.Add(Me.Label3)
        Me.GroupBoxRSSILevel.Controls.Add(Me.Label5)
        Me.GroupBoxRSSILevel.Controls.Add(Me.Label4)
        Me.GroupBoxRSSILevel.Location = New System.Drawing.Point(6, 135)
        Me.GroupBoxRSSILevel.Name = "GroupBoxRSSILevel"
        Me.GroupBoxRSSILevel.Size = New System.Drawing.Size(328, 91)
        Me.GroupBoxRSSILevel.TabIndex = 24
        Me.GroupBoxRSSILevel.TabStop = False
        Me.GroupBoxRSSILevel.Text = "RSSI Level"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonGoodRSSI)
        Me.GroupBox2.Controls.Add(Me.RadioButtonLowRSSI)
        Me.GroupBox2.Controls.Add(Me.GroupBoxRSSILevel)
        Me.GroupBox2.Controls.Add(Me.RadioButtonNotLocal)
        Me.GroupBox2.Controls.Add(Me.RadioButtonMismatch)
        Me.GroupBox2.Controls.Add(Me.RadioButtonAll)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(341, 234)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'RadioButtonGoodRSSI
        '
        Me.RadioButtonGoodRSSI.AutoSize = True
        Me.RadioButtonGoodRSSI.Location = New System.Drawing.Point(7, 89)
        Me.RadioButtonGoodRSSI.Name = "RadioButtonGoodRSSI"
        Me.RadioButtonGoodRSSI.Size = New System.Drawing.Size(79, 17)
        Me.RadioButtonGoodRSSI.TabIndex = 29
        Me.RadioButtonGoodRSSI.Text = "Good RSSI"
        Me.RadioButtonGoodRSSI.UseVisualStyleBackColor = True
        '
        'RadioButtonLowRSSI
        '
        Me.RadioButtonLowRSSI.AutoSize = True
        Me.RadioButtonLowRSSI.Location = New System.Drawing.Point(7, 112)
        Me.RadioButtonLowRSSI.Name = "RadioButtonLowRSSI"
        Me.RadioButtonLowRSSI.Size = New System.Drawing.Size(73, 17)
        Me.RadioButtonLowRSSI.TabIndex = 28
        Me.RadioButtonLowRSSI.Text = "Low RSSI"
        Me.RadioButtonLowRSSI.UseVisualStyleBackColor = True
        '
        'RadioButtonNotLocal
        '
        Me.RadioButtonNotLocal.AutoSize = True
        Me.RadioButtonNotLocal.Location = New System.Drawing.Point(7, 43)
        Me.RadioButtonNotLocal.Name = "RadioButtonNotLocal"
        Me.RadioButtonNotLocal.Size = New System.Drawing.Size(71, 17)
        Me.RadioButtonNotLocal.TabIndex = 27
        Me.RadioButtonNotLocal.Text = "Not Local"
        Me.RadioButtonNotLocal.UseVisualStyleBackColor = True
        '
        'RadioButtonMismatch
        '
        Me.RadioButtonMismatch.AutoSize = True
        Me.RadioButtonMismatch.Location = New System.Drawing.Point(7, 66)
        Me.RadioButtonMismatch.Name = "RadioButtonMismatch"
        Me.RadioButtonMismatch.Size = New System.Drawing.Size(70, 17)
        Me.RadioButtonMismatch.TabIndex = 26
        Me.RadioButtonMismatch.Text = "Mismatch"
        Me.RadioButtonMismatch.UseVisualStyleBackColor = True
        '
        'RadioButtonAll
        '
        Me.RadioButtonAll.AutoSize = True
        Me.RadioButtonAll.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonAll.Name = "RadioButtonAll"
        Me.RadioButtonAll.Size = New System.Drawing.Size(36, 17)
        Me.RadioButtonAll.TabIndex = 0
        Me.RadioButtonAll.Text = "All"
        Me.RadioButtonAll.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(18, 163)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(363, 266)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(355, 240)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Devices"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(355, 240)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Panels"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBoxPanelRSSILevel)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPanelLocal)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPanelGoodRSSI)
        Me.GroupBox1.Controls.Add(Me.RadioButtonPanelAll)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 205)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'GroupBoxPanelRSSILevel
        '
        Me.GroupBoxPanelRSSILevel.Controls.Add(Me.RSSIPanelTrackBar)
        Me.GroupBoxPanelRSSILevel.Controls.Add(Me.Label6)
        Me.GroupBoxPanelRSSILevel.Controls.Add(Me.Label7)
        Me.GroupBoxPanelRSSILevel.Controls.Add(Me.Label8)
        Me.GroupBoxPanelRSSILevel.Controls.Add(Me.Label9)
        Me.GroupBoxPanelRSSILevel.Controls.Add(Me.Label10)
        Me.GroupBoxPanelRSSILevel.Location = New System.Drawing.Point(9, 100)
        Me.GroupBoxPanelRSSILevel.Name = "GroupBoxPanelRSSILevel"
        Me.GroupBoxPanelRSSILevel.Size = New System.Drawing.Size(322, 91)
        Me.GroupBoxPanelRSSILevel.TabIndex = 25
        Me.GroupBoxPanelRSSILevel.TabStop = False
        Me.GroupBoxPanelRSSILevel.Text = "RSSI Level"
        '
        'RSSIPanelTrackBar
        '
        Me.RSSIPanelTrackBar.BackColor = System.Drawing.Color.White
        Me.RSSIPanelTrackBar.Location = New System.Drawing.Point(22, 40)
        Me.RSSIPanelTrackBar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RSSIPanelTrackBar.Maximum = 20
        Me.RSSIPanelTrackBar.Minimum = -20
        Me.RSSIPanelTrackBar.Name = "RSSIPanelTrackBar"
        Me.RSSIPanelTrackBar.Size = New System.Drawing.Size(283, 45)
        Me.RSSIPanelTrackBar.TabIndex = 5
        Me.RSSIPanelTrackBar.Tag = "3"
        Me.RSSIPanelTrackBar.Value = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(280, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "+20"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 24)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "-20"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(88, 24)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "-10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(214, 24)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "+10"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(157, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "0"
        '
        'RadioButtonPanelLocal
        '
        Me.RadioButtonPanelLocal.AutoSize = True
        Me.RadioButtonPanelLocal.Location = New System.Drawing.Point(16, 42)
        Me.RadioButtonPanelLocal.Name = "RadioButtonPanelLocal"
        Me.RadioButtonPanelLocal.Size = New System.Drawing.Size(51, 17)
        Me.RadioButtonPanelLocal.TabIndex = 2
        Me.RadioButtonPanelLocal.TabStop = True
        Me.RadioButtonPanelLocal.Text = "Local"
        Me.RadioButtonPanelLocal.UseVisualStyleBackColor = True
        '
        'RadioButtonPanelGoodRSSI
        '
        Me.RadioButtonPanelGoodRSSI.AutoSize = True
        Me.RadioButtonPanelGoodRSSI.Location = New System.Drawing.Point(16, 65)
        Me.RadioButtonPanelGoodRSSI.Name = "RadioButtonPanelGoodRSSI"
        Me.RadioButtonPanelGoodRSSI.Size = New System.Drawing.Size(79, 17)
        Me.RadioButtonPanelGoodRSSI.TabIndex = 1
        Me.RadioButtonPanelGoodRSSI.TabStop = True
        Me.RadioButtonPanelGoodRSSI.Text = "Good RSSI"
        Me.RadioButtonPanelGoodRSSI.UseVisualStyleBackColor = True
        '
        'RadioButtonPanelAll
        '
        Me.RadioButtonPanelAll.AutoSize = True
        Me.RadioButtonPanelAll.Location = New System.Drawing.Point(16, 19)
        Me.RadioButtonPanelAll.Name = "RadioButtonPanelAll"
        Me.RadioButtonPanelAll.Size = New System.Drawing.Size(36, 17)
        Me.RadioButtonPanelAll.TabIndex = 0
        Me.RadioButtonPanelAll.TabStop = True
        Me.RadioButtonPanelAll.Text = "All"
        Me.RadioButtonPanelAll.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(406, 27)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(400, 402)
        Me.DataGridView2.TabIndex = 27
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 441)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DataGridView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "PanComPlus 1.0 Beta"
        CType(Me.RSSITrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxRSSILevel.ResumeLayout(False)
        Me.GroupBoxRSSILevel.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBoxPanelRSSILevel.ResumeLayout(False)
        Me.GroupBoxPanelRSSILevel.PerformLayout()
        CType(Me.RSSIPanelTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RSSITrackBar As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBoxRSSILevel As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButtonMismatch As RadioButton
    Friend WithEvents RadioButtonAll As RadioButton
    Friend WithEvents RadioButtonLowRSSI As RadioButton
    Friend WithEvents RadioButtonNotLocal As RadioButton
    Friend WithEvents RadioButtonGoodRSSI As RadioButton
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveEverythingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButtonPanelGoodRSSI As RadioButton
    Friend WithEvents RadioButtonPanelAll As RadioButton
    Friend WithEvents GroupBoxPanelRSSILevel As GroupBox
    Friend WithEvents RSSIPanelTrackBar As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents RadioButtonPanelLocal As RadioButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PanelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveLocalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveGoodRSSIToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveNotLocalToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveMismatchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveGoodRSSIToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SaveLowRSSIToolStripMenuItem1 As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.TitlebarLabel = New System.Windows.Forms.Label()
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.BottomRightPanel = New System.Windows.Forms.Panel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.LeftSettingsPanel = New System.Windows.Forms.Panel()
        Me.CustomizationButton = New System.Windows.Forms.Button()
        Me.TimeAndDateButton = New System.Windows.Forms.Button()
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.TimeAndDatePanel = New System.Windows.Forms.Panel()
        Me.TwentyFourHourTime = New System.Windows.Forms.CheckBox()
        Me.CustomizationPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WindowsBackColorPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CloseButtonColorPanel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TitlebarColorPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.closingtimer = New System.Windows.Forms.Timer(Me.components)
        Me.opentimer = New System.Windows.Forms.Timer(Me.components)
        Me.DisplaySettingsPanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ResolutionComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplaySettings = New System.Windows.Forms.Button()
        Me.TopPanel.SuspendLayout()
        Me.RightPanel.SuspendLayout()
        Me.LeftSettingsPanel.SuspendLayout()
        Me.TimeAndDatePanel.SuspendLayout()
        Me.CustomizationPanel.SuspendLayout()
        Me.DisplaySettingsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.TopPanel.Controls.Add(Me.CloseButton)
        Me.TopPanel.Controls.Add(Me.TitlebarLabel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(800, 43)
        Me.TopPanel.TabIndex = 1
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.MediumPurple
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(733, 3)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(53, 37)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'TitlebarLabel
        '
        Me.TitlebarLabel.AutoSize = True
        Me.TitlebarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlebarLabel.Location = New System.Drawing.Point(354, 6)
        Me.TitlebarLabel.Name = "TitlebarLabel"
        Me.TitlebarLabel.Size = New System.Drawing.Size(100, 29)
        Me.TitlebarLabel.TabIndex = 0
        Me.TitlebarLabel.Text = "Settings"
        Me.TitlebarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.RightPanel.Controls.Add(Me.BottomRightPanel)
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightPanel.Location = New System.Drawing.Point(785, 43)
        Me.RightPanel.MaximumSize = New System.Drawing.Size(15, 9000)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(15, 407)
        Me.RightPanel.TabIndex = 2
        '
        'BottomRightPanel
        '
        Me.BottomRightPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottomRightPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.BottomRightPanel.Location = New System.Drawing.Point(0, 392)
        Me.BottomRightPanel.Name = "BottomRightPanel"
        Me.BottomRightPanel.Size = New System.Drawing.Size(15, 15)
        Me.BottomRightPanel.TabIndex = 0
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 435)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(785, 15)
        Me.BottomPanel.TabIndex = 3
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 43)
        Me.LeftPanel.MaximumSize = New System.Drawing.Size(15, 9000)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(15, 392)
        Me.LeftPanel.TabIndex = 4
        '
        'LeftSettingsPanel
        '
        Me.LeftSettingsPanel.Controls.Add(Me.DisplaySettings)
        Me.LeftSettingsPanel.Controls.Add(Me.CustomizationButton)
        Me.LeftSettingsPanel.Controls.Add(Me.TimeAndDateButton)
        Me.LeftSettingsPanel.Location = New System.Drawing.Point(21, 49)
        Me.LeftSettingsPanel.Name = "LeftSettingsPanel"
        Me.LeftSettingsPanel.Size = New System.Drawing.Size(200, 380)
        Me.LeftSettingsPanel.TabIndex = 5
        '
        'CustomizationButton
        '
        Me.CustomizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomizationButton.Location = New System.Drawing.Point(3, 65)
        Me.CustomizationButton.Name = "CustomizationButton"
        Me.CustomizationButton.Size = New System.Drawing.Size(193, 55)
        Me.CustomizationButton.TabIndex = 1
        Me.CustomizationButton.Text = "Customization"
        Me.CustomizationButton.UseVisualStyleBackColor = True
        '
        'TimeAndDateButton
        '
        Me.TimeAndDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimeAndDateButton.Location = New System.Drawing.Point(4, 4)
        Me.TimeAndDateButton.Name = "TimeAndDateButton"
        Me.TimeAndDateButton.Size = New System.Drawing.Size(193, 55)
        Me.TimeAndDateButton.TabIndex = 0
        Me.TimeAndDateButton.Text = "Time and Date"
        Me.TimeAndDateButton.UseVisualStyleBackColor = True
        '
        'pullside
        '
        Me.pullside.Interval = 1
        '
        'pullbs
        '
        Me.pullbs.Interval = 1
        '
        'pullbottom
        '
        Me.pullbottom.Interval = 1
        '
        'TimeAndDatePanel
        '
        Me.TimeAndDatePanel.Controls.Add(Me.TwentyFourHourTime)
        Me.TimeAndDatePanel.Controls.Add(Me.CustomizationPanel)
        Me.TimeAndDatePanel.Location = New System.Drawing.Point(228, 49)
        Me.TimeAndDatePanel.Name = "TimeAndDatePanel"
        Me.TimeAndDatePanel.Size = New System.Drawing.Size(551, 380)
        Me.TimeAndDatePanel.TabIndex = 6
        Me.TimeAndDatePanel.Visible = False
        '
        'TwentyFourHourTime
        '
        Me.TwentyFourHourTime.AutoSize = True
        Me.TwentyFourHourTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwentyFourHourTime.Location = New System.Drawing.Point(4, 4)
        Me.TwentyFourHourTime.Name = "TwentyFourHourTime"
        Me.TwentyFourHourTime.Size = New System.Drawing.Size(171, 28)
        Me.TwentyFourHourTime.TabIndex = 0
        Me.TwentyFourHourTime.Text = "Use 24 hour time"
        Me.TwentyFourHourTime.UseVisualStyleBackColor = True
        '
        'CustomizationPanel
        '
        Me.CustomizationPanel.Controls.Add(Me.Button1)
        Me.CustomizationPanel.Controls.Add(Me.WindowsBackColorPanel)
        Me.CustomizationPanel.Controls.Add(Me.Label4)
        Me.CustomizationPanel.Controls.Add(Me.CloseButtonColorPanel)
        Me.CustomizationPanel.Controls.Add(Me.Label3)
        Me.CustomizationPanel.Controls.Add(Me.TitlebarColorPanel)
        Me.CustomizationPanel.Controls.Add(Me.Label2)
        Me.CustomizationPanel.Controls.Add(Me.Label1)
        Me.CustomizationPanel.Location = New System.Drawing.Point(0, 0)
        Me.CustomizationPanel.Name = "CustomizationPanel"
        Me.CustomizationPanel.Size = New System.Drawing.Size(551, 380)
        Me.CustomizationPanel.TabIndex = 8
        Me.CustomizationPanel.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(14, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Reset to default"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WindowsBackColorPanel
        '
        Me.WindowsBackColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WindowsBackColorPanel.Location = New System.Drawing.Point(198, 112)
        Me.WindowsBackColorPanel.Name = "WindowsBackColorPanel"
        Me.WindowsBackColorPanel.Size = New System.Drawing.Size(36, 24)
        Me.WindowsBackColorPanel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Windows Back Color"
        '
        'CloseButtonColorPanel
        '
        Me.CloseButtonColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CloseButtonColorPanel.Location = New System.Drawing.Point(198, 81)
        Me.CloseButtonColorPanel.Name = "CloseButtonColorPanel"
        Me.CloseButtonColorPanel.Size = New System.Drawing.Size(36, 24)
        Me.CloseButtonColorPanel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Close Button Color"
        '
        'TitlebarColorPanel
        '
        Me.TitlebarColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitlebarColorPanel.Location = New System.Drawing.Point(198, 50)
        Me.TitlebarColorPanel.Name = "TitlebarColorPanel"
        Me.TitlebarColorPanel.Size = New System.Drawing.Size(36, 24)
        Me.TitlebarColorPanel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Titlebar Color"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Windows"
        '
        'closingtimer
        '
        Me.closingtimer.Interval = 1
        '
        'opentimer
        '
        Me.opentimer.Interval = 10
        '
        'DisplaySettingsPanel
        '
        Me.DisplaySettingsPanel.Controls.Add(Me.ResolutionComboBox)
        Me.DisplaySettingsPanel.Controls.Add(Me.Label7)
        Me.DisplaySettingsPanel.Controls.Add(Me.Label8)
        Me.DisplaySettingsPanel.Location = New System.Drawing.Point(228, 49)
        Me.DisplaySettingsPanel.Name = "DisplaySettingsPanel"
        Me.DisplaySettingsPanel.Size = New System.Drawing.Size(551, 380)
        Me.DisplaySettingsPanel.TabIndex = 9
        Me.DisplaySettingsPanel.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Resolution"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(240, 37)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Display settings"
        '
        'ResolutionComboBox
        '
        Me.ResolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ResolutionComboBox.FormattingEnabled = True
        Me.ResolutionComboBox.Location = New System.Drawing.Point(14, 77)
        Me.ResolutionComboBox.Name = "ResolutionComboBox"
        Me.ResolutionComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ResolutionComboBox.TabIndex = 3
        '
        'DisplaySettings
        '
        Me.DisplaySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DisplaySettings.Location = New System.Drawing.Point(3, 126)
        Me.DisplaySettings.Name = "DisplaySettings"
        Me.DisplaySettings.Size = New System.Drawing.Size(193, 55)
        Me.DisplaySettings.TabIndex = 2
        Me.DisplaySettings.Text = "Display settings"
        Me.DisplaySettings.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TimeAndDatePanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.LeftSettingsPanel)
        Me.Controls.Add(Me.DisplaySettingsPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TopMost = True
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.RightPanel.ResumeLayout(False)
        Me.LeftSettingsPanel.ResumeLayout(False)
        Me.TimeAndDatePanel.ResumeLayout(False)
        Me.TimeAndDatePanel.PerformLayout()
        Me.CustomizationPanel.ResumeLayout(False)
        Me.CustomizationPanel.PerformLayout()
        Me.DisplaySettingsPanel.ResumeLayout(False)
        Me.DisplaySettingsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents CloseButton As Button
    Friend WithEvents TitlebarLabel As Label
    Friend WithEvents RightPanel As Panel
    Friend WithEvents BottomRightPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents LeftSettingsPanel As Panel
    Friend WithEvents TimeAndDateButton As Button
    Friend WithEvents pullside As Timer
    Friend WithEvents pullbs As Timer
    Friend WithEvents pullbottom As Timer
    Friend WithEvents TimeAndDatePanel As Panel
    Friend WithEvents TwentyFourHourTime As CheckBox
    Friend WithEvents CustomizationButton As Button
    Friend WithEvents CustomizationPanel As Panel
    Friend WithEvents WindowsBackColorPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents CloseButtonColorPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TitlebarColorPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents closingtimer As Timer
    Friend WithEvents opentimer As Timer
    Friend WithEvents DisplaySettingsPanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ResolutionComboBox As ComboBox
    Friend WithEvents DisplaySettings As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutVendon
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.closingtimer = New System.Windows.Forms.Timer(Me.components)
        Me.opentimer = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel.SuspendLayout()
        Me.RightPanel.SuspendLayout()
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
        Me.TopPanel.Size = New System.Drawing.Size(597, 43)
        Me.TopPanel.TabIndex = 0
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.MediumPurple
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(530, 3)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(53, 37)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'TitlebarLabel
        '
        Me.TitlebarLabel.AutoSize = True
        Me.TitlebarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlebarLabel.Location = New System.Drawing.Point(216, 6)
        Me.TitlebarLabel.Name = "TitlebarLabel"
        Me.TitlebarLabel.Size = New System.Drawing.Size(164, 29)
        Me.TitlebarLabel.TabIndex = 0
        Me.TitlebarLabel.Text = "About Vendon"
        Me.TitlebarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.RightPanel.Controls.Add(Me.BottomRightPanel)
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightPanel.Location = New System.Drawing.Point(582, 43)
        Me.RightPanel.MaximumSize = New System.Drawing.Size(15, 9000)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(15, 324)
        Me.RightPanel.TabIndex = 1
        '
        'BottomRightPanel
        '
        Me.BottomRightPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottomRightPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.BottomRightPanel.Location = New System.Drawing.Point(0, 309)
        Me.BottomRightPanel.Name = "BottomRightPanel"
        Me.BottomRightPanel.Size = New System.Drawing.Size(15, 15)
        Me.BottomRightPanel.TabIndex = 0
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 352)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(582, 15)
        Me.BottomPanel.TabIndex = 2
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 43)
        Me.LeftPanel.MaximumSize = New System.Drawing.Size(15, 9000)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(15, 309)
        Me.LeftPanel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(435, 156)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Vendon 7 (Refresh)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7.0.2153.ven7.b2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Compiled February 1, 2025"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pullbs
        '
        Me.pullbs.Interval = 1
        '
        'pullbottom
        '
        Me.pullbottom.Interval = 1
        '
        'pullside
        '
        Me.pullside.Interval = 1
        '
        'closingtimer
        '
        Me.closingtimer.Interval = 1
        '
        'opentimer
        '
        Me.opentimer.Interval = 1
        '
        'AboutVendon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(597, 367)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(597, 367)
        Me.Name = "AboutVendon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppsMenu"
        Me.TopMost = True
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.RightPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents RightPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents CloseButton As Button
    Friend WithEvents TitlebarLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BottomRightPanel As Panel
    Friend WithEvents pullbs As Timer
    Friend WithEvents pullbottom As Timer
    Friend WithEvents pullside As Timer
    Friend WithEvents closingtimer As Timer
    Friend WithEvents opentimer As Timer
End Class

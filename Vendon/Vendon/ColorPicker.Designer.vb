<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPicker
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
        Me.TitlebarLabel = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.BottomRightPanel = New System.Windows.Forms.Panel()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.closingtimer = New System.Windows.Forms.Timer(Me.components)
        Me.opentimer = New System.Windows.Forms.Timer(Me.components)
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.TopPanel.Controls.Add(Me.TitlebarLabel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(15, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(770, 43)
        Me.TopPanel.TabIndex = 5
        '
        'TitlebarLabel
        '
        Me.TitlebarLabel.AutoSize = True
        Me.TitlebarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlebarLabel.Location = New System.Drawing.Point(314, 6)
        Me.TitlebarLabel.Name = "TitlebarLabel"
        Me.TitlebarLabel.Size = New System.Drawing.Size(146, 29)
        Me.TitlebarLabel.TabIndex = 0
        Me.TitlebarLabel.Text = "Color Picker"
        Me.TitlebarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightPanel.Location = New System.Drawing.Point(785, 0)
        Me.RightPanel.MaximumSize = New System.Drawing.Size(15, 9000)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(15, 392)
        Me.RightPanel.TabIndex = 6
        '
        'BottomRightPanel
        '
        Me.BottomRightPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottomRightPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BottomRightPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.BottomRightPanel.Location = New System.Drawing.Point(785, 392)
        Me.BottomRightPanel.Name = "BottomRightPanel"
        Me.BottomRightPanel.Size = New System.Drawing.Size(15, 14)
        Me.BottomRightPanel.TabIndex = 0
        '
        'LeftPanel
        '
        Me.LeftPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.MaximumSize = New System.Drawing.Size(15, 9000)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(15, 392)
        Me.LeftPanel.TabIndex = 8
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 392)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(800, 15)
        Me.BottomPanel.TabIndex = 7
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
        Me.opentimer.Interval = 10
        '
        'ColorPicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 407)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.BottomRightPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(800, 407)
        Me.Name = "ColorPicker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ColorPicker"
        Me.TopMost = True
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents CloseButton As Button
    Friend WithEvents TitlebarLabel As Label
    Friend WithEvents RightPanel As Panel
    Friend WithEvents BottomRightPanel As Panel
    Friend WithEvents LeftPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents pullbs As Timer
    Friend WithEvents pullbottom As Timer
    Friend WithEvents pullside As Timer
    Friend WithEvents closingtimer As Timer
    Friend WithEvents opentimer As Timer
End Class

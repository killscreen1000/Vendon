<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pong))
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.TitlebarLabel = New System.Windows.Forms.Label()
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.BottomRightPanel = New System.Windows.Forms.Panel()
        Me.LeftPanel = New System.Windows.Forms.Panel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.pullbs = New System.Windows.Forms.Timer(Me.components)
        Me.pullbottom = New System.Windows.Forms.Timer(Me.components)
        Me.pullside = New System.Windows.Forms.Timer(Me.components)
        Me.closingtimer = New System.Windows.Forms.Timer(Me.components)
        Me.opentimer = New System.Windows.Forms.Timer(Me.components)
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.paddleHuman = New System.Windows.Forms.PictureBox()
        Me.paddleComputer = New System.Windows.Forms.Panel()
        Me.pnlintro = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnstartgame = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.counter = New System.Windows.Forms.Timer(Me.components)
        Me.tmrcountdown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrstoryline = New System.Windows.Forms.Timer(Me.components)
        Me.ball = New System.Windows.Forms.Panel()
        Me.lbllevelandtime = New System.Windows.Forms.Label()
        Me.lblcountdown = New System.Windows.Forms.Label()
        Me.lblstatsX = New System.Windows.Forms.Label()
        Me.lblstatsY = New System.Windows.Forms.Label()
        Me.lblstatscodepoints = New System.Windows.Forms.Label()
        Me.TopPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        CType(Me.paddleHuman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlintro.SuspendLayout()
        Me.ball.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.TopPanel.Controls.Add(Me.TitlebarLabel)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(800, 43)
        Me.TopPanel.TabIndex = 5
        '
        'TitlebarLabel
        '
        Me.TitlebarLabel.AutoSize = True
        Me.TitlebarLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitlebarLabel.Location = New System.Drawing.Point(350, 6)
        Me.TitlebarLabel.Name = "TitlebarLabel"
        Me.TitlebarLabel.Size = New System.Drawing.Size(70, 29)
        Me.TitlebarLabel.TabIndex = 0
        Me.TitlebarLabel.Text = "Pong"
        Me.TitlebarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.RightPanel.Location = New System.Drawing.Point(785, 0)
        Me.RightPanel.MaximumSize = New System.Drawing.Size(15, 9000)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(15, 435)
        Me.RightPanel.TabIndex = 6
        '
        'BottomRightPanel
        '
        Me.BottomRightPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BottomRightPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        Me.BottomRightPanel.Location = New System.Drawing.Point(785, 0)
        Me.BottomRightPanel.Name = "BottomRightPanel"
        Me.BottomRightPanel.Size = New System.Drawing.Size(15, 15)
        Me.BottomRightPanel.TabIndex = 0
        '
        'LeftPanel
        '
        Me.LeftPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LeftPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftPanel.MaximumSize = New System.Drawing.Size(15, 9000)
        Me.LeftPanel.Name = "LeftPanel"
        Me.LeftPanel.Size = New System.Drawing.Size(15, 435)
        Me.LeftPanel.TabIndex = 8
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BottomPanel.Controls.Add(Me.BottomRightPanel)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 435)
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
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.BackColor = System.Drawing.Color.MediumPurple
        Me.CloseButton.Location = New System.Drawing.Point(732, 3)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(53, 37)
        Me.CloseButton.TabIndex = 9
        '
        'paddleHuman
        '
        Me.paddleHuman.BackColor = System.Drawing.Color.Black
        Me.paddleHuman.Location = New System.Drawing.Point(30, 175)
        Me.paddleHuman.Name = "paddleHuman"
        Me.paddleHuman.Size = New System.Drawing.Size(20, 100)
        Me.paddleHuman.TabIndex = 10
        Me.paddleHuman.TabStop = False
        '
        'paddleComputer
        '
        Me.paddleComputer.BackColor = System.Drawing.Color.Black
        Me.paddleComputer.Location = New System.Drawing.Point(750, 175)
        Me.paddleComputer.Name = "paddleComputer"
        Me.paddleComputer.Size = New System.Drawing.Size(20, 100)
        Me.paddleComputer.TabIndex = 11
        '
        'pnlintro
        '
        Me.pnlintro.Controls.Add(Me.Label6)
        Me.pnlintro.Controls.Add(Me.btnstartgame)
        Me.pnlintro.Controls.Add(Me.Label8)
        Me.pnlintro.Location = New System.Drawing.Point(99, 74)
        Me.pnlintro.Name = "pnlintro"
        Me.pnlintro.Size = New System.Drawing.Size(595, 303)
        Me.pnlintro.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(589, 227)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = resources.GetString("Label6.Text")
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnstartgame
        '
        Me.btnstartgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstartgame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstartgame.Location = New System.Drawing.Point(186, 273)
        Me.btnstartgame.Name = "btnstartgame"
        Me.btnstartgame.Size = New System.Drawing.Size(242, 28)
        Me.btnstartgame.TabIndex = 15
        Me.btnstartgame.Text = "Click this button to play pong!"
        Me.btnstartgame.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(179, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 31)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Welcome to Pong!"
        '
        'gameTimer
        '
        Me.gameTimer.Interval = 30
        '
        'counter
        '
        Me.counter.Interval = 1000
        '
        'tmrcountdown
        '
        Me.tmrcountdown.Interval = 1000
        '
        'tmrstoryline
        '
        Me.tmrstoryline.Interval = 1000
        '
        'ball
        '
        Me.ball.BackColor = System.Drawing.Color.Black
        Me.ball.Controls.Add(Me.lblcountdown)
        Me.ball.Location = New System.Drawing.Point(390, 215)
        Me.ball.Name = "ball"
        Me.ball.Size = New System.Drawing.Size(20, 20)
        Me.ball.TabIndex = 15
        '
        'lbllevelandtime
        '
        Me.lbllevelandtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllevelandtime.Location = New System.Drawing.Point(58, 49)
        Me.lbllevelandtime.Name = "lbllevelandtime"
        Me.lbllevelandtime.Size = New System.Drawing.Size(684, 22)
        Me.lbllevelandtime.TabIndex = 16
        Me.lbllevelandtime.Text = "Level: 1 - 58 Seconds Left"
        Me.lbllevelandtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcountdown
        '
        Me.lblcountdown.AutoSize = True
        Me.lblcountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblcountdown.Location = New System.Drawing.Point(-8, -14)
        Me.lblcountdown.Name = "lblcountdown"
        Me.lblcountdown.Size = New System.Drawing.Size(36, 37)
        Me.lblcountdown.TabIndex = 17
        Me.lblcountdown.Text = "3"
        '
        'lblstatsX
        '
        Me.lblstatsX.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatsX.Location = New System.Drawing.Point(21, 397)
        Me.lblstatsX.Name = "lblstatsX"
        Me.lblstatsX.Size = New System.Drawing.Size(144, 35)
        Me.lblstatsX.TabIndex = 17
        Me.lblstatsX.Text = "Xspeed: "
        Me.lblstatsX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstatsY
        '
        Me.lblstatsY.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatsY.Location = New System.Drawing.Point(635, 397)
        Me.lblstatsY.Name = "lblstatsY"
        Me.lblstatsY.Size = New System.Drawing.Size(144, 35)
        Me.lblstatsY.TabIndex = 18
        Me.lblstatsY.Text = "Yspeed:"
        Me.lblstatsY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstatscodepoints
        '
        Me.lblstatscodepoints.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatscodepoints.Location = New System.Drawing.Point(291, 397)
        Me.lblstatscodepoints.Name = "lblstatscodepoints"
        Me.lblstatscodepoints.Size = New System.Drawing.Size(219, 35)
        Me.lblstatscodepoints.TabIndex = 19
        Me.lblstatscodepoints.Text = "Codepoints: "
        Me.lblstatscodepoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblstatscodepoints)
        Me.Controls.Add(Me.lblstatsY)
        Me.Controls.Add(Me.lblstatsX)
        Me.Controls.Add(Me.lbllevelandtime)
        Me.Controls.Add(Me.ball)
        Me.Controls.Add(Me.pnlintro)
        Me.Controls.Add(Me.paddleComputer)
        Me.Controls.Add(Me.paddleHuman)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.LeftPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.RightPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(800, 450)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "Pong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pong"
        Me.TopMost = True
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.BottomPanel.ResumeLayout(False)
        CType(Me.paddleHuman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlintro.ResumeLayout(False)
        Me.pnlintro.PerformLayout()
        Me.ball.ResumeLayout(False)
        Me.ball.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
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
    Friend WithEvents CloseButton As Panel
    Friend WithEvents paddleHuman As PictureBox
    Friend WithEvents paddleComputer As Panel
    Friend WithEvents pnlintro As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnstartgame As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents gameTimer As Timer
    Friend WithEvents counter As Timer
    Friend WithEvents tmrcountdown As Timer
    Friend WithEvents tmrstoryline As Timer
    Friend WithEvents ball As Panel
    Friend WithEvents lbllevelandtime As Label
    Friend WithEvents lblcountdown As Label
    Friend WithEvents lblstatsX As Label
    Friend WithEvents lblstatsY As Label
    Friend WithEvents lblstatscodepoints As Label
End Class

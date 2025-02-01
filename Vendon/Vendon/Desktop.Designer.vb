<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desktop
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
        Me.components = New System.ComponentModel.Container()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.AppMenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PinTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CurrentTime = New System.Windows.Forms.Label()
        Me.CurrentTimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.openappmenutimer = New System.Windows.Forms.Timer(Me.components)
        Me.AboutVendonButton = New System.Windows.Forms.Panel()
        Me.AboutVendonLabel = New System.Windows.Forms.Label()
        Me.SettingsButton = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PongButton = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ApplicationButton = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.AppMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.AboutVendonButton.SuspendLayout()
        Me.SettingsButton.SuspendLayout()
        Me.PongButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.MediumOrchid
        Me.FlowLayoutPanel1.Controls.Add(Me.ApplicationButton)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 567)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(827, 46)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'AppMenu
        '
        Me.AppMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AppMenu.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.AppMenu.Controls.Add(Me.PongButton)
        Me.AppMenu.Controls.Add(Me.SettingsButton)
        Me.AppMenu.Controls.Add(Me.AboutVendonButton)
        Me.AppMenu.Controls.Add(Me.Button2)
        Me.AppMenu.Location = New System.Drawing.Point(3, 354)
        Me.AppMenu.Name = "AppMenu"
        Me.AppMenu.Size = New System.Drawing.Size(184, 213)
        Me.AppMenu.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(107, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 52)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Power"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(852, 523)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vendon 7 build 2153" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "INTERNAL USE ONLY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'PinTimer
        '
        Me.PinTimer.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Panel1.Controls.Add(Me.CurrentTime)
        Me.Panel1.Location = New System.Drawing.Point(807, 567)
        Me.Panel1.MaximumSize = New System.Drawing.Size(206, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 47)
        Me.Panel1.TabIndex = 3
        '
        'CurrentTime
        '
        Me.CurrentTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentTime.Location = New System.Drawing.Point(54, 2)
        Me.CurrentTime.Name = "CurrentTime"
        Me.CurrentTime.Size = New System.Drawing.Size(150, 44)
        Me.CurrentTime.TabIndex = 0
        Me.CurrentTime.Text = "Time"
        Me.CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CurrentTimeTimer
        '
        Me.CurrentTimeTimer.Enabled = True
        '
        'openappmenutimer
        '
        Me.openappmenutimer.Interval = 1
        '
        'AboutVendonButton
        '
        Me.AboutVendonButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AboutVendonButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AboutVendonButton.Controls.Add(Me.AboutVendonLabel)
        Me.AboutVendonButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutVendonButton.Location = New System.Drawing.Point(2, 3)
        Me.AboutVendonButton.Name = "AboutVendonButton"
        Me.AboutVendonButton.Size = New System.Drawing.Size(180, 30)
        Me.AboutVendonButton.TabIndex = 5
        '
        'AboutVendonLabel
        '
        Me.AboutVendonLabel.AutoSize = True
        Me.AboutVendonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutVendonLabel.Location = New System.Drawing.Point(23, 2)
        Me.AboutVendonLabel.Name = "AboutVendonLabel"
        Me.AboutVendonLabel.Size = New System.Drawing.Size(133, 24)
        Me.AboutVendonLabel.TabIndex = 0
        Me.AboutVendonLabel.Text = "About Vendon"
        '
        'SettingsButton
        '
        Me.SettingsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SettingsButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SettingsButton.Controls.Add(Me.Label2)
        Me.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingsButton.Location = New System.Drawing.Point(2, 39)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(180, 30)
        Me.SettingsButton.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Settings"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PongButton
        '
        Me.PongButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PongButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PongButton.Controls.Add(Me.Label3)
        Me.PongButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PongButton.Location = New System.Drawing.Point(2, 75)
        Me.PongButton.Name = "PongButton"
        Me.PongButton.Size = New System.Drawing.Size(180, 30)
        Me.PongButton.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pong"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ApplicationButton
        '
        Me.ApplicationButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ApplicationButton.BackgroundImage = Global.Vendon.My.Resources.Resources.Vendon_logo
        Me.ApplicationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ApplicationButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ApplicationButton.Location = New System.Drawing.Point(3, 3)
        Me.ApplicationButton.Name = "ApplicationButton"
        Me.ApplicationButton.Size = New System.Drawing.Size(75, 41)
        Me.ApplicationButton.TabIndex = 1
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(1013, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AppMenu)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Desktop"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.AppMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.AboutVendonButton.ResumeLayout(False)
        Me.AboutVendonButton.PerformLayout()
        Me.SettingsButton.ResumeLayout(False)
        Me.SettingsButton.PerformLayout()
        Me.PongButton.ResumeLayout(False)
        Me.PongButton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents AppMenu As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PinTimer As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CurrentTime As Label
    Friend WithEvents CurrentTimeTimer As Timer
    Friend WithEvents openappmenutimer As Timer
    Friend WithEvents ApplicationButton As Panel
    Friend WithEvents AboutVendonButton As Panel
    Friend WithEvents SettingsButton As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents AboutVendonLabel As Label
    Friend WithEvents PongButton As Panel
    Friend WithEvents Label3 As Label
End Class

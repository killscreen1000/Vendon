<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RightClickMenu
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
        Me.NewPanel = New System.Windows.Forms.Panel()
        Me.NewPanelText = New System.Windows.Forms.Label()
        Me.DisplayPanel = New System.Windows.Forms.Panel()
        Me.DisplayPanelText = New System.Windows.Forms.Label()
        Me.PersonalizePanel = New System.Windows.Forms.Panel()
        Me.PersonalizeText = New System.Windows.Forms.Label()
        Me.closingtimer = New System.Windows.Forms.Timer(Me.components)
        Me.opentimer = New System.Windows.Forms.Timer(Me.components)
        Me.NewPanel.SuspendLayout()
        Me.DisplayPanel.SuspendLayout()
        Me.PersonalizePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'NewPanel
        '
        Me.NewPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.NewPanel.Controls.Add(Me.NewPanelText)
        Me.NewPanel.Location = New System.Drawing.Point(4, 6)
        Me.NewPanel.Name = "NewPanel"
        Me.NewPanel.Size = New System.Drawing.Size(243, 31)
        Me.NewPanel.TabIndex = 0
        '
        'NewPanelText
        '
        Me.NewPanelText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NewPanelText.AutoSize = True
        Me.NewPanelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPanelText.Location = New System.Drawing.Point(3, 3)
        Me.NewPanelText.Name = "NewPanelText"
        Me.NewPanelText.Size = New System.Drawing.Size(54, 25)
        Me.NewPanelText.TabIndex = 0
        Me.NewPanelText.Text = "New"
        '
        'DisplayPanel
        '
        Me.DisplayPanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.DisplayPanel.Controls.Add(Me.DisplayPanelText)
        Me.DisplayPanel.Location = New System.Drawing.Point(4, 49)
        Me.DisplayPanel.Name = "DisplayPanel"
        Me.DisplayPanel.Size = New System.Drawing.Size(243, 31)
        Me.DisplayPanel.TabIndex = 1
        '
        'DisplayPanelText
        '
        Me.DisplayPanelText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DisplayPanelText.AutoSize = True
        Me.DisplayPanelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayPanelText.Location = New System.Drawing.Point(3, 3)
        Me.DisplayPanelText.Name = "DisplayPanelText"
        Me.DisplayPanelText.Size = New System.Drawing.Size(164, 25)
        Me.DisplayPanelText.TabIndex = 0
        Me.DisplayPanelText.Text = "Display settings"
        '
        'PersonalizePanel
        '
        Me.PersonalizePanel.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.PersonalizePanel.Controls.Add(Me.PersonalizeText)
        Me.PersonalizePanel.Location = New System.Drawing.Point(4, 92)
        Me.PersonalizePanel.Name = "PersonalizePanel"
        Me.PersonalizePanel.Size = New System.Drawing.Size(243, 31)
        Me.PersonalizePanel.TabIndex = 2
        '
        'PersonalizeText
        '
        Me.PersonalizeText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PersonalizeText.AutoSize = True
        Me.PersonalizeText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalizeText.Location = New System.Drawing.Point(3, 3)
        Me.PersonalizeText.Name = "PersonalizeText"
        Me.PersonalizeText.Size = New System.Drawing.Size(125, 25)
        Me.PersonalizeText.TabIndex = 0
        Me.PersonalizeText.Text = "Personalize"
        '
        'closingtimer
        '
        Me.closingtimer.Interval = 1
        '
        'opentimer
        '
        Me.opentimer.Interval = 10
        '
        'RightClickMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(250, 129)
        Me.Controls.Add(Me.PersonalizePanel)
        Me.Controls.Add(Me.DisplayPanel)
        Me.Controls.Add(Me.NewPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RightClickMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RightClickMenu"
        Me.TopMost = True
        Me.NewPanel.ResumeLayout(False)
        Me.NewPanel.PerformLayout()
        Me.DisplayPanel.ResumeLayout(False)
        Me.DisplayPanel.PerformLayout()
        Me.PersonalizePanel.ResumeLayout(False)
        Me.PersonalizePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewPanel As Panel
    Friend WithEvents NewPanelText As Label
    Friend WithEvents DisplayPanel As Panel
    Friend WithEvents DisplayPanelText As Label
    Friend WithEvents PersonalizePanel As Panel
    Friend WithEvents PersonalizeText As Label
    Friend WithEvents closingtimer As Timer
    Friend WithEvents opentimer As Timer
End Class

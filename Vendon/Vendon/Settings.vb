Public Class Settings
#Region "Template Code"

    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        closingtimer.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles TopPanel.Paint

    End Sub

    Private Sub TopPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        If e.Button = MouseButtons.Left Then
            TitlebarLabel.Capture = False
        End If
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub TopPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If

    End Sub

    Private Sub TopPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseUp

    End Sub

    Private Sub pullbs_Tick(sender As Object, e As EventArgs) Handles pullbs.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
        Me.Height = Cursor.Position.Y - Me.Location.Y
        Dim titlebartextlocation2 As New Point(TopPanel.Width / 2 - 46, 6)
        TitlebarLabel.Location = titlebartextlocation2
    End Sub

    Private Sub pullbottom_Tick(sender As Object, e As EventArgs) Handles pullbottom.Tick
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub pullside_Tick(sender As Object, e As EventArgs) Handles pullside.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
        Dim titlebartextlocation As New Point(TopPanel.Width / 2 - 82, 6)
        TitlebarLabel.Location = titlebartextlocation
    End Sub

    Private Sub Rightpull_MouseDown(sender As Object, e As MouseEventArgs) Handles RightPanel.MouseDown
        pullside.Start()
    End Sub

    Private Sub RightPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles RightPanel.MouseUp
        pullside.Stop()
    End Sub

    Private Sub RightPanel_MouseEnter(sender As Object, e As EventArgs) Handles RightPanel.MouseEnter
        Cursor = Cursors.SizeWE
    End Sub

    Private Sub BottomPanel_MouseEnter(sender As Object, e As EventArgs) Handles BottomPanel.MouseEnter
        Cursor = Cursors.SizeNS
    End Sub

    Private Sub BottomRightPanel_MouseEnter(sender As Object, e As EventArgs) Handles BottomRightPanel.MouseEnter
        Cursor = Cursors.SizeNWSE
    End Sub

    Private Sub RightPanel_MouseLeave(sender As Object, e As EventArgs) Handles RightPanel.MouseLeave, BottomPanel.MouseLeave, BottomRightPanel.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub BottomPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles BottomPanel.MouseDown
        pullbottom.Start()
    End Sub

    Private Sub BottomPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles BottomPanel.MouseUp
        pullbottom.Stop()
    End Sub

    Private Sub BottomRightPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles BottomRightPanel.MouseDown
        pullbs.Start()
    End Sub

    Private Sub BottomRightPanel_MouseUp(sender As Object, e As MouseEventArgs) Handles BottomRightPanel.MouseUp
        pullbs.Stop()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TitlebarColorPanel.BackColor = TopPanel.BackColor
        CloseButtonColorPanel.BackColor = CloseButton.BackColor
        WindowsBackColorPanel.BackColor = CustomizationPanel.BackColor
        closingtimer.Enabled = False
        Opacity = 0
        opentimer.Enabled = True
    End Sub

    Private Sub TimeAndDateButton_Click(sender As Object, e As EventArgs) Handles TimeAndDateButton.Click
        CustomizationPanel.Visible = False
        DisplaySettingsPanel.Visible = False
        TimeAndDatePanel.Visible = True
        TimeAndDatePanel.BringToFront()
        If My.Settings.TwentyFourHourTime = True Then
            TwentyFourHourTime.Checked = True
        End If
        If My.Settings.TwentyFourHourTime = False Then
            TwentyFourHourTime.Checked = False
        End If
    End Sub

    Private Sub TwentyFourHourTime_CheckedChanged(sender As Object, e As EventArgs) Handles TwentyFourHourTime.CheckedChanged
        If TwentyFourHourTime.Checked = True Then
            My.Settings.TwentyFourHourTime = True
        End If
        If TwentyFourHourTime.Checked = False Then
            My.Settings.TwentyFourHourTime = False
        End If
    End Sub

    Private Sub LeftSettingsPanel_Paint(sender As Object, e As PaintEventArgs) Handles LeftSettingsPanel.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CustomizationButton.Click
        DisplaySettingsPanel.Visible = False
        TimeAndDatePanel.Visible = True
        CustomizationPanel.Visible = True
        CustomizationPanel.BringToFront()
    End Sub

    Private Sub CustomizationPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BottomPanel_Paint(sender As Object, e As PaintEventArgs) Handles BottomPanel.Paint

    End Sub

    Private Sub CustomizationPanel_Paint_1(sender As Object, e As PaintEventArgs) Handles CustomizationPanel.Paint

    End Sub

    Private Sub TitlebarColorPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles TitlebarColorPanel.MouseClick
        ColorPicker.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TitlebarColorPanel.BackColor = Color.DarkSlateBlue
        My.Settings.TitlebarColor = Color.DarkSlateBlue
        CloseButtonColorPanel.BackColor = Color.MediumPurple
        My.Settings.CloseButtonColor = Color.MediumPurple
        WindowsBackColorPanel.BackColor = Color.FromArgb(128, 128, 255)
        My.Settings.WindowBackColor = Color.FromArgb(128, 128, 255)
    End Sub
    Private Sub closingtimer_Tick(sender As Object, e As EventArgs) Handles closingtimer.Tick
        Opacity = Opacity - 0.1
        Dim closingposition As New Point(Location.X, Location.Y + 3)
        Location = closingposition
        If Opacity = 0 Then
            Close()
        End If
    End Sub

    Private Sub opentimer_Tick(sender As Object, e As EventArgs) Handles opentimer.Tick
        Opacity = Opacity + 0.1
        If Opacity = 1 Then
            opentimer.Stop()
        End If
    End Sub

    Private Sub DisplaySettings_Click(sender As Object, e As EventArgs) Handles DisplaySettings.Click
        TimeAndDatePanel.Visible = False
        CustomizationPanel.Visible = False
        DisplaySettingsPanel.Visible = True
        DisplaySettingsPanel.BringToFront()
        ResolutionComboBox.Items.Add(My.Computer.Screen.Bounds.Size)
    End Sub
#End Region
End Class
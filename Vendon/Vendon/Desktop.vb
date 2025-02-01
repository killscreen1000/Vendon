Public Class Desktop

    Public AboutVendonPinned As String = False
    Public AboutVendonPinning As String = False
    Public SettingsPinned As String = False
    Public SettingsPinning As String = False
    Public TaskbarAboutVendonButton As New Button
    Public TaskbarSettingsButton As New Button
    Dim amorpm As String
    Dim twelvehourhour As String
    Dim currentminute As String




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim shutdownrightclickposition As New Point(MousePosition.X, MousePosition.Y - 50)
        RightClickMenu.Width = 250
        RightClickMenu.Height = 86
        RightClickMenu.NewPanelText.Text = "Shut down"
        RightClickMenu.DisplayPanelText.Text = "Restart"
        RightClickMenu.Show()
        RightClickMenu.Location = shutdownrightclickposition
        AboutVendonPinning = True
    End Sub


    Private Sub Desktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppMenu.Hide()

        TaskbarAboutVendonButton.Width = 75
        TaskbarAboutVendonButton.Height = 41
        TaskbarAboutVendonButton.BackColor = Color.FromArgb(128, 128, 255)
        TaskbarAboutVendonButton.FlatStyle = FlatStyle.Flat
        TaskbarAboutVendonButton.Text = "About Vendon"

        TaskbarSettingsButton.Width = 75
        TaskbarSettingsButton.Height = 41
        TaskbarSettingsButton.BackColor = Color.FromArgb(128, 128, 255)
        TaskbarSettingsButton.FlatStyle = FlatStyle.Flat
        TaskbarSettingsButton.Text = "Settings"

    End Sub

    Private Sub Desktop_Click(sender As Object, e As MouseEventArgs) Handles MyBase.Click
        If e.Button = MouseButtons.Right Then

        End If
        If e.Button = MouseButtons.Left Then
            AppMenu.Hide()
            RightClickMenu.closeappmenu()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Desktop_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Right Then
            RightClickMenu.Width = 250
            RightClickMenu.Height = 129
            RightClickMenu.NewPanelText.Text = "New"
            RightClickMenu.DisplayPanelText.Text = "Display settings"
            RightClickMenu.Show()
            RightClickMenu.Location = MousePosition
        End If
    End Sub

    Private Sub AboutVendonButton_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub PinTimer_Tick(sender As Object, e As EventArgs) Handles PinTimer.Tick
        If AboutVendonPinned = True Then
            FlowLayoutPanel1.Controls.Add(TaskbarAboutVendonButton)
            AddHandler TaskbarAboutVendonButton.Click, AddressOf AboutVendonTaskbarButton_Click
            AddHandler TaskbarAboutVendonButton.MouseDown, AddressOf AboutVendonTaskbarButton_MouseDown
        End If
        If AboutVendonPinned = False Then
            If AboutVendon.Visible = False Then
                FlowLayoutPanel1.Controls.Remove(TaskbarAboutVendonButton)
            End If
        End If

        If SettingsPinned = True Then
            FlowLayoutPanel1.Controls.Add(TaskbarSettingsButton)
            AddHandler TaskbarSettingsButton.Click, AddressOf SettingsTaskbarButton_Click
            AddHandler TaskbarSettingsButton.MouseDown, AddressOf SettingsTaskbarButton_MouseDown
        End If
        If SettingsPinned = False Then
            If Settings.Visible = False Then
                FlowLayoutPanel1.Controls.Remove(TaskbarSettingsButton)
            End If
        End If
    End Sub

    Private Sub AboutVendonTaskbarButton_Click(sender As Object, e As EventArgs)
        AboutVendon.Show()
    End Sub
    Private Sub AboutVendonTaskbarButton_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim aboutvendonrightclickposition As New Point(MousePosition.X, MousePosition.Y - 50)
            RightClickMenu.Width = 250
            RightClickMenu.Height = 43
            RightClickMenu.NewPanelText.Text = "Unpin from taskbar"
            RightClickMenu.Show()
            RightClickMenu.Location = aboutvendonrightclickposition
            AboutVendonPinning = True
            SettingsPinning = False
        End If
    End Sub

    Private Sub SettingsTaskbarButton_Click(sender As Object, e As EventArgs)
        Settings.Show()
    End Sub

    Private Sub SettingsTaskbarButton_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim settingsrightclickposition As New Point(MousePosition.X, MousePosition.Y - 50)
            RightClickMenu.Width = 250
            RightClickMenu.Height = 43
            RightClickMenu.NewPanelText.Text = "Unpin from taskbar"
            RightClickMenu.Show()
            RightClickMenu.Location = settingsrightclickposition
            SettingsPinning = True
            AboutVendonPinning = False
        End If
    End Sub

    Private Sub CurrentTimeTimer_Tick(sender As Object, e As EventArgs) Handles CurrentTimeTimer.Tick

        If My.Computer.Clock.LocalTime.Hour > 11 Then
            amorpm = "PM"
        End If
        If My.Computer.Clock.LocalTime.Hour < 12 Then
            amorpm = "AM"
        End If

        If My.Computer.Clock.LocalTime.Hour > 12 Then
            twelvehourhour = My.Computer.Clock.LocalTime.Hour - 12
        End If
        If My.Computer.Clock.LocalTime.Hour < 13 Then
            twelvehourhour = My.Computer.Clock.LocalTime.Hour
        End If

        If currentminute < 10 Then
            currentminute = "0" & My.Computer.Clock.LocalTime.Minute
        End If
        If currentminute > 9 Then
            currentminute = My.Computer.Clock.LocalTime.Minute
        End If


        If My.Settings.TwentyFourHourTime = False Then
            CurrentTime.Text = twelvehourhour & ":" & currentminute & " " & amorpm
            CurrentTime.Text = CurrentTime.Text & Environment.NewLine & My.Computer.Clock.LocalTime.Month & "/" & My.Computer.Clock.LocalTime.Day & "/" & My.Computer.Clock.LocalTime.Year
        End If
        If My.Settings.TwentyFourHourTime = True Then
            CurrentTime.Text = My.Computer.Clock.LocalTime.Hour & ":" & currentminute
            CurrentTime.Text = CurrentTime.Text & Environment.NewLine & My.Computer.Clock.LocalTime.Month & "/" & My.Computer.Clock.LocalTime.Day & "/" & My.Computer.Clock.LocalTime.Year
        End If


    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingsButton_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            If SettingsPinned = False Then
                RightClickMenu.Width = 250
                RightClickMenu.Height = 43
                RightClickMenu.NewPanelText.Text = "Pin to taskbar"
                RightClickMenu.Show()
                RightClickMenu.Location = MousePosition
                SettingsPinning = True
            End If
            If SettingsPinned = True Then
                AboutVendonPinning = False
                Dim settingsrightclickposition As New Point(MousePosition.X, MousePosition.Y - 50)
                RightClickMenu.Width = 250
                RightClickMenu.Height = 43
                RightClickMenu.NewPanelText.Text = "Unpin from taskbar"
                RightClickMenu.Show()
                RightClickMenu.Location = settingsrightclickposition
                SettingsPinning = True
            End If
        End If
    End Sub

    Private Sub ApplicationButton_Paint(sender As Object, e As PaintEventArgs) Handles ApplicationButton.Paint

    End Sub

    Private Sub ApplicationButton_MouseClick(sender As Object, e As MouseEventArgs) Handles ApplicationButton.MouseClick
        AppMenu.Show()
    End Sub

    Private Sub AboutVendonButton_MouseClick(sender As Object, e As MouseEventArgs) Handles AboutVendonButton.MouseClick
        AboutVendon.Show()
        AppMenu.Hide()
        FlowLayoutPanel1.Controls.Add(TaskbarAboutVendonButton)
    End Sub

    Private Sub AboutVendonButton_MouseDown_1(sender As Object, e As MouseEventArgs) Handles AboutVendonButton.MouseDown
        If e.Button = MouseButtons.Right Then
            If AboutVendonPinned = False Then
                RightClickMenu.Width = 250
                RightClickMenu.Height = 43
                RightClickMenu.NewPanelText.Text = "Pin to taskbar"
                RightClickMenu.Show()
                RightClickMenu.Location = MousePosition
                AboutVendonPinning = True
            End If
            If AboutVendonPinned = True Then
                Dim aboutvendonrightclickposition As New Point(MousePosition.X, MousePosition.Y - 50)
                RightClickMenu.Width = 250
                RightClickMenu.Height = 43
                RightClickMenu.NewPanelText.Text = "Unpin from taskbar"
                RightClickMenu.Show()
                RightClickMenu.Location = aboutvendonrightclickposition
                AboutVendonPinning = True
            End If
        End If
    End Sub

    Private Sub SettingsButton_Paint(sender As Object, e As PaintEventArgs) Handles SettingsButton.Paint

    End Sub

    Private Sub SettingsButton_MouseClick(sender As Object, e As MouseEventArgs) Handles SettingsButton.MouseClick
        Settings.Show()
        AppMenu.Hide()
        FlowLayoutPanel1.Controls.Add(TaskbarSettingsButton)
    End Sub

    Private Sub SettingsButton_MouseDown_1(sender As Object, e As MouseEventArgs) Handles SettingsButton.MouseDown
        If e.Button = MouseButtons.Right Then
            If AboutVendonPinned = False Then
                RightClickMenu.Width = 250
                RightClickMenu.Height = 43
                RightClickMenu.NewPanelText.Text = "Pin to taskbar"
                RightClickMenu.Show()
                RightClickMenu.Location = MousePosition
                AboutVendonPinning = True
            End If
            If AboutVendonPinned = True Then
                Dim aboutvendonrightclickposition As New Point(MousePosition.X, MousePosition.Y - 50)
                RightClickMenu.Width = 250
                RightClickMenu.Height = 43
                RightClickMenu.NewPanelText.Text = "Unpin from taskbar"
                RightClickMenu.Show()
                RightClickMenu.Location = aboutvendonrightclickposition
                AboutVendonPinning = True
            End If
        End If
    End Sub

    Private Sub PongButton_MouseClick(sender As Object, e As MouseEventArgs) Handles PongButton.MouseClick
        Pong.Show()
        AppMenu.Hide()
    End Sub
End Class

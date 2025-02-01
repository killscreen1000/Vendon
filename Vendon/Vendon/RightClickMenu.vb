Public Class RightClickMenu


    Private Sub NewPanel_MouseLeave(sender As Object, e As EventArgs) Handles NewPanel.MouseLeave
        NewPanel.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub NewPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles NewPanel.MouseMove
        NewPanel.BackColor = Color.SlateBlue
    End Sub

    Private Sub DisplayPanel_MouseLeave(sender As Object, e As EventArgs) Handles DisplayPanel.MouseLeave
        DisplayPanel.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub DisplayPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles DisplayPanel.MouseMove
        DisplayPanel.BackColor = Color.SlateBlue
    End Sub
    Private Sub PersonalizePanel_MouseLeave(sender As Object, e As EventArgs) Handles PersonalizePanel.MouseLeave
        PersonalizePanel.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub PersonalizePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles PersonalizePanel.MouseMove
        PersonalizePanel.BackColor = Color.SlateBlue
    End Sub

    Private Sub NewPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles NewPanel.MouseClick
        If NewPanelText.Text = "New" Then

        End If
        If NewPanelText.Text = "Pin to taskbar" Then
            If Desktop.AboutVendonPinning = True Then
                Desktop.AboutVendonPinned = True
                Desktop.AppMenu.Hide()
                Close()
            End If
            If Desktop.SettingsPinning = True Then
                Desktop.SettingsPinned = True
                Desktop.AppMenu.Hide()
                Close()
            End If
        End If
        If NewPanelText.Text = "Unpin from taskbar" Then
            If Desktop.AboutVendonPinning = True Then
                Desktop.AboutVendonPinned = False
                Desktop.AppMenu.Hide()
                Close()
            End If
            If Desktop.SettingsPinning = True Then
                Desktop.SettingsPinned = False
                Desktop.AppMenu.Hide()
                Close()
            End If
        End If
        If NewPanelText.Text = "Shut down" Then
            Application.Exit()
        End If
    End Sub

    Private Sub NewPanel_Paint(sender As Object, e As PaintEventArgs) Handles NewPanel.Paint

    End Sub

    Private Sub DisplayPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles DisplayPanel.MouseClick
        If DisplayPanelText.Text = "Restart" Then
            Application.Restart()
        End If
        If DisplayPanelText.Text = "Display settings" Then
            Settings.Show()
            Settings.DisplaySettingsPanel.Visible = True
            Settings.DisplaySettingsPanel.BringToFront()
            Close()
        End If
    End Sub

    Private Sub RightClickMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closingtimer.Enabled = False
        Opacity = 0
        opentimer.Enabled = True
    End Sub

    Private Sub PersonalizePanel_MouseClick(sender As Object, e As MouseEventArgs) Handles PersonalizePanel.MouseClick
        If PersonalizeText.Text = "Personalize" Then
            Settings.Show()
            Settings.TimeAndDatePanel.Visible = True
            Settings.CustomizationPanel.Visible = True
            Settings.CustomizationPanel.BringToFront()
            Close()
        End If
    End Sub
    Private Sub closingtimer_Tick(sender As Object, e As EventArgs) Handles closingtimer.Tick
        Opacity = Opacity - 0.1
        If Opacity = 0 Then
            Close()
        End If
    End Sub

    Public Sub closeappmenu()
        closingtimer.Enabled = True
    End Sub

    Private Sub opentimer_Tick(sender As Object, e As EventArgs) Handles opentimer.Tick
        Opacity = Opacity + 0.1
        If Opacity = 1 Then
            opentimer.Stop()
        End If
    End Sub
End Class
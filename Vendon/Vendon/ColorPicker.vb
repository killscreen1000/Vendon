Public Class ColorPicker
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
        Dim titlebartextlocation2 As New Point(TopPanel.Width / 2 - 82, 6)
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
#End Region
    Private Sub ColorPicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closingtimer.Enabled = False
        Opacity = 0
        opentimer.Enabled = True
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
End Class
Public Class Pong
#Region "Template Code"

    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer

    Dim xVel As Single = 7
    Dim yVel As Single = 8
    Dim computerspeed = 8
    Dim rand As New Random
    Dim level As Integer = 1
    Dim secondsleft As Integer = 60
    Dim casualposition As Integer
    Dim xveldec As Double = 3.0
    Dim yveldec As Double = 3.0
    Dim incrementx As Double = 0.4
    Dim incrementy As Double = 0.2
    Dim levelxspeed As Integer = 3
    Dim levelyspeed As Integer = 3
    Dim beatairewardtotal As Integer
    Dim beataireward As Integer = 1
    Dim levelrewards(50) As Integer
    Dim totalreward As Integer
    Dim countdown As Integer = 3
    Dim paused As Boolean = False


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
        Dim titlebartextlocation2 As New Point(TopPanel.Width / 2 - 35, 6)
        TitlebarLabel.Location = titlebartextlocation2
    End Sub

    Private Sub pullbottom_Tick(sender As Object, e As EventArgs) Handles pullbottom.Tick
        Me.Height = Cursor.Position.Y - Me.Location.Y
    End Sub

    Private Sub pullside_Tick(sender As Object, e As EventArgs) Handles pullside.Tick
        Me.Width = Cursor.Position.X - Me.Location.X
        Dim titlebartextlocation As New Point(TopPanel.Width / 2 - 35, 6)
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


    Private Sub TitlebarLabel_Click(sender As Object, e As EventArgs) Handles TitlebarLabel.Click

    End Sub

    Private Sub RightPanel_Paint(sender As Object, e As PaintEventArgs) Handles RightPanel.Paint

    End Sub

    Private Sub BottomRightPanel_Paint(sender As Object, e As PaintEventArgs) Handles BottomRightPanel.Paint

    End Sub

    Private Sub BottomPanel_Paint(sender As Object, e As PaintEventArgs) Handles BottomPanel.Paint

    End Sub

    Private Sub LeftPanel_Paint(sender As Object, e As PaintEventArgs) Handles LeftPanel.Paint

    End Sub

    Private Sub AboutVendon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub CloseButton_MouseClick(sender As Object, e As MouseEventArgs) Handles CloseButton.MouseClick
        closingtimer.Enabled = True
    End Sub

    Private Sub btnstartgame_Click(sender As Object, e As EventArgs) Handles btnstartgame.Click
        newgame()
    End Sub


    Private Sub Pong_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        paddleHuman.Location = New Point(paddleHuman.Location.X, (MousePosition.Y - Me.Location.Y) - (paddleHuman.Height / 2))
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If ball.Location.X > 500 - xVel * 10 AndAlso xVel > 0 Then
            If ball.Location.Y > paddleComputer.Location.Y + 50 Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, paddleComputer.Location.Y + computerspeed)
            End If
            If ball.Location.Y < paddleComputer.Location.Y + 50 Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, paddleComputer.Location.Y - computerspeed)
            End If
            casualposition = rand.Next(-150, 201)
        Else
            If paddleComputer.Location.Y > Me.Size.Height / 2 - paddleComputer.Height + casualposition Then 'used to be me.location.y
                paddleComputer.Location = New Point(paddleComputer.Location.X, paddleComputer.Location.Y - computerspeed)
            End If
            If paddleComputer.Location.Y < Me.Size.Height / 2 - paddleComputer.Height + casualposition Then 'used to be me.location.y
                paddleComputer.Location = New Point(paddleComputer.Location.X, paddleComputer.Location.Y + computerspeed)
            End If
        End If

        'Set Xvel and Yvel speeds from decimal
        If xVel > 0 Then xVel = Math.Round(xveldec)
        If xVel < 0 Then xVel = -Math.Round(xveldec)
        If yVel > 0 Then yVel = Math.Round(yveldec)
        If yVel < 0 Then yVel = -Math.Round(yveldec)

        ' Move the game ball.
        ball.Location = New Point(ball.Location.X + xVel, ball.Location.Y + yVel)

        ' Check for top wall.
        If ball.Location.Y < 43 Then
            ball.Location = New Point(ball.Location.X, 43)
            yVel = -yVel
        End If

        ' Check for bottom wall.
        If ball.Location.Y > Me.Height - ball.Size.Height - TopPanel.Height - BottomPanel.Height Then
            ball.Location = New Point(ball.Location.X, Me.Height - ball.Size.Height - TopPanel.Height - BottomPanel.Height)
            yVel = -yVel
        End If

        ' Check for player paddle.
        If ball.Bounds.IntersectsWith(paddleHuman.Bounds) Then
            ball.Location = New Point(paddleHuman.Location.X + ball.Size.Width, ball.Location.Y)
            'randomly increase x or y speed of ball
            Select Case rand.Next(1, 3)
                Case 1
                    xveldec = xveldec + incrementx
                Case 2
                    If yveldec > 0 Then yveldec = yveldec + incrementy
                    If yveldec < 0 Then yveldec = yveldec - incrementy
            End Select
            xVel = -xVel
        End If

        ' Check for computer paddle.
        If ball.Bounds.IntersectsWith(paddleComputer.Bounds) Then
            ball.Location = New Point(paddleComputer.Location.X - paddleComputer.Size.Width + 1, ball.Location.Y)
            xveldec = xveldec + incrementx
            xVel = -xVel
        End If

        ' Check for left wall.
        If ball.Location.X < -100 Then
            ball.Location = New Point(Me.Size.Width / 2 + 200, Me.Size.Height / 2)
            paddleComputer.Location = New Point(paddleComputer.Location.X, ball.Location.Y)
            If xVel > 0 Then xVel = -xVel

            gameTimer.Stop()
            counter.Stop()

        End If

        ' Check for right wall.
        If ball.Location.X > Me.Width - ball.Size.Width - paddleComputer.Width + 100 Then
            ball.Location = New Point(Me.Size.Width / 2 + 200, Me.Size.Height / 2)
            paddleComputer.Location = New Point(paddleComputer.Location.X, ball.Location.Y)
            If xVel > 0 Then xVel = -xVel
            beatairewardtotal = beatairewardtotal + beataireward

            tmrcountdown.Start()
            gameTimer.Stop()
            counter.Stop()
        End If

        lbllevelandtime.Text = "Level: " & level & " - " & secondsleft & " Seconds Left"

        If xVel > 20 OrElse xVel < -20 Then
            paddleHuman.Width = Math.Abs(xVel)
            paddleComputer.Width = Math.Abs(xVel)
        Else
            paddleHuman.Width = 20
            paddleComputer.Width = 20
        End If

        computerspeed = Math.Abs(yVel)

    End Sub

    Private Sub counter_Tick(sender As Object, e As EventArgs) Handles counter.Tick
        secondsleft = secondsleft - 1
        If secondsleft = -1 Then
            secondsleft = 60
            level = level + 1
            counter.Stop()
            gameTimer.Stop()
        End If
    End Sub

    Private Sub tmrcountdown_Tick(sender As Object, e As EventArgs) Handles tmrcountdown.Tick
        Select Case countdown
            Case 0
                countdown = 3
                lblcountdown.Hide()
                gameTimer.Start()
                counter.Start()
                tmrcountdown.Stop()
            Case 1
                lblcountdown.Text = "1"
                countdown = countdown - 1
            Case 2
                lblcountdown.Text = "2"
                countdown = countdown - 1
            Case 3
                lblcountdown.Text = "3"
                countdown = countdown - 1
                lblcountdown.Show()
        End Select
    End Sub

    Private Sub newgame()
        pnlintro.Hide()

        level = 1
        totalreward = 0
        beataireward = 2
        beatairewardtotal = 0
        secondsleft = 60
        lblstatscodepoints.Text = "Codepoints: " 'reset stats text
        lblstatsX.Text = "Xspeed: "
        lblstatsY.Text = "Yspeed: "

        levelxspeed = 3
        levelyspeed = 3

        incrementx = 0.4
        incrementy = 0.2

        xveldec = levelxspeed
        yveldec = levelyspeed

        tmrcountdown.Start()
        ball.Location = New Point(paddleHuman.Location.X + paddleHuman.Width + 50, paddleHuman.Location.Y + paddleHuman.Height / 2)
        If xVel < 0 Then xVel = Math.Abs(xVel)
        lbllevelandtime.Text = "Level: " & level & " - " & secondsleft & " Seconds Left"
    End Sub
#End Region
End Class
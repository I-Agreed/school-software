Public Module keyStates
    Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Integer
End Module

Public Class Player
    Property X As Integer
    Property Y As Integer
    Property velX As Integer
    Property velY As Integer

    Property pRight As Integer
        Set(value As Integer)
            X = value - Math.Ceiling(Width / 2)
        End Set
        Get
            Return X + Math.Ceiling(Width / 2)
        End Get
    End Property

    Property pBottom As Integer
        Set(value As Integer)
            Y = value - Math.Ceiling(Height / 2)
        End Set
        Get
            Return Y + Math.Ceiling(Height / 2)
        End Get
    End Property

    Property pLeft As Integer
        Set(value As Integer)
            X = value + Math.Floor(Width / 2)
        End Set
        Get
            Return X - Math.Floor(Width / 2)
        End Get
    End Property

    Property pTop As Integer
        Set(value As Integer)
            Y = value + Math.Floor(Height / 2)
        End Set
        Get
            Return Y - Math.Floor(Height / 2)
        End Get
    End Property

    ReadOnly Property boundRect As Rectangle
        Get
            Return New Rectangle(New Point(pLeft, pTop), Me.Size)
        End Get
    End Property

    Property canJump As Boolean

    Property G As Integer
    Property Fv As Integer
    Property Fh As Integer
    Property maxVel = 35

    Private Sub Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Width = 100
        Height = 100

        G = 1
        Fv = 0
        Fh = 1

        X = 100
        Y = 100
        For Each r As Rectangle In Form1.windowRects
            Debug.WriteLine(r)
        Next
        updatePos()
    End Sub

    Public Function keyState(k As Keys) As Boolean
        Return CBool(GetAsyncKeyState(k))
    End Function

    Public Sub updatePos()
        Dim res As Rectangle = Form1.ScreenResolution()
        Dim rects = Form1.windowRects
        rects.Add(New Rectangle(0, 0, res.Right, 0))
        rects.Add(New Rectangle(0, 0, 0, res.Bottom))
        rects.Add(New Rectangle(0, res.Bottom - 1, res.Right, 0))
        rects.Add(New Rectangle(res.Right - 1, 0, 0, res.Bottom))


        velY += G

        Select Case True
            Case keyState(Keys.Up)
                If canJump Then
                    velY = -20
                    canJump = False
                End If
            Case keyState(Keys.Down)
                velY += 2
            Case keyState(Keys.Left)
                velX -= 2
            Case keyState(Keys.Right)
                velX += 2
        End Select


        velY = Math.Max(Math.Min(velY, maxVel), -maxVel)
        velX = Math.Max(Math.Min(velX, maxVel), -maxVel)


        Y += velY
        X += velX
        For Each r As Rectangle In rects
            If boundRect.IntersectsWith(r) Then
                If checkCollision(r) = 0 Then 'Horizontal collision
                    If velX > 0 Then
                        pRight = r.Left
                        canJump = True
                    Else
                        pLeft = r.Right
                        canJump = True
                    End If
                    velX = 0

                Else 'Vertical Collision
                    If velY > 0 Then
                        pBottom = r.Top
                        canJump = True
                    Else
                        pTop = r.Bottom
                    End If
                    velY = 0
                End If
            End If
        Next

        Dim hFriction = False
        Dim vFriction = False

        For Each r As Rectangle In rects
            If pBottom = r.Top Or pTop = r.Bottom Then
                hFriction = True
            End If
            If pRight = r.Left Or pLeft = r.Right Then
                vFriction = True
            End If
        Next

        If hFriction Then
            velX -= Fh * Math.Sign(velX)
        End If
        If vFriction Then
            velY -= Fv * Math.Sign(velY)
        End If


        Me.Location = New Point(pLeft, pTop)
    End Sub

    Function checkCollision(r As Rectangle) As Integer '1 for vertical, 0 for horizontal
        Dim xCorner, yCorner, xRect, yRect As Integer

        If velX = 0 Then
            Return 1
        ElseIf velX > 0 Then
            xCorner = pRight - velX
            xRect = r.Left
        Else
            xCorner = pLeft - velX
            xRect = r.Right
        End If

        If velY = 0 Then
            Return 0
        ElseIf velY > 0 Then
            yCorner = pBottom - velY
            yRect = r.Top
        Else
            yCorner = pTop - velY
            yRect = r.Bottom
        End If

        Dim gradient As Double = velY / velX

        If Math.Abs((xRect - xCorner) * gradient) > Math.Abs((yRect - yCorner)) Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class
Public Class AnimationBox
    Property FrameRate As Integer = 10

    Private Sub AnimationBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrameTick.Interval = Math.Floor(1000 / FrameRate)
    End Sub
End Class

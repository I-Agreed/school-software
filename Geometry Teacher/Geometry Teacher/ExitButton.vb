Public Class ExitButton
    Private Sub ExitButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = Image.FromFile("../../../Resources/exit.png")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Root.Close()
    End Sub
End Class

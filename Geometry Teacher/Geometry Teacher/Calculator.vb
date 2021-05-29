Public Class Calculator
    Property prev As Integer

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function getValue() As Integer

    End Function

    Sub bumpUp(s As String)
        prevDisplay.Text = mainDisplay.Text + " " + s
        prev = getValue()
        mainDisplay.Text = ""
    End Sub
End Class
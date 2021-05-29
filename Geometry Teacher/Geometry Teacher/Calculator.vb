Public Class Calculator
    Property prev As Integer

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainDisplay.TextAlign = HorizontalAlignment.Right
    End Sub

    Function getValue() As Integer
        Try
            Return CInt(mainDisplay.Text)
        Catch ex As FormatException
            Return 0
        End Try
    End Function

    Sub bumpUp(s As String)
        If mainDisplay.Text <> "" Then
            prevDisplay.Text = mainDisplay.Text + " " + s
        Else
            prevDisplay.Text = "0 " + s
        End If
        prev = getValue()
        mainDisplay.Text = ""
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        prev = 0
        prevDisplay.Text = ""
        mainDisplay.Text = ""
    End Sub

    Private Sub ACButton_Click(sender As Object, e As EventArgs) Handles ACButton.Click
        mainDisplay.Text = ""
    End Sub

    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delButton.Click
        If mainDisplay.Text.Length > 0 Then
            mainDisplay.Text = mainDisplay.Text.Substring(0, mainDisplay.Text.Length - 1)
        End If
    End Sub

    Sub typeNumber(n As String)
        If mainDisplay.Text < mainDisplay.MaxLength Then
            mainDisplay.Text += n
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        typeNumber("1")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        typeNumber("2")
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        typeNumber("3")
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        typeNumber("4")
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        typeNumber("5")
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        typeNumber("6")
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        typeNumber("7")
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        typeNumber("8")
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        typeNumber("9")
    End Sub

    Private Sub button0_Click(sender As Object, e As EventArgs) Handles button0.Click
        typeNumber("0")
    End Sub
End Class
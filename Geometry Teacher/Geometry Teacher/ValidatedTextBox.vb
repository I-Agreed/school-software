Public Class ValidatedTextBox
    Property AllowedText As String = ""
    Property whitelist As Boolean = True

    Event ValidatedTextChanged(ByVal sender As Object, ByVal e As EventArgs)
    Event InvalidTextEntered(ByVal sender As Object, ByVal e As EventArgs)

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        'Add your custom paint code here
    End Sub

    Private Sub ValidatedTextBox_TextChanged(sender As Object, e As EventArgs) Handles MyClass.TextChanged
        If Not Me.DesignMode Then
            Dim text As String
            Dim selection As Integer
            selection = MyBase.SelectionStart
            text = MyBase.Text
            For i As Integer = 0 To Len(MyBase.Text) - 1
                Dim letter As String
                letter = MyBase.Text.Chars(i)
                If whitelist Then
                    If AllowedText.Contains(letter) = False Then
                        text = text.Replace(letter, String.Empty)
                    End If
                Else
                    If AllowedText.Contains(letter) = True Then
                        text = text.Replace(letter, String.Empty)
                    End If
                End If

            Next
            selection -= Len(MyBase.Text) - Len(text)
            If text <> MyBase.Text Then
                MyBase.Text = text
                Try
                    MyBase.Select(selection, 0)
                Catch a As ArgumentOutOfRangeException

                End Try
                RaiseEvent InvalidTextEntered(Me, New EventArgs())
            Else
                RaiseEvent ValidatedTextChanged(Me, New EventArgs())
            End If
        End If
    End Sub
End Class

Public Class BackButton
    Private Sub BackButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles backIcon.Click
        Me.ParentForm.DialogResult = DialogResult.OK
        Me.ParentForm.Close()
    End Sub
End Class

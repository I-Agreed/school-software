Public Class Root
    Public Shapes As New ShapeData()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Function openForm(parent As Form, child As Form)
        child.StartPosition = FormStartPosition.Manual
        child.Location = parent.Location
        Dim result As DialogResult
        child.Show()

        parent.Hide()

        AddHandler child.FormClosed, Sub()
                                         result = child.DialogResult
                                         If DialogResult.Cancel = result Then
                                             Me.Close()
                                         Else
                                             parent.Location = child.Location
                                             parent.Show()
                                         End If
                                     End Sub
    End Function

    Function openSelection(type As String)
        Dim menu As New ShapeSelectionMenu(type)
        openForm(Me, menu)
    End Function

    Function openTest()
        Dim test As New TestOpenForm()
        openForm(Me, test)
    End Function

    Private Sub open3DButton_Click(sender As Object, e As EventArgs) Handles open3DButton.Click
        openSelection("3D")
    End Sub

    Private Sub open2DButton_Click(sender As Object, e As EventArgs) Handles open2DButton.Click
        openSelection("2D")
    End Sub

    Private Sub testButton_Click(sender As Object, e As EventArgs) Handles testButton.Click
        openTest()
    End Sub
End Class

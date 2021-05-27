Public Class MainMenu

    Function openSelection(type As String)
        Dim menu As New ShapeSelectionMenu(type)
        Root.openForm(Me, menu)
    End Function

    Function openTest()
        Dim test As New TestOpenForm()
        Root.openForm(Me, test)
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
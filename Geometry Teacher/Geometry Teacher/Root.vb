Public Class Root
    Public Shapes As New ShapeData()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Function openSelection(type As String)
        Dim menu As New ShapeSelectionMenu(type)
        menu.Show()
    End Function

    Private Sub open3DButton_Click(sender As Object, e As EventArgs) Handles open3DButton.Click
        openSelection("3D")
    End Sub

    Private Sub open2DButton_Click(sender As Object, e As EventArgs) Handles open2DButton.Click
        openSelection("2D")
    End Sub
End Class

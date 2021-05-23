Public Class Root
    Public Shapes As New ShapeData()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim menu As New ShapeSelectionMenu()
        menu.Show()
    End Sub
End Class

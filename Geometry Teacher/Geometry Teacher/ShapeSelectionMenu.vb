Public Class ShapeSelectionMenu
    Private selectorButtons As New List(Of ShapeSelectorButton)
    Private buttonColumns As Integer = 5
    Private Sub ShapeSelectionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each s As String In Root.Shapes.getShapes2D()
            Dim button As New ShapeSelectorButton(s)
            selectorButtons.Add(button)
            With button
                .Location = New Point(.Width * (selectorButtons.Count Mod buttonColumns), .Height * (selectorButtons.Count \ buttonColumns))
                .Visible = True
            End With
            SelectorButtonsPanel.Controls.Add(button)
        Next
    End Sub
End Class
Public Class ShapeSelectionMenu
    Private selectorButtons As New List(Of ShapeSelectorButton)
    Private buttonColumns As Integer = 5
    Private type As String = "2D"

    Public Sub New(t As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        type = t
    End Sub

    Private Sub ShapeSelectionMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim shapes As List(Of String)
        Select Case type
            Case "2D"
                shapes = Root.Shapes.getShapes2D()
            Case "3D"
                shapes = Root.Shapes.getShapes3D()
        End Select
        For Each s As String In shapes
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
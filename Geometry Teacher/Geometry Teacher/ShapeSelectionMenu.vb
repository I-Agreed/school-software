Public Class ShapeSelectionMenu
    Private selectorButtons As New List(Of ShapeSelectorButton)
    Private buttonColumns As Integer = 3
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
                Me.Text = "Learn 2D Shapes"
                title.Text = "2D Shapes"
            Case "3D"
                shapes = Root.Shapes.getShapes3D()
                Me.Text = "Learn 3D Shapes"
                title.Text = "3D Shapes"
            Case Else
                shapes = New List(Of String)
        End Select
        For Each s As String In shapes
            Dim button As New ShapeSelectorButton(s)
            With button
                .Location = New Point(.Width * (selectorButtons.Count Mod buttonColumns), .Height * (selectorButtons.Count \ buttonColumns))
                .Visible = True
            End With
            selectorButtons.Add(button)
            SelectorButtonsPanel.Controls.Add(button)
        Next
    End Sub
End Class
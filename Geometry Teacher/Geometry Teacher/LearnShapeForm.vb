Public Class LearnShapeForm
    Inherits Form
    Dim learnShape As Shape
    Public Sub New(shape As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        learnShape = Root.Shapes.getShape(shape)
    End Sub
    Private Sub LearnShapeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shapeTitle.Text = learnShape.name
        Me.Text = learnShape.name
        If learnShape.type = "3D" Then
            formulaTitle.Text = "Volume formula:"
            formulaDisplay.Text = learnShape.formula
        ElseIf learnShape.type = "2D" Then
            formulaTitle.Text = "Area formula:"
            formulaDisplay.Text = learnShape.formula
        End If

        AnimationBox1.loadImages(ImageList1)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
Public Class ShapeSelectorButton
    Property shapeName As String
    Property shape As Shape
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(s As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        shapeName = s
        shape = Root.Shapes.getShape(s)
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub ShapeSelectorButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShapeLabel.Text = shape.name
    End Sub

    Private Sub ShapeLabel_Click(sender As Object, e As EventArgs) Handles ShapeLabel.Click
        open()
    End Sub

    Private Sub ShapePicture_Click(sender As Object, e As EventArgs) Handles ShapePicture.Click
        open()
    End Sub

    Function open()
        shape.open()
    End Function
End Class

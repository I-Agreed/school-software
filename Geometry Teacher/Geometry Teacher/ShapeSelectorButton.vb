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
        ShapePicture.BackgroundImage = Root.imgs(shape.name)
    End Sub

    Function open()
        Root.openForm(Me.ParentForm, shape.getForm())
    End Function
End Class

Public Class ImageStruct
    Public exitIcon As Image = Image.FromFile("../../../Resources/exit.png")
    Public checkIcon As Image = Image.FromFile("../../../Resources/check.png")
    Public crossIcon As Image = Image.FromFile("../../../Resources/cross.png")
    Public calculatorIcon As Image = Image.FromFile("../../../Resources/calculator.png")
    Public closeCalculatorIcon As Image = Image.FromFile("../../../Resources/close calculator.png")
    Public backIcon As Image = Image.FromFile("../../../Resources/icons8-back-arrow-64.png")
    Public helpIcon As Image = Image.FromFile("../../../Resources/help.png")

    Public axis2DIcon As Image = Image.FromFile("../../../Resources/2D axis.png")
    Public axis3DIcon As Image = Image.FromFile("../../../Resources/3D axis.png")

    Public squareSizeIcon As Image = Image.FromFile("../../../Resources/square size.png")
    Public rectangleSizeIcon As Image = Image.FromFile("../../../Resources/rectangle size.png")
    Public rhombusSizeIcon As Image = Image.FromFile("../../../Resources/rhombus size.png")
    Public parallelogramSizeIcon As Image = Image.FromFile("../../../Resources/parallelogram size.png")
    Public triangleSizeIcon As Image = Image.FromFile("../../../Resources/triangle size.png")
    Public circleSizeIcon As Image = Image.FromFile("../../../Resources/circle size.png")

    Public cubeSizeIcon As Image = Image.FromFile("../../../Resources/cube size.png")
    Public rectangularprismSizeIcon As Image = Image.FromFile("../../../Resources/rectangular prism size.png")
    Public sphereSizeIcon As Image = Image.FromFile("../../../Resources/sphere size.png")
    Public squarepyramidSizeIcon As Image = Image.FromFile("../../../Resources/square pyramid size.png")
    Public triangularprismSizeIcon As Image = Image.FromFile("../../../Resources/triangular prism size.png")
    Public cylinderSizeIcon As Image = Image.FromFile("../../../Resources/cylinder size.png")

    Public circleDiagram As Image = Image.FromFile("../../../Resources/circle diagram.png")
    Public circleDiagramLabels As Image = Image.FromFile("../../../Resources/circle diagram labels.png")
    Public piIcon As Image = Image.FromFile("../../../Resources/pi.png")
    Public windowIcon As Image = Image.FromFile("../../../Resources/window icon.png")
    Public piDiagram As Image = Image.FromFile("../../../Resources/pi diagram.png")

    Public Square As Image = Image.FromFile("../../../Resources/image_square.png")
    Public Rectangle As Image = Image.FromFile("../../../Resources/image_rectangle.png")
    Public Parallelogram As Image = Image.FromFile("../../../Resources/image_parallelogram.png")
    Public Rhombus As Image = Image.FromFile("../../../Resources/image_rhombus.png")
    Public Triangle As Image = Image.FromFile("../../../Resources/image_triangle.png")
    Public Circle As Image = Image.FromFile("../../../Resources/image_circle.png")
    Public Cube As Image = Image.FromFile("../../../Resources/image_cube.png")
    Public RectangularPrism As Image = Image.FromFile("../../../Resources/image_rectangular prism.png")
    Public SquarePyramid As Image = Image.FromFile("../../../Resources/image_square pyramid.png")
    Public TriangularPrism As Image = Image.FromFile("../../../Resources/image_triangular prism.png")
    Public Cylinder As Image = Image.FromFile("../../../Resources/image_cylinder.png")
    Public Sphere As Image = Image.FromFile("../../../Resources/image_sphere.png")



    Public Sub New()

    End Sub

    Default Public ReadOnly Property Item(ByVal name As String) As Image
        Get
            Return getImage(name.Replace(" ", ""))
        End Get
    End Property

    Public Function getImage(s As String) As Image
        Return CallByName(Me, s.Replace(" ", ""), CallType.Get)
    End Function
End Class

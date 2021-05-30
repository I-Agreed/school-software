Public Class ShapeData
    Public shapes As New List(Of String)({"Square", "Rectangle", "Parallelogram", "Rhombus", "Triangle", "Circle", "Cube", "RectangularPrism", "SquarePyramid", "TriangularPrism", "Cylinder", "Sphere"})
    Public Property Square = New Shape("Square", "2D", "Length × Length", {"length"}, (Function(x As Integer()) x(0) * x(0)),
                                       "A square is a special rectangle where all the sides are the same length.")

    Public Property Rectangle = New Shape("Rectangle", "2D", "Width × Height", {"width", "height"}, (Function(x As Integer()) x(1) * x(0)),
                                          "A rectangle is a four sided shape with two sets of parallel sides at right angles.")

    Public Property Parallelogram = New Shape("Parallelogram", "2D", "Width × Height", {"width", "height"}, (Function(x As Integer()) x(1) * x(0)),
                                        "A parallelogram is a shape with 2 sets.")

    Public Property Rhombus = New Shape("Rhombus", "2D", "Length × Height", {"length", "height"}, (Function(x As Integer()) x(1) * x(0)),
                                        "A rhombus is a parallelogram with sides of equal length.")

    Public Property Triangle = New Shape("Triangle", "2D", "1/2 × Base × Height", {"base", "height"}, (Function(x As Integer()) Math.Ceiling(x(1) * x(0) * 0.5)),
                                         "A triangle is any shape with three straight sides.")

    Public Property Circle = New Shape("Circle", "2D", "Pi × Radius × Radius", {"radius"}, (Function(x As Integer()) 3 * x(0) * x(0)),
                                       "A circle is a rounded shape, where every point on its edge is the same distance from its centre. That distance is called the radius.")


    Public Property Cube = New Shape("Cube", "3D", "Length × Length × Length", {"length"}, (Function(x As Integer()) x(0) * x(0) * x(0)),
                                     "A cube is like a 3D form of a square. All of its sides are equal length, and every face is a square.")

    Public Property RectangularPrism = New Shape("Rectangular Prism", "3D", "Height × Width × Depth", {"height", "width", "depth"}, (Function(x As Integer()) x(0) * x(1) * x(2)),
                                                 "A rectangular prism is a 3D shape with 6 rectangular faces. Faces on opposite sides are the same size.")

    Public Property TriangularPrism = New Shape("Triangular Prism", "3D", "1/2 × Base × Height × Depth", {"base", "height", "depth"}, (Function(x As Integer()) Math.Ceiling(0.5 * x(0) * x(1) * x(2))),
                                                 "A triangular prism is a prism with two triangular faces. Its volume is equal to the area of the triangle multiplied by the depth.")

    Public Property SquarePyramid = New Shape("Square Pyramid", "3D", "Length × Length × Height ÷ 3", {"length", "height"}, (Function(x As Integer()) Math.Ceiling(x(0) * x(0) * x(1) / 3)),
                                                 "A square pyramid is a 3D shape made with a square base and 4 sloped triangular sides. All 4 triangular faces are the same size.")

    Public Property Cylinder = New Shape("Cylinder", "3D", "Pi × Radius × Radius × Height", {"radius", "height"}, (Function(x As Integer()) 3 * x(0) * x(0) * x(1)),
                                                 "A cylinder is a 3D shape with two circular faces joined by a single curved face. Its volume is equal to the area of the circle multiplied by the depth.")

    Public Property Sphere = New Shape("Sphere", "3D", "4/3 × Pi × Radius × Radius × Radius", {"Radius"}, (Function(x As Integer()) Math.Ceiling((4 / 3) * 3 * x(0) * x(0) * x(0))),
                                                 "A sphere is like a 3D circle. Every point on the surface is the sam distance from the centre. That distance is called the radius.")

    Default Public ReadOnly Property Item(ByVal name As String) As Shape
        Get
            Return getShape(name)
        End Get
    End Property

    Public Function getShape(s As String) As Shape
        Return CallByName(Me, s.Replace(" ", ""), CallType.Get)
    End Function

    Public Function getShapes2D() As List(Of String)
        Dim out = New List(Of String)
        For Each s As String In shapes
            If getShape(s).type = "2D" Then
                out.Add(s)
            End If
        Next
        Return out
    End Function

    Public Function getShapes3D() As List(Of String)
        Dim out = New List(Of String)
        For Each s As String In shapes
            If getShape(s).type = "3D" Then
                out.Add(s)
            End If
        Next
        Return out
    End Function

    Public Function getUnit(type As String)
        Select Case type
            Case "3D"
                Return "cm³"
            Case "2D"
                Return "cm²"
            Case Else
                Return ""
        End Select
    End Function
End Class
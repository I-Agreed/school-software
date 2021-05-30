Public Class ShapeData
    Public shapes As New List(Of String)({"Square", "Rectangle", "Triangle", "Rhombus", "Circle", "Cube", "RectangularPrism"})
    Public Property Square = New Shape("Square", "2D", "Length * Length", {"length"}, (Function(x As Integer()) x(0) * x(0)),
                                       "A square is a special rectangle where all the sides are the same length.")
    Public Property Rectangle = New Shape("Rectangle", "2D", "Length * Height", {"length", "height"}, (Function(x As Integer()) x(1) * x(0)),
                                          "A rectangle is a four sided shape with two sets of parallel sides at right angles.")
    Public Property Triangle = New Shape("Triangle", "2D", "1/2 * Base * Height", {"base", "height"}, (Function(x As Integer()) Math.Floor(x(1) * x(0) * 0.5)),
                                         "A triangle is any shape with three straight sides.")
    Public Property Rhombus = New Shape("Rhombus", "2D", "Length * Height", {"length", "height"}, (Function(x As Integer()) x(1) * x(0)),
                                        "A rhombus is a parallelogram with equal sides.")
    Public Property Circle = New Shape("Circle", "2D", "Pi × Radius × Radius", {"radius"}, (Function(x As Integer()) 3 * x(0) * x(0)),
                                       "A circle is a rounded shape, where every point on its edge is the same distance from its centre.")

    Public Property Cube = New Shape("Cube", "3D", "Length * Length * Length", {"length"}, (Function(x As Integer()) x(0) * x(0) * x(0)),
                                     "A cube is like a 3D form of a square. All of its sides are equal length, and every face is a square.")
    Public Property RectangularPrism = New Shape("Rectangular Prism", "3D", "Length * Width * Height", {"length", "width", "height"}, (Function(x As Integer()) x(0) * x(1) * x(2)),
                                                 "A rectangular prism is a 3D shape with 6 rectangular faces. Faces on opposite sides are the same size.")

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
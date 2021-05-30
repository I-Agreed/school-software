Public Class Shape
    Public Property name As String
    Public Property type As String
    Public Property formula As String
    Public Property params As String()
    Public Property formula_func As Func(Of Integer(), Integer)
    Public Property info As String
    Public ReadOnly Property value As String
        Get
            If type = "3D" Then
                Return "Volume"
            Else
                Return "Area"
            End If
        End Get
    End Property

    Public Sub New(n As String, t As String, f As String, p As String(), ff As Func(Of Integer(), Integer), i As String)
        name = n
        type = t
        formula = f
        params = p
        formula_func = ff
        info = i.Replace("\n", Environment.NewLine)
    End Sub

    Public Function getForm() As Form
        Dim f = New LearnShapeForm(Me.name)
        Return f
    End Function

    Public Function calculate(args As Integer()) As Integer
        Return formula_func.Invoke(args)
    End Function
End Class




'Public MustInherit Class Shape3D
'    Inherits Shape
'    Private Child As Shape

'    Public Sub New(c As Shape)
'        MyBase.New(c)
'        Child = c
'        type = "3D"
'    End Sub

'    MustOverride Function Volume() As Integer
'End Class

'Public MustInherit Class Shape2D
'    Inherits Shape
'    Private Child As Shape
'    Public Sub New(c As Shape)
'        MyBase.New(c)
'        Child = c
'        type = "2D"
'    End Sub
'End Class

'Public Class Square
'    Inherits Shape2D
'    Public Overrides Property params As String() = {"Length"}

'    Public Overrides Property areaFormula As String = "Length × Length"
'    Public Overrides Property volumeFormula As String = ""
'    Public Overrides Property name As String = "Square"
'    Public Overrides Property type As String = "2D"
'    Public Sub New(l As Integer)
'        MyBase.New(Me)

'        values("Length") = l
'    End Sub

'    Public Overrides Function area() As Integer
'        Return values("Length") * values("Length")
'    End Function
'End Class

'Public Class Rectangle
'    Inherits Shape2D

'    Public Overrides Property params As String() = {"Width", "Length"}
'    Public Overrides Property areaFormula As String = "Length × Width"
'    Overrides Property volumeFormula As String = ""
'    Public Overrides Property name As String = "Rectangle"
'    Public Overrides Property type As String = "2D"
'    Public Sub New(w As Integer, l As Integer)
'        MyBase.New()
'        values("Width") = w
'        values("length") = l
'    End Sub

'    Public Overrides Function Area() As Integer
'        Return values("width") * values("length")
'    End Function
'End Class

'Public Class Triangle
'    Inherits Shape2D

'    Public Overrides Property params As String() = {"Base", "Height"}
'    Public Overrides Property areaFormula As String = "1/2 × Base × Height"
'    Overrides Property volumeFormula As String = ""
'    Public Overrides Property name As String = "Triangle"
'    Public Overrides Property type As String = "2D"
'    Public Sub New(b As Integer, h As Integer)
'        MyBase.New()
'        values("base") = b
'        values("height") = h
'    End Sub
'    Public Overrides Function Area() As Integer
'        Return Math.Floor(values("base") * values("height") * 0.5)
'    End Function
'End Class

'Public Class Circle
'    Inherits Shape2D

'    Public Overrides Property params As String() = {"Radius"}
'    Public Overrides Property name As String = "circle"
'    Public Overrides Property areaFormula As String = "pi × Radius × Radius"
'    Overrides Property volumeFormula As String = ""
'    Public Overrides Property type As String = "2D"

'    Public Sub New(r As Integer)
'        MyBase.New()
'        values("radius") = r
'    End Sub
'    Public Overrides Function Area() As Integer
'        Return 3 * values("radius") * values("radius")
'    End Function
'End Class

'Public Class Rhombus
'    Inherits Shape2D

'    Public Overrides Property params As String() = {"Width", "Height"}
'    Public Overrides Property areaFormula As String = "1/2 × Width × Height"
'    Overrides Property volumeFormula As String = ""
'    Public Overrides Property name As String = "Rhombus"
'    Public Overrides Property type As String = "2D"

'    Public Sub New(w As Integer, h As Integer)
'        MyBase.New()

'        values("width") = w
'        values("height") = h
'    End Sub
'    Public Overrides Function Area() As Integer
'        Return Math.Floor(0.5 * values("width") * values("height"))
'    End Function
'End Class

'Public Class Cube
'    Inherits Shape3D

'    Public Overrides Property params As String() = {"Length"}
'    Public Overrides Property name As String = "Cube"
'    Public Overrides Property volumeFormula As String = "Length × Length × Length"
'    Public Overrides Property areaFormula As String = "6 × Length × Length"
'    Public Overrides Property type As String = "3D"

'    Public Sub New(l As Integer)
'        MyBase.New()
'        values("length") = l
'    End Sub
'    Public Overrides Function Volume() As Integer
'        Return values("length") * values("length") * values("length")
'    End Function

'    Public Overrides Function Area() As Integer
'        Return 6 * values("length") * values("length")
'    End Function
'End Class

'Public Class RectangularPrism
'    Inherits Shape3D

'    Public Overrides Property params As String() = {"Length", "Width", "Height"}
'    Public Overrides Property areaFormula As String = "2 × Width × Height + 2 × Height × Length + 2 × Length × Width"
'    Public Overrides Property volumeFormula As String = "Width × Height × Length"
'    Public Overrides Property name As String = "Rectangular Prism"
'    Public Overrides Property type As String = "3D"

'    Public Sub New(l As Integer, w As Integer, h As Integer)
'        MyBase.New()
'        values("length") = l
'        values("width") = w
'        values("height") = h
'    End Sub
'    Public Overrides Function Volume() As Integer
'        Return values("length") * values("width") * values("height")
'    End Function

'    Public Overrides Function Area() As Integer
'        Return 2 * values("length") * values("width") + 2 * values("height") * values("width") + 2 * values("height") * values("length")
'    End Function
'End Class

'Public Class Sphere
'    Inherits Shape3D

'    Public Overrides Property params As String() = {"Radius"}
'    Public Overrides Property areaFormula As String = ""
'    Public Overrides Property volumeFormula As String = "3/4 × pi × Radius × Radius × Radius"
'    Public Overrides Property name As String = "Sphere"
'    Public Overrides Property type As String = "3D"
'    Public Sub New(r As Integer)
'        MyBase.New()


'        values("radius") = r
'    End Sub
'    Public Overrides Function Volume() As Integer
'        Return Math.Floor(0.75 * 3 * values("radius") * values("radius") * values("radius"))
'    End Function

'    Public Overrides Function Area() As Integer
'        Throw New NotImplementedException()
'    End Function
'End Class

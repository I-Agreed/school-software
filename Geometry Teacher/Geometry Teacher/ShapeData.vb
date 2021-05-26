Public Class ShapeData
    Public shapes As New List(Of String)({"Square", "Rectangle", "Triangle"})
    Public Property Square = New Shape("Square", "2D", "Length * Length", {"length"}, (Function(x As Integer()) x(0) * x(0)))
    Public Property Rectangle = New Shape("Rectangle", "2D", "Length * Height", {"length", "height"}, (Function(x As Integer()) x(1) * x(0)))
    Public Property Triangle = New Shape("Triangle", "2D", "1/2 * Base * Height", {"base", "height"}, (Function(x As Integer()) x(1) * x(0) * 0.5))

    Public Function getShape(s As String) As Shape
        Return CallByName(Me, s, CallType.Get)
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
End Class
Public Class ShapeData
    Public shapes As New List(Of String)({"Square", "Rectangle"})
    Public Square = New Shape("Square", "2D", "length * length", {"length"}, Function(x As Integer()) x(0) * x(0))
    Public Rectangle = New Shape("Rectangle", "2D", "length * height", {"length", "height"}, Function(x As Integer()) x(1) * x(0))

    Public Function getShape(s As String) As Shape
        Select Case s.ToLower()
            Case "square"
                Return Square
            Case "rectangle"
                Return Rectangle
        End Select
        Return Nothing
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
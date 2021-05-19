Public Class ShapeData
    Public Shared Square = New Shape("Square", "2D", "length * length", {"length"}, Function(x As Integer()) x(0) * x(0))
    Public Shared Rectangle = New Shape("Rectangle", "2D", "length * height", {"length", "height"}, Function(x As Integer()) x(1) * x(0))

    Public Shared Function get_shape(s As String) As Shape
        Select Case s.ToLower()
            Case "square"
                Return Square
        End Select
    End Function
End Class
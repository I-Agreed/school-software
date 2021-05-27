Public Class TestForm
    Property has3D As Boolean = False
    Property has2D As Boolean = False
    Property hasHints As Boolean = False
    Property hasCalculator As Boolean = False
    Property isMultipleChoice As Boolean = False
    Private Property questions = New List(Of Question)
    Private Property shapeList As List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(D3 As Boolean, D2 As Boolean, hints As Boolean, calculator As Boolean, multipleChoice As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        has3D = D3
        has2D = D2
        hasHints = hints
        hasCalculator = calculator
        isMultipleChoice = multipleChoice
        If has2D And has3D Then
            shapeList = Root.Shapes.shapes
        ElseIf has2D Then
            shapeList = Root.Shapes.getShapes2D()
        Else
            shapeList = Root.Shapes.getShapes3D()
        End If
    End Sub

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 9
            questions(i) = genRandomQuestion()
        Next
    End Sub

    Private Function genRandomQuestion() As Question

        Dim shapeName As String
        Dim params(10) As Integer
        Dim index = Int(shapeList.Count * Rnd())

        shapeName = shapeList(index)
        For i As Integer = 0 To Root.Shapes(shapeList(shapeName)).params.Count - 1
            params(i) = Int(98 * Rnd() + 1)
        Next
        Return New Question(Root.Shapes(shapeList(shapeName)), params)
    End Function
End Class

Class Question
    Property shape As Shape
    Property values As Integer()
    Property answer As Integer

    Public Sub New(s As Shape, v As Integer())
        shape = s
        values = v
        answer = shape.calculate(values)
    End Sub
End Class
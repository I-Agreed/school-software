Public Class TestForm
    Property has3D As Boolean = False
    Property has2D As Boolean = False
    Property hasHints As Boolean = False
    Property hasCalculator As Boolean = False
    Property isMultipleChoice As Boolean = False
    Property questions As List(Of QuestionControl) = New List(Of QuestionControl)
    Private Property questionNumber As Integer = 0
    Private Property shapeList As List(Of String)
    Private Property simplifiedNumbers = False
    Private Property maxArg As Integer = 99
    Private Property score As Integer = 0

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub New(D3 As Boolean, D2 As Boolean, hints As Boolean, calculator As Boolean, multipleChoice As Boolean, sn As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        has3D = D3
        has2D = D2
        hasHints = hints
        hasCalculator = calculator

        If Not hasCalculator Then
            Root.calcLocked = True
            Root.hideCalc()
            Root.toggleCalc.Hide()
        End If

        isMultipleChoice = multipleChoice
        simplifiedNumbers = sn
        If simplifiedNumbers Then
            maxArg = 10
        End If
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
            questions.Add(genRandomQuestion())
        Next
        showQuestion(0)
    End Sub

    Private Function genRandomQuestion() As QuestionControl
        Dim shapeName As String
        Dim params(10) As Integer
        Dim index = Root.random.Next(0, shapeList.Count() - 1)

        shapeName = shapeList(index)
        For i As Integer = 0 To Root.Shapes(shapeList(index)).params.Count() - 1
            params(i) = Root.random.Next(1, maxArg)
        Next
        Dim q = New QuestionControl(Root.Shapes(shapeList(index)), params, Me)
        q.Hide()
        questionBox.Controls.Add(q)
        q.Location = New Point(0, 0)
        Return q
    End Function

    Sub endTest()
        Dim review As New TestReviewForm(questions, score)
        Root.openForm(Me, review, True)
    End Sub

    Sub showQuestion(q As Integer)
        questions(q).Show()
        If questionNumber <> q Then
            questions(questionNumber).Hide()
        End If
        questionNumber = q
        questionCounter.Text = "Question " + (q + 1).ToString() + "/10"
    End Sub

    Sub nextQuestion()
        If Not questions(questionNumber).marked Then
            If questions(questionNumber).mark() Then
                score += 1
            End If
            nextButton.Text = "Next Question"
        ElseIf questionNumber <> questions.Count() - 1 Then
            showQuestion(questionNumber + 1)
            nextButton.Text = "Mark Question"
        Else
            endTest()
        End If
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        nextQuestion()
    End Sub

    Public Sub close() Handles MyBase.Closed
        Root.calcLocked = False
        Root.toggleCalc.Show()
    End Sub

    Private Sub questionCounter_Click(sender As Object, e As EventArgs) Handles questionCounter.Click

    End Sub
End Class
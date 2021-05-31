Public Class TestReviewForm
    Property questions As List(Of QuestionControl)
    Property score As Integer
    Property questionDisplays As List(Of TestReviewItem) = New List(Of TestReviewItem)
    Property displayedQuestion = 0
    Public Sub New(ByRef q As List(Of QuestionControl), s As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        questions = q
        score = s
    End Sub

    Private Sub TestReviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scoreDisplay.Text = "You scored: " + score.ToString + "/" + questions.Count.ToString()
        For i As Integer = 0 To questions.Count() - 1
            Dim d As New TestReviewItem(i + 1, questions(i).correct, Me)
            questionsPanel.Controls.Add(d)
            d.Location = New Point(0, i * 30 * Root.scale)
            questionDisplays.Add(d)
        Next

        For Each q As QuestionControl In questions
            q.Hide()
            questionDisplayPanel.Controls.Add(q)
            q.Location = New Point(0, 0)
            q.answerInput.Enabled = False
        Next

        questionDisplays(0).selectQuestion()

        Select Case True
            Case score = 10
                comment.Text = "Amazing Job!"
            Case score >= 7
                comment.Text = "Great Job!"
            Case score >= 5
                comment.Text = "Not Bad!"
            Case Else
                comment.Text = "Better Luck Next Time!"
        End Select
    End Sub

    Sub displayQuestion(index As Integer)
        Console.WriteLine("E")
        questions(index).Show()
        If displayedQuestion <> index Then
            questions(displayedQuestion).Hide()
            questionDisplays(displayedQuestion).deselectQuestion()
        End If
        displayedQuestion = index
    End Sub

    Private Sub scoreDisplay_Click(sender As Object, e As EventArgs) Handles scoreDisplay.Click

    End Sub
End Class
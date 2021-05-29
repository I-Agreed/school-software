Public Class TestReviewForm
    Property questions As List(Of QuestionControl)
    Property score As Integer
    Public Sub New(ByRef q As List(Of QuestionControl), s As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        questions = q
        score = s
    End Sub

    Private Sub TestReviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scoreDisplay.Text = score.ToString + "/" + questions.Count.ToString()
    End Sub
End Class
Public Class TestReviewItem
    Property number As Integer
    Property correct As Boolean
    Public Sub New(n As Integer, c As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        number = n
        correct = c
    End Sub

    Private Sub TestReviewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Title.Text = "Question " + number.ToString + ":"
        'set icon
    End Sub

    Private Sub correctIcon_Click(sender As Object, e As EventArgs) Handles correctIcon.Click

    End Sub
End Class

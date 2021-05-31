Public Class TestReviewItem
    Property number As Integer
    Property correct As Boolean
    Property testReviewWindow As TestReviewForm
    Property selectedColour = Color.Gray
    Property hoverColour = Color.Silver
    Property defaultColor As Color = Color.Gainsboro
    Property selected = False

    Public Sub New(n As Integer, c As Boolean, t As TestReviewForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        number = n
        correct = c
        testReviewWindow = t
    End Sub

    Private Sub TestReviewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Title.Text = "Question " + number.ToString + ":"
        If correct Then
            correctIcon.BackgroundImage = Root.imgs.checkIcon
        Else
            correctIcon.BackgroundImage = Root.imgs.crossIcon
        End If
    End Sub

    Private Sub TestReviewItem_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        selectQuestion()
    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click
        selectQuestion()
    End Sub

    Private Sub correctIcon_Click(sender As Object, e As EventArgs) Handles correctIcon.Click
        selectQuestion()
    End Sub

    Public Sub selectQuestion()
        testReviewWindow.displayQuestion(number - 1)
        selected = True
        BackColor = selectedColour
    End Sub

    Public Sub deselectQuestion()
        selected = False
        BackColor = defaultColor
    End Sub

    Public Sub TestReviewItem_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, Title.MouseEnter, correctIcon.MouseEnter
        If Not selected Then
            BackColor = hoverColour
        End If
    End Sub

    Public Sub TestReviewItem_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, Title.MouseLeave, correctIcon.MouseLeave
        If Not selected Then
            BackColor = defaultColor
        End If
    End Sub

    Private Sub TestReviewItem_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim g = e.Graphics
        g.DrawLine(New Pen(Brushes.Black), New Point(0, 29 * Root.scale), New Point(153 * Root.scale, 29 * Root.scale))
    End Sub
End Class

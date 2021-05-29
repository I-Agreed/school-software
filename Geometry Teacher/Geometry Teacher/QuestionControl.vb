Public Class QuestionControl
    Property shape As Shape
    Property values As Integer()
    Property answer As Integer
    Property correct = False
    Property marked = False
    Property valueLabels As List(Of Label) = New List(Of Label)
    Property test As TestForm

    Public Sub New(s As Shape, v As Integer(), t As TestForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        shape = s
        values = v
        answer = shape.calculate(values)
        test = t
    End Sub

    Private Sub QuestionControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        markIcon.Hide()
        correctAnswer.Hide()
        correctFormula.Hide()
        If test.hasHints Then
            formulaTitle.Text = shape.name + " " + shape.value.ToLower + " Formula:"
            formulaDisplay.Text = shape.formula
        Else
            formulaTitle.Hide()
            formulaDisplay.Hide()
        End If

        Dim displays = {arg1Display, arg2Display, arg3Display}
        For Each d As Label In displays
            d.Hide()
        Next

        For i As Integer = 0 To shape.params.Length - 1
            displays(i).Text = values(i)
            displays(i).Show()
        Next

        For i As Integer = 0 To shape.params.Count - 1
            Dim l = New Label
            With l
                .Location = New Point(0, 30 * i)
                .AutoSize = False
                .Size = New Size(70, 25)
                .Text = shape.params(i) + ":"
                .TextAlign = ContentAlignment.MiddleRight
            End With
            Me.argValuePanel.Controls.Add(l)
            valueLabels.Add(l)

            Dim l2 = New Label
            With l2
                .Location = New Point(70, 30 * i)
                .AutoSize = False
                .Size = New Size(40, 25)
                .Text = values(i).ToString() + " cm"
                .TextAlign = ContentAlignment.MiddleLeft
            End With
            Me.argValuePanel.Controls.Add(l2)
            valueLabels.Add(l2)
        Next

        correctFormula.Text = shape.value + " = " + shape.formula

        correctAnswer.Text = answer.ToString() + " " + Root.Shapes.getUnit(shape.type)
    End Sub

    Function mark() As Boolean
        If Not marked Then
            marked = True
            answerInput.Enabled = False
            If answerInput.Text = answer.ToString Then
                correct = True
                markIcon.BackgroundImage = icons.Images(1)
            Else
                correctFormula.Show()
                markIcon.BackgroundImage = icons.Images(0)
            End If
            markIcon.Show()
            correctAnswer.Show()
        End If
        Return correct
    End Function
End Class

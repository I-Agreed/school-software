Public Class QuestionControl
    Property shape As Shape
    Property values As Integer()
    Property answer As Integer
    Property correct = False
    Property marked = False
    Property test As TestForm
    Property valueLabels As New List(Of Label)

    Private shapeTextLocations As Dictionary(Of String, Point()) = New Dictionary(Of String, Point())
    Private shapeArgLabels As New List(Of Label)

    Public Sub New(s As Shape, v As Integer(), t As TestForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        shape = s
        values = v
        answer = shape.calculate(values)
        test = t

        With shapeTextLocations
            .Item("Square") = {New Point(180, 85), New Point(77, 177)}
            .Item("Circle") = {New Point(188, 72)}
            .Item("Rectangle") = {New Point(73, 185), New Point(163, 79)}
            .Item("Rhombus") = {New Point(75, 185), New Point(153, 83)}
            .Item("Parallelogram") = {New Point(65, 185), New Point(183, 81)}
            .Item("Triangle") = {New Point(180, 85), New Point(77, 177)}
            .Item("Cube") = {New Point(63, 181), New Point(152, 159), New Point(181, 69)}
            .Item("Rectangular Prism") = {New Point(152, 65), New Point(46, 177), New Point(125, 149)}
            .Item("Sphere") = {New Point(181, 69)}
            .Item("Square Pyramid") = {New Point(64, 177), New Point(181, 75)}
            .Item("Triangular Prism") = {New Point(54, 177), New Point(181, 61), New Point(148, 147)}
            .Item("Cylinder") = {New Point(89, 193), New Point(181, 75)}
        End With
    End Sub

    Private Sub QuestionControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        argLabelBase.Hide()
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
        Dim font As New Font("Rockwell", 11)

        For i As Integer = 0 To shape.params.Count - 1
            Dim l = New Label
            With l
                .AutoSize = False
                .Location = New Point(0, 30 * i)
                .Size = New Size(70, 25)
                .Text = shape.params(i) + ":"
                .TextAlign = ContentAlignment.MiddleRight
                .Font = font
            End With
            Me.argValuePanel.Controls.Add(l)
            valueLabels.Add(l)

            Dim l2 = New Label
            With l2
                .AutoSize = False
                .Location = New Point(70, 30 * i + 4)
                .Size = New Size(40, 25)
                .Text = values(i).ToString() + " cm"
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = font
            End With
            Me.argValuePanel.Controls.Add(l2)
            valueLabels.Add(l2)
        Next

        correctFormula.Text = shape.value + " = " + shape.formula

        correctAnswer.Text = answer.ToString() + " " + Root.Shapes.getUnit(shape.type)

        shapeDisplay.BackgroundImage = Root.imgs(shape.name.ToLower() + "SizeIcon")
        For t As Integer = 0 To shapeTextLocations(shape.name).Length - 1
            Dim lb As New Label()
            With lb
                .Location = shapeTextLocations(shape.name)(t)
                .Text = "0"
                .Font = argLabelBase.Font
                .Size = argLabelBase.Size
                .TextAlign = argLabelBase.TextAlign
                .BackColor = Color.Transparent
            End With
            Me.picPanel.Controls.Add(lb)
            lb.BringToFront()
            shapeArgLabels.Add(lb)
        Next
    End Sub

    Function mark() As Boolean
        If Not marked Then
            marked = True
            answerInput.Enabled = False
            If answerInput.Text = answer.ToString Then
                correct = True
                markIcon.BackgroundImage = Root.imgs.checkIcon
            Else
                correctFormula.Show()
                markIcon.BackgroundImage = Root.imgs.crossIcon
            End If
            markIcon.Show()
            correctAnswer.Show()
        End If
        Return correct
    End Function
End Class

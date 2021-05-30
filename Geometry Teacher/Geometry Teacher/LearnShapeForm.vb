Public Class LearnShapeForm
    Inherits Form
    Dim learnShape As Shape
    Public inputLabels As New List(Of Label)
    Public inputBoxes As New List(Of ValidatedTextBox)
    Public inputUnits As New List(Of Label)

    Private shapeTextLocations As Dictionary(Of String, Point()) = New Dictionary(Of String, Point())
    Private shapeArgLabels As New List(Of Label)


    Public Sub New(shape As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        learnShape = Root.Shapes.getShape(shape)

        With shapeTextLocations
            .Item("Square") = {New Point(170, 75), New Point(67, 167)}
        End With

    End Sub

    Private Sub LearnShapeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        argLabelBase.Hide()
        shapeTitle.Text = learnShape.name
        infoBox.Text = learnShape.info
        Me.Text = learnShape.name
        If learnShape.type = "3D" Then
            formulaTitle.Text = "Volume formula:"
            formulaDisplay.Text = learnShape.formula
        ElseIf learnShape.type = "2D" Then
            formulaTitle.Text = "Area formula:"
            formulaDisplay.Text = learnShape.formula
        End If

        For i As Integer = 0 To learnShape.params.Count - 1
            Dim l = New Label
            With l
                .Location = New Point(0, 50 * i)
                .AutoSize = False
                .Size = New Size(90, 30)
                .Text = learnShape.params(i) + ":"
                .TextAlign = ContentAlignment.MiddleRight
                .Font = formulaTitle.Font
            End With
            Me.inputPanel.Controls.Add(l)
            inputLabels.Add(l)

            Dim b = New ValidatedTextBox
            With b
                .Location = New Point(90, 50 * i)
                .Size = New Size(40, 30)
                .AllowedText = "1234567890"
                .Text = "0"
                .MaxLength = 2
                .Font = formulaTitle.Font
            End With
            Me.inputPanel.Controls.Add(b)
            inputBoxes.Add(b)
            AddHandler b.ValidatedTextChanged, AddressOf inputUpdate

            Dim l2 = New Label
            With l2
                .Location = New Point(130, 50 * i)
                .AutoSize = False
                .Size = New Size(50, 30)
                .Text = "cm"
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = formulaTitle.Font
            End With
            Me.inputPanel.Controls.Add(l2)
            inputLabels.Add(l2)
        Next

        resultLabel.Text = learnShape.value + " = 0 " + Root.Shapes.getUnit(learnShape.type)

        For t As Integer = 0 To shapeTextLocations(learnShape.name).Length - 1
            Dim lb As New Label()
            With lb
                .Location = shapeTextLocations(learnShape.name)(t)
                .Text = "0"
                .Font = argLabelBase.Font
                .Size = argLabelBase.Size
                .TextAlign = argLabelBase.TextAlign
            End With
            Me.imagePanel.Controls.Add(lb)
            lb.BringToFront()
            shapeArgLabels.Add(lb)
        Next
    End Sub

    Private Sub inputUpdate()
        resultLabel.Text = learnShape.value + " = " + learnShape.calculate(getArgs()).ToString() + " " + Root.Shapes.getUnit(learnShape.type)

        Dim t As Integer = 0
        For i As Integer = 0 To shapeArgLabels.Count - 1
            shapeArgLabels(i).Text = inputBoxes(t).Text
            If t < inputBoxes.Count - 1 Then
                t += 1
            End If
        Next
    End Sub

    Function getArgs() As Integer()
        Dim out(learnShape.params.Length) As Integer
        For i As Integer = 0 To learnShape.params.Length - 1
            Try
                out(i) = Convert.ToInt32(inputBoxes(i).Text)
            Catch e As FormatException
                out(i) = 0
            End Try
        Next
        Return out
    End Function
End Class
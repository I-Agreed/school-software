Public Class LearnShapeForm
    Inherits Form
    Dim learnShape As Shape
    Public inputLabels As New List(Of Label)
    Public inputBoxes As New List(Of ValidatedTextBox)
    Public Sub New(shape As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        learnShape = Root.Shapes.getShape(shape)
    End Sub

    Private Sub LearnShapeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        shapeTitle.Text = learnShape.name
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
                .Location = New Point(0, 20 * i)
                .AutoSize = False
                .Width = 50
                .Text = learnShape.params(i) + ":"
                .TextAlign = ContentAlignment.MiddleRight
            End With
            Me.inputPanel.Controls.Add(l)
            inputLabels.Add(l)

            Dim b = New ValidatedTextBox
            With b
                .Location = New Point(50, 26 * i)
                .AllowedText = "1234567890"
                .Text = "0"
                .MaxLength = 2
            End With
            Me.inputPanel.Controls.Add(b)
            inputBoxes.Add(b)
            AddHandler b.ValidatedTextChanged, AddressOf inputUpdate
        Next

        AnimationBox1.loadImages(ImageList1)
    End Sub

    Private Sub inputUpdate()
        resultLabel.Text = learnShape.calculate(getArgs())
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
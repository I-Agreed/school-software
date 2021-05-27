Public Class TestOpenForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Function openTest()
        Dim D2 As Boolean
        Dim D3 As Boolean
        Dim hints As Boolean
        Dim calculator As Boolean
        Dim multipleChoice As Boolean

        If select2D.Checked Then
            D2 = True
        ElseIf select3D.Checked Then
            D3 = True
        ElseIf selectBoth.Checked Then
            D2 = True
            D3 = True
        End If

        hints = selectHints.Checked()
        calculator = selectCalculator.Checked()
        multipleChoice = selectMultipleChoice.Checked()

        Dim test As New TestForm(D3, D2, hints, calculator, multipleChoice)
        Root.openForm(Me, test)
    End Function
End Class
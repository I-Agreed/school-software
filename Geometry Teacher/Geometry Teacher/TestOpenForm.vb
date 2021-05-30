Public Class TestOpenForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Sub openTest()
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
        Dim small As Boolean = smallNums.Checked()
        Dim test As New TestForm(D3, D2, hints, calculator, False, small)
        Root.openForm(Me, test)
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        openTest()
    End Sub
End Class
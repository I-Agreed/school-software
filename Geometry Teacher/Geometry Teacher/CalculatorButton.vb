Public Class CalculatorButton
    Property tooltip As String = "Open Calculator"

    Private Sub icon_Click(sender As Object, e As EventArgs) Handles icon.Click
        If Root.calc.Visible Then
            Root.hideCalc()
        Else
            Root.showCalc()
        End If
    End Sub

    Private Sub icon_MouseLeave(sender As Object, e As EventArgs) Handles icon.MouseLeave, icon.MouseEnter
        CalculatorHelp.SetToolTip(icon, tooltip)
    End Sub

    Public Sub correctIcon()
        If Root.calc.Visible Then
            icon.BackgroundImage = Root.imgs.closeCalculatorIcon
            CalculatorHelp.SetToolTip(icon, Nothing)
            tooltip = "Close Calculator"
        Else
            icon.BackgroundImage = Root.imgs.calculatorIcon
            CalculatorHelp.SetToolTip(icon, Nothing)
            tooltip = "Open Calculator"
        End If
    End Sub
End Class

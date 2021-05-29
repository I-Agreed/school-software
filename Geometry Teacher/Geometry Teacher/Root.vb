Public Class Root
    Public Shapes As New ShapeData()
    Public random As Random = New Random()
    Public calc As Calculator = New Calculator()
    Private Sub Root_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openForm(Me, New MainMenu())
    End Sub

    Function openForm(parent As Form, child As Form, Optional bindExit As Boolean = False)
        child.StartPosition = FormStartPosition.Manual
        child.Location = New Point(0, 0)

        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        Me.Controls.Add(child)
        child.Show()
        If parent IsNot Me Then
            parent.Hide()
        End If
        AddHandler child.FormClosed, Sub()
                                         If Not bindExit Then
                                             parent.Show()
                                             child.Hide()
                                         Else
                                             parent.Close()
                                             parent.Hide()
                                             child.Hide()
                                         End If
                                     End Sub
    End Function

    Sub showCalc()
        calc.Show()
        calc.TopMost = True
    End Sub

    Sub hideCalc()
        calc.Hide()
    End Sub
End Class

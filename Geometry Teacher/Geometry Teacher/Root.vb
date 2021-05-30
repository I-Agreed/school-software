Public Class Root
    Public Shapes As New ShapeData()
    Public random As Random = New Random()
    Public calc As Calculator = New Calculator()
    Public calcLocked = False
    Public imgs As ImageStruct = New ImageStruct()

    Private Sub Root_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openForm(Me, New MainMenu())
        calc.TopMost = True
    End Sub

    Function openForm(parent As Form, child As Form, Optional bindExit As Boolean = False)
        child.StartPosition = FormStartPosition.Manual
        child.Location = New Point(0, 0)

        child.TopLevel = False
        child.FormBorderStyle = FormBorderStyle.None
        Me.Controls.Add(child)
        child.Show()
        Me.Text = child.Text
        Me.BackgroundImage = child.BackgroundImage
        If parent IsNot Me Then
            parent.Hide()
            AddHandler child.TextChanged, Sub()
                                              Me.Text = child.Text
                                          End Sub
        End If


        AddHandler child.FormClosed, Sub()
                                         If Not bindExit Then
                                             parent.Show()
                                             Me.Text = parent.Text
                                             Me.BackgroundImage = parent.BackgroundImage
                                             child.Hide()
                                         Else
                                             parent.Close()
                                             parent.Hide()
                                             child.Hide()
                                         End If
                                     End Sub
    End Function

    Sub showCalc()
        If Not calcLocked Then
            calc.Show()
        End If
    End Sub

    Sub hideCalc()
        calc.Hide()
    End Sub

    Sub dont(ByVal sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result = MsgBox("Are you sure you want to exit?", vbYesNo, "Are you sure?")
        If result = vbYes Then
        Else
            e.Cancel = True
        End If
    End Sub
End Class

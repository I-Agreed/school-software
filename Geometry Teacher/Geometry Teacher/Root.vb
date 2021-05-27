Public Class Root
    Public Shapes As New ShapeData()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openForm(Me, New MainMenu())
    End Sub

    Function openForm(parent As Form, child As Form)
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
                                         parent.Show()
                                         child.Hide()
                                     End Sub
    End Function
End Class

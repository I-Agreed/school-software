Public Class TestOpenForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Function openTest()
        Dim test As New TestForm()
        Root.openForm(Me, test)
    End Function
End Class
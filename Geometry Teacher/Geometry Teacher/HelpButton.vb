Public Class HelpButton
    Property helpPage As String = ""
    Property helpForms As Dictionary(Of String, Form) = New Dictionary(Of String, Form)
    Property helpMessage As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not Me.DesignMode Then
            helpForms("D") = New HelpDimension()
            helpForms("P") = New HelpPi()
        End If
    End Sub

    Private Sub HelpButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            BackgroundImage = Root.imgs.helpIcon
        End If
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If helpForms.ContainsKey(helpPage) Then
            Root.openForm(Me.ParentForm, helpForms(helpPage))
        End If
    End Sub
End Class

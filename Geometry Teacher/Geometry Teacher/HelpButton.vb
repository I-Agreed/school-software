Public Class HelpButton
    Property helpPage As String = ""
    Property helpForms As Dictionary(Of String, Form) = New Dictionary(Of String, Form)
    Property helpMessage As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub HelpButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            BackgroundImage = Root.imgs.helpIcon
        End If
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Select Case helpPage
            Case "P"
                Root.openForm(Me.ParentForm, New HelpPi())
            Case "D"
                Root.openForm(Me.ParentForm, New HelpDimension())
        End Select
    End Sub
End Class

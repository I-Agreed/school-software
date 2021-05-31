Public Class MainMenu
    Property planet3 As Integer
    Property planet2 As Integer
    Property rocket As Integer
    Property tick As Double

    Sub openSelection(type As String)
        Dim menu As ShapeSelectionMenu = New ShapeSelectionMenu(type)
        Root.openForm(Me, menu)
    End Sub

    Function openTest()
        Dim test As New TestOpenForm()
        Root.openForm(Me, test)
    End Function

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        planet3 = open3D.Location.Y
        planet2 = open2D.Location.Y
        rocket = openTests.Location.Y
    End Sub

    Private Sub openTests_Click(sender As Object, e As EventArgs) Handles openTests.Click
        openTest()

    End Sub

    Private Sub open3D_Click(sender As Object, e As EventArgs) Handles open3D.Click
        openSelection("3D")

    End Sub

    Private Sub open2D_Click(sender As Object, e As EventArgs) Handles open2D.Click
        openSelection("2D")

    End Sub

    Private Sub frameTimer_Tick(sender As Object, e As EventArgs) Handles frameTimer.Tick
        Dim factor As Integer = 15
        Dim add As Double = 0.01
        open3D.Location = New Point(open3D.Location.X, planet3 + Math.Sin(tick + 1) * factor)
        open2D.Location = New Point(open2D.Location.X, planet2 + Math.Sin(tick - 10) * factor)
        openTests.Location = New Point(openTests.Location.X, rocket + Math.Sin(tick) * factor)
        tick += add
        tick = tick Mod Math.PI * 2
    End Sub
End Class
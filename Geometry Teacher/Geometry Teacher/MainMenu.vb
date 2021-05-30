﻿Public Class MainMenu

    Function openSelection(type As String)
        Dim menu As New ShapeSelectionMenu(type)
        Root.openForm(Me, menu)
    End Function

    Function openTest()
        Dim test As New TestOpenForm()
        Root.openForm(Me, test)
    End Function

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class
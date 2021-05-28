Public Class AnimationBox
    Property FrameRate As Integer = 10
    Property LoopAnimation As Boolean = True
    Property Paused As Boolean = False
    Private Property Images = New List(Of Image)

    Private imageIndex As Integer = 0
    Event animationEnd(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub AnimationBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            FrameTick.Interval = Math.Floor(1000 / FrameRate)
            imageIndex = 0
            setBackground(0)
        End If
    End Sub

    Function setBackground(i As Integer)
        Try
            Me.BackgroundImage = Images(i)
        Catch except As ArgumentOutOfRangeException
            Me.BackgroundImage = Nothing
        End Try
    End Function

    Function loadImages(img As Image())
        Images.Clear()
        For i As Integer = 0 To img.Length - 1
            Images.Add(img(i))
        Next
        imageIndex = 0
    End Function

    Function loadImages(img As ImageList.ImageCollection)
        Images.Clear()
        For i As Integer = 0 To img.Count - 1
            Images.Add(img(i))
        Next
        imageIndex = 0
    End Function

    Function loadImages(img As ImageList)
        loadImages(img.Images)
    End Function

    Private Sub FrameTick_Tick(sender As Object, e As EventArgs) Handles FrameTick.Tick
        If Not Me.DesignMode Then
            imageIndex += 1
            If imageIndex = Images.Count Then
                If LoopAnimation Then
                    imageIndex = 0
                    setBackground(imageIndex)
                End If
                RaiseEvent animationEnd(Me, New EventArgs())
            Else
                setBackground(imageIndex)
            End If
        End If
    End Sub
End Class

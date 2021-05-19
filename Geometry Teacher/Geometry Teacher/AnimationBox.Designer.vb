<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnimationBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FrameTick = New System.Windows.Forms.Timer(Me.components)
        Me.Animation = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'FrameTick
        '
        Me.FrameTick.Enabled = True
        '
        'Animation
        '
        Me.Animation.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.Animation.ImageSize = New System.Drawing.Size(16, 16)
        Me.Animation.TransparentColor = System.Drawing.Color.Transparent
        '
        'AnimationBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Name = "AnimationBox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FrameTick As Timer
    Friend WithEvents Animation As ImageList
End Class

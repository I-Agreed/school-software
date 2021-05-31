<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.ExitButton1 = New Geometry_Teacher.ExitButton()
        Me.open3D = New System.Windows.Forms.PictureBox()
        Me.open2D = New System.Windows.Forms.PictureBox()
        Me.openTests = New System.Windows.Forms.PictureBox()
        Me.mainMenuHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.open3D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.open2D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.openTests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton1
        '
        Me.ExitButton1.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton1.BackgroundImage = CType(resources.GetObject("ExitButton1.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton1.Location = New System.Drawing.Point(12, 388)
        Me.ExitButton1.Margin = New System.Windows.Forms.Padding(41, 19, 41, 19)
        Me.ExitButton1.Name = "ExitButton1"
        Me.ExitButton1.Size = New System.Drawing.Size(50, 50)
        Me.ExitButton1.TabIndex = 6
        '
        'open3D
        '
        Me.open3D.BackColor = System.Drawing.Color.Transparent
        Me.open3D.BackgroundImage = CType(resources.GetObject("open3D.BackgroundImage"), System.Drawing.Image)
        Me.open3D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.open3D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.open3D.Location = New System.Drawing.Point(224, 171)
        Me.open3D.Name = "open3D"
        Me.open3D.Size = New System.Drawing.Size(218, 133)
        Me.open3D.TabIndex = 7
        Me.open3D.TabStop = False
        '
        'open2D
        '
        Me.open2D.BackColor = System.Drawing.Color.Transparent
        Me.open2D.BackgroundImage = CType(resources.GetObject("open2D.BackgroundImage"), System.Drawing.Image)
        Me.open2D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.open2D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.open2D.Location = New System.Drawing.Point(36, 48)
        Me.open2D.Name = "open2D"
        Me.open2D.Size = New System.Drawing.Size(155, 155)
        Me.open2D.TabIndex = 8
        Me.open2D.TabStop = False
        '
        'openTests
        '
        Me.openTests.BackColor = System.Drawing.Color.Transparent
        Me.openTests.BackgroundImage = CType(resources.GetObject("openTests.BackgroundImage"), System.Drawing.Image)
        Me.openTests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.openTests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.openTests.Location = New System.Drawing.Point(477, 269)
        Me.openTests.Name = "openTests"
        Me.openTests.Size = New System.Drawing.Size(125, 125)
        Me.openTests.TabIndex = 9
        Me.openTests.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.openTests)
        Me.Controls.Add(Me.open2D)
        Me.Controls.Add(Me.open3D)
        Me.Controls.Add(Me.ExitButton1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainMenu"
        Me.Text = "Space Geometry!"
        CType(Me.open3D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.open2D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.openTests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ExitButton1 As ExitButton
    Friend WithEvents open3D As PictureBox
    Friend WithEvents open2D As PictureBox
    Friend WithEvents openTests As PictureBox
    Friend WithEvents mainMenuHelp As ToolTip
End Class

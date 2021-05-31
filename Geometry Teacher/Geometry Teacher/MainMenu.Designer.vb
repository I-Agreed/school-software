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
        Me.mainMenuHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.openTests = New System.Windows.Forms.PictureBox()
        Me.open2D = New System.Windows.Forms.PictureBox()
        Me.open3D = New System.Windows.Forms.PictureBox()
        Me.ExitButton1 = New Geometry_Teacher.ExitButton()
        Me.title = New System.Windows.Forms.Label()
        Me.frameTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.openTests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.open2D, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.open3D, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'openTests
        '
        Me.openTests.BackColor = System.Drawing.Color.Transparent
        Me.openTests.BackgroundImage = CType(resources.GetObject("openTests.BackgroundImage"), System.Drawing.Image)
        Me.openTests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.openTests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.openTests.Location = New System.Drawing.Point(716, 404)
        Me.openTests.Margin = New System.Windows.Forms.Padding(4)
        Me.openTests.Name = "openTests"
        Me.openTests.Size = New System.Drawing.Size(188, 188)
        Me.openTests.TabIndex = 9
        Me.openTests.TabStop = False
        '
        'open2D
        '
        Me.open2D.BackColor = System.Drawing.Color.Transparent
        Me.open2D.BackgroundImage = CType(resources.GetObject("open2D.BackgroundImage"), System.Drawing.Image)
        Me.open2D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.open2D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.open2D.Location = New System.Drawing.Point(54, 72)
        Me.open2D.Margin = New System.Windows.Forms.Padding(4)
        Me.open2D.Name = "open2D"
        Me.open2D.Size = New System.Drawing.Size(232, 232)
        Me.open2D.TabIndex = 8
        Me.open2D.TabStop = False
        '
        'open3D
        '
        Me.open3D.BackColor = System.Drawing.Color.Transparent
        Me.open3D.BackgroundImage = CType(resources.GetObject("open3D.BackgroundImage"), System.Drawing.Image)
        Me.open3D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.open3D.Cursor = System.Windows.Forms.Cursors.Hand
        Me.open3D.Location = New System.Drawing.Point(336, 256)
        Me.open3D.Margin = New System.Windows.Forms.Padding(4)
        Me.open3D.Name = "open3D"
        Me.open3D.Size = New System.Drawing.Size(327, 200)
        Me.open3D.TabIndex = 7
        Me.open3D.TabStop = False
        '
        'ExitButton1
        '
        Me.ExitButton1.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton1.BackgroundImage = CType(resources.GetObject("ExitButton1.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton1.Location = New System.Drawing.Point(18, 582)
        Me.ExitButton1.Margin = New System.Windows.Forms.Padding(62, 28, 62, 28)
        Me.ExitButton1.Name = "ExitButton1"
        Me.ExitButton1.Size = New System.Drawing.Size(75, 75)
        Me.ExitButton1.TabIndex = 6
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Magneto", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.title.ForeColor = System.Drawing.Color.DarkGray
        Me.title.Location = New System.Drawing.Point(336, 101)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(723, 86)
        Me.title.TabIndex = 10
        Me.title.Text = "Space Geometry!"
        '
        'frameTimer
        '
        Me.frameTimer.Enabled = True
        Me.frameTimer.Interval = 10
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.openTests)
        Me.Controls.Add(Me.open2D)
        Me.Controls.Add(Me.open3D)
        Me.Controls.Add(Me.ExitButton1)
        Me.DoubleBuffered = True
        Me.Name = "MainMenu"
        Me.Text = "Space Geometry!"
        CType(Me.openTests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.open2D, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.open3D, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenuHelp As ToolTip
    Friend WithEvents openTests As PictureBox
    Friend WithEvents open2D As PictureBox
    Friend WithEvents open3D As PictureBox
    Friend WithEvents ExitButton1 As ExitButton
    Friend WithEvents title As Label
    Friend WithEvents frameTimer As Timer
End Class

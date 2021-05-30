<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpDimension
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpDimension))
        Me.title2D = New System.Windows.Forms.Label()
        Me.title3D = New System.Windows.Forms.Label()
        Me.axis2DPicture = New System.Windows.Forms.PictureBox()
        Me.axis3DPicture = New System.Windows.Forms.PictureBox()
        Me.info2D = New System.Windows.Forms.Label()
        Me.info3D = New System.Windows.Forms.Label()
        Me.BackButton1 = New Geometry_Teacher.BackButton()
        CType(Me.axis2DPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.axis3DPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title2D
        '
        Me.title2D.AutoSize = True
        Me.title2D.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.title2D.Location = New System.Drawing.Point(70, 44)
        Me.title2D.Name = "title2D"
        Me.title2D.Size = New System.Drawing.Size(62, 33)
        Me.title2D.TabIndex = 0
        Me.title2D.Text = "2D:"
        '
        'title3D
        '
        Me.title3D.AutoSize = True
        Me.title3D.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.title3D.Location = New System.Drawing.Point(70, 239)
        Me.title3D.Name = "title3D"
        Me.title3D.Size = New System.Drawing.Size(62, 33)
        Me.title3D.TabIndex = 1
        Me.title3D.Text = "3D:"
        '
        'axis2DPicture
        '
        Me.axis2DPicture.BackgroundImage = CType(resources.GetObject("axis2DPicture.BackgroundImage"), System.Drawing.Image)
        Me.axis2DPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.axis2DPicture.Location = New System.Drawing.Point(97, 80)
        Me.axis2DPicture.Name = "axis2DPicture"
        Me.axis2DPicture.Size = New System.Drawing.Size(100, 100)
        Me.axis2DPicture.TabIndex = 2
        Me.axis2DPicture.TabStop = False
        '
        'axis3DPicture
        '
        Me.axis3DPicture.BackgroundImage = CType(resources.GetObject("axis3DPicture.BackgroundImage"), System.Drawing.Image)
        Me.axis3DPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.axis3DPicture.Location = New System.Drawing.Point(97, 275)
        Me.axis3DPicture.Name = "axis3DPicture"
        Me.axis3DPicture.Size = New System.Drawing.Size(100, 100)
        Me.axis3DPicture.TabIndex = 3
        Me.axis3DPicture.TabStop = False
        '
        'info2D
        '
        Me.info2D.Font = New System.Drawing.Font("Rockwell", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.info2D.Location = New System.Drawing.Point(203, 80)
        Me.info2D.Name = "info2D"
        Me.info2D.Size = New System.Drawing.Size(434, 100)
        Me.info2D.TabIndex = 10
        Me.info2D.Text = "2D is short for two dimentional. 2D shapes are flat, and their size is called the" &
    "ir area, measured in squared units such as cm²."
        '
        'info3D
        '
        Me.info3D.Font = New System.Drawing.Font("Rockwell", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.info3D.Location = New System.Drawing.Point(203, 275)
        Me.info3D.Name = "info3D"
        Me.info3D.Size = New System.Drawing.Size(434, 100)
        Me.info3D.TabIndex = 11
        Me.info3D.Text = resources.GetString("info3D.Text")
        '
        'BackButton1
        '
        Me.BackButton1.BackColor = System.Drawing.Color.Transparent
        Me.BackButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton1.Location = New System.Drawing.Point(9, 391)
        Me.BackButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.BackButton1.Name = "BackButton1"
        Me.BackButton1.Size = New System.Drawing.Size(50, 50)
        Me.BackButton1.TabIndex = 12
        '
        'HelpDimension
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackButton1)
        Me.Controls.Add(Me.info3D)
        Me.Controls.Add(Me.info2D)
        Me.Controls.Add(Me.axis3DPicture)
        Me.Controls.Add(Me.axis2DPicture)
        Me.Controls.Add(Me.title3D)
        Me.Controls.Add(Me.title2D)
        Me.Name = "HelpDimension"
        Me.Text = "2D and 3D help"
        CType(Me.axis2DPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.axis3DPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title2D As Label
    Friend WithEvents title3D As Label
    Friend WithEvents axis2DPicture As PictureBox
    Friend WithEvents axis3DPicture As PictureBox
    Friend WithEvents info2D As Label
    Friend WithEvents info3D As Label
    Friend WithEvents BackButton1 As BackButton
End Class

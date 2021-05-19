<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LearnShapeForm
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
        Me.formulaImage = New System.Windows.Forms.PictureBox()
        Me.formulaTitle = New System.Windows.Forms.Label()
        Me.formulaDisplay = New System.Windows.Forms.Label()
        Me.shapeTitle = New System.Windows.Forms.Label()
        Me.ValidatedTextBox1 = New Geometry_Teacher.ValidatedTextBox()
        Me.AnimationBox1 = New Geometry_Teacher.AnimationBox()
        CType(Me.formulaImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'formulaImage
        '
        Me.formulaImage.Location = New System.Drawing.Point(434, 104)
        Me.formulaImage.Name = "formulaImage"
        Me.formulaImage.Size = New System.Drawing.Size(100, 50)
        Me.formulaImage.TabIndex = 0
        Me.formulaImage.TabStop = False
        '
        'formulaTitle
        '
        Me.formulaTitle.AutoSize = True
        Me.formulaTitle.Location = New System.Drawing.Point(454, 240)
        Me.formulaTitle.Name = "formulaTitle"
        Me.formulaTitle.Size = New System.Drawing.Size(74, 15)
        Me.formulaTitle.TabIndex = 1
        Me.formulaTitle.Text = "formulaTitle:"
        '
        'formulaDisplay
        '
        Me.formulaDisplay.AutoSize = True
        Me.formulaDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.formulaDisplay.Location = New System.Drawing.Point(541, 239)
        Me.formulaDisplay.Name = "formulaDisplay"
        Me.formulaDisplay.Size = New System.Drawing.Size(49, 15)
        Me.formulaDisplay.TabIndex = 2
        Me.formulaDisplay.Text = "formula"
        '
        'shapeTitle
        '
        Me.shapeTitle.AutoSize = True
        Me.shapeTitle.Location = New System.Drawing.Point(283, 59)
        Me.shapeTitle.Name = "shapeTitle"
        Me.shapeTitle.Size = New System.Drawing.Size(64, 15)
        Me.shapeTitle.TabIndex = 3
        Me.shapeTitle.Text = "Shape Title"
        '
        'ValidatedTextBox1
        '
        Me.ValidatedTextBox1.AllowedText = "ehghdh"
        Me.ValidatedTextBox1.Location = New System.Drawing.Point(350, 338)
        Me.ValidatedTextBox1.Name = "ValidatedTextBox1"
        Me.ValidatedTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ValidatedTextBox1.TabIndex = 4
        '
        'AnimationBox1
        '
        Me.AnimationBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.AnimationBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AnimationBox1.FrameRate = 10
        Me.AnimationBox1.Images = Nothing
        Me.AnimationBox1.Location = New System.Drawing.Point(97, 172)
        Me.AnimationBox1.Name = "AnimationBox1"
        Me.AnimationBox1.Size = New System.Drawing.Size(150, 150)
        Me.AnimationBox1.TabIndex = 5
        '
        'LearnShapeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AnimationBox1)
        Me.Controls.Add(Me.ValidatedTextBox1)
        Me.Controls.Add(Me.shapeTitle)
        Me.Controls.Add(Me.formulaDisplay)
        Me.Controls.Add(Me.formulaTitle)
        Me.Controls.Add(Me.formulaImage)
        Me.Name = "LearnShapeForm"
        Me.Text = "LearnShapeForm"
        CType(Me.formulaImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents formulaImage As PictureBox
    Friend WithEvents formulaTitle As Label
    Friend WithEvents formulaDisplay As Label
    Friend WithEvents shapeTitle As Label
    Friend WithEvents ValidatedTextBox1 As ValidatedTextBox
    Friend WithEvents AnimationBox1 As AnimationBox
End Class

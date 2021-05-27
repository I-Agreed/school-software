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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LearnShapeForm))
        Me.formulaImage = New System.Windows.Forms.PictureBox()
        Me.formulaTitle = New System.Windows.Forms.Label()
        Me.formulaDisplay = New System.Windows.Forms.Label()
        Me.shapeTitle = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.inputPanel = New System.Windows.Forms.Panel()
        Me.BackButton1 = New Geometry_Teacher.BackButton()
        CType(Me.formulaImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'formulaImage
        '
        Me.formulaImage.Location = New System.Drawing.Point(620, 173)
        Me.formulaImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.formulaImage.Name = "formulaImage"
        Me.formulaImage.Size = New System.Drawing.Size(143, 83)
        Me.formulaImage.TabIndex = 0
        Me.formulaImage.TabStop = False
        '
        'formulaTitle
        '
        Me.formulaTitle.AutoSize = True
        Me.formulaTitle.Location = New System.Drawing.Point(649, 400)
        Me.formulaTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.formulaTitle.Name = "formulaTitle"
        Me.formulaTitle.Size = New System.Drawing.Size(110, 25)
        Me.formulaTitle.TabIndex = 1
        Me.formulaTitle.Text = "formulaTitle:"
        '
        'formulaDisplay
        '
        Me.formulaDisplay.AutoSize = True
        Me.formulaDisplay.BackColor = System.Drawing.SystemColors.Control
        Me.formulaDisplay.Location = New System.Drawing.Point(810, 400)
        Me.formulaDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.formulaDisplay.Name = "formulaDisplay"
        Me.formulaDisplay.Size = New System.Drawing.Size(74, 25)
        Me.formulaDisplay.TabIndex = 2
        Me.formulaDisplay.Text = "formula"
        '
        'shapeTitle
        '
        Me.shapeTitle.AutoSize = True
        Me.shapeTitle.Location = New System.Drawing.Point(404, 98)
        Me.shapeTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.shapeTitle.Name = "shapeTitle"
        Me.shapeTitle.Size = New System.Drawing.Size(98, 25)
        Me.shapeTitle.TabIndex = 3
        Me.shapeTitle.Text = "Shape Title"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "bird3.jpg")
        Me.ImageList1.Images.SetKeyName(1, "burning ship.png")
        Me.ImageList1.Images.SetKeyName(2, "bepis man.jpg")
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Location = New System.Drawing.Point(773, 633)
        Me.resultLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(22, 25)
        Me.resultLabel.TabIndex = 6
        Me.resultLabel.Text = "0"
        '
        'inputPanel
        '
        Me.inputPanel.Location = New System.Drawing.Point(649, 435)
        Me.inputPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.inputPanel.Name = "inputPanel"
        Me.inputPanel.Size = New System.Drawing.Size(286, 167)
        Me.inputPanel.TabIndex = 7
        '
        'BackButton1
        '
        Me.BackButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton1.Location = New System.Drawing.Point(91, 648)
        Me.BackButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.BackButton1.Name = "BackButton1"
        Me.BackButton1.Size = New System.Drawing.Size(50, 50)
        Me.BackButton1.TabIndex = 8
        '
        'LearnShapeForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1143, 750)
        Me.Controls.Add(Me.BackButton1)
        Me.Controls.Add(Me.inputPanel)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.shapeTitle)
        Me.Controls.Add(Me.formulaDisplay)
        Me.Controls.Add(Me.formulaTitle)
        Me.Controls.Add(Me.formulaImage)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents resultLabel As Label
    Friend WithEvents inputPanel As Panel
    Friend WithEvents BackButton1 As BackButton
End Class

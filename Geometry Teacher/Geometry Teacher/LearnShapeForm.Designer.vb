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
        Me.infoBox = New System.Windows.Forms.Label()
        Me.argLabelBase = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.imagePanel = New System.Windows.Forms.Panel()
        Me.piHelp = New Geometry_Teacher.HelpButton()
        CType(Me.formulaImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.imagePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'formulaImage
        '
        Me.formulaImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.formulaImage.Location = New System.Drawing.Point(38, 38)
        Me.formulaImage.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.formulaImage.Name = "formulaImage"
        Me.formulaImage.Size = New System.Drawing.Size(262, 262)
        Me.formulaImage.TabIndex = 0
        Me.formulaImage.TabStop = False
        '
        'formulaTitle
        '
        Me.formulaTitle.AutoSize = True
        Me.formulaTitle.BackColor = System.Drawing.Color.Transparent
        Me.formulaTitle.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.formulaTitle.Location = New System.Drawing.Point(477, 326)
        Me.formulaTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.formulaTitle.Name = "formulaTitle"
        Me.formulaTitle.Size = New System.Drawing.Size(198, 27)
        Me.formulaTitle.TabIndex = 1
        Me.formulaTitle.Text = "Volume formula:"
        '
        'formulaDisplay
        '
        Me.formulaDisplay.AutoSize = True
        Me.formulaDisplay.BackColor = System.Drawing.Color.Transparent
        Me.formulaDisplay.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.formulaDisplay.Location = New System.Drawing.Point(686, 326)
        Me.formulaDisplay.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.formulaDisplay.Name = "formulaDisplay"
        Me.formulaDisplay.Size = New System.Drawing.Size(98, 27)
        Me.formulaDisplay.TabIndex = 2
        Me.formulaDisplay.Text = "formula"
        '
        'shapeTitle
        '
        Me.shapeTitle.AutoSize = True
        Me.shapeTitle.BackColor = System.Drawing.Color.Transparent
        Me.shapeTitle.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.shapeTitle.Location = New System.Drawing.Point(164, 36)
        Me.shapeTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.shapeTitle.Name = "shapeTitle"
        Me.shapeTitle.Size = New System.Drawing.Size(289, 59)
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
        Me.resultLabel.BackColor = System.Drawing.Color.Transparent
        Me.resultLabel.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.resultLabel.Location = New System.Drawing.Point(477, 536)
        Me.resultLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(143, 27)
        Me.resultLabel.TabIndex = 6
        Me.resultLabel.Text = "area = 0 cm"
        '
        'inputPanel
        '
        Me.inputPanel.BackColor = System.Drawing.Color.Transparent
        Me.inputPanel.Location = New System.Drawing.Point(477, 370)
        Me.inputPanel.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.inputPanel.Name = "inputPanel"
        Me.inputPanel.Size = New System.Drawing.Size(315, 158)
        Me.inputPanel.TabIndex = 7
        '
        'BackButton1
        '
        Me.BackButton1.BackColor = System.Drawing.Color.Transparent
        Me.BackButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton1.Location = New System.Drawing.Point(14, 586)
        Me.BackButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.BackButton1.Name = "BackButton1"
        Me.BackButton1.Size = New System.Drawing.Size(75, 75)
        Me.BackButton1.TabIndex = 8
        '
        'infoBox
        '
        Me.infoBox.BackColor = System.Drawing.Color.Transparent
        Me.infoBox.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.infoBox.Location = New System.Drawing.Point(164, 94)
        Me.infoBox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.infoBox.Name = "infoBox"
        Me.infoBox.Size = New System.Drawing.Size(740, 189)
        Me.infoBox.TabIndex = 9
        Me.infoBox.Text = resources.GetString("infoBox.Text")
        '
        'argLabelBase
        '
        Me.argLabelBase.BackColor = System.Drawing.Color.Transparent
        Me.argLabelBase.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.argLabelBase.Location = New System.Drawing.Point(244, 130)
        Me.argLabelBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.argLabelBase.Name = "argLabelBase"
        Me.argLabelBase.Size = New System.Drawing.Size(56, 34)
        Me.argLabelBase.TabIndex = 10
        Me.argLabelBase.Text = "10"
        Me.argLabelBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 418)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 25)
        Me.Label2.TabIndex = 11
        '
        'imagePanel
        '
        Me.imagePanel.BackColor = System.Drawing.Color.Transparent
        Me.imagePanel.Controls.Add(Me.argLabelBase)
        Me.imagePanel.Controls.Add(Me.formulaImage)
        Me.imagePanel.Location = New System.Drawing.Point(129, 288)
        Me.imagePanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.imagePanel.Name = "imagePanel"
        Me.imagePanel.Size = New System.Drawing.Size(338, 338)
        Me.imagePanel.TabIndex = 12
        '
        'piHelp
        '
        Me.piHelp.BackColor = System.Drawing.Color.Transparent
        Me.piHelp.BackgroundImage = CType(resources.GetObject("piHelp.BackgroundImage"), System.Drawing.Image)
        Me.piHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.piHelp.helpForms = CType(resources.GetObject("piHelp.helpForms"), System.Collections.Generic.Dictionary(Of String, System.Windows.Forms.Form))
        Me.piHelp.helpMessage = "What is Pi?"
        Me.piHelp.helpPage = "P"
        Me.piHelp.Location = New System.Drawing.Point(795, 321)
        Me.piHelp.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.piHelp.Name = "piHelp"
        Me.piHelp.Size = New System.Drawing.Size(38, 38)
        Me.piHelp.TabIndex = 13
        '
        'LearnShapeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.piHelp)
        Me.Controls.Add(Me.imagePanel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.infoBox)
        Me.Controls.Add(Me.BackButton1)
        Me.Controls.Add(Me.inputPanel)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.shapeTitle)
        Me.Controls.Add(Me.formulaDisplay)
        Me.Controls.Add(Me.formulaTitle)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "LearnShapeForm"
        Me.Text = "LearnShapeForm"
        CType(Me.formulaImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.imagePanel.ResumeLayout(False)
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
    Friend WithEvents infoBox As Label
    Friend WithEvents argLabelBase As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents imagePanel As Panel
    Friend WithEvents piHelp As HelpButton
End Class

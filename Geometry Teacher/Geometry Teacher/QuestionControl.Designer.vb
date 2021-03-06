<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuestionControl
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
        Me.shapeDisplay = New System.Windows.Forms.PictureBox()
        Me.answerInput = New Geometry_Teacher.ValidatedTextBox()
        Me.formulaTitle = New System.Windows.Forms.Label()
        Me.formulaDisplay = New System.Windows.Forms.Label()
        Me.markIcon = New System.Windows.Forms.PictureBox()
        Me.correctAnswer = New System.Windows.Forms.Label()
        Me.argValuePanel = New System.Windows.Forms.Panel()
        Me.correctFormula = New System.Windows.Forms.Label()
        Me.picPanel = New System.Windows.Forms.Panel()
        Me.argLabelBase = New System.Windows.Forms.Label()
        CType(Me.shapeDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.markIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.picPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'shapeDisplay
        '
        Me.shapeDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.shapeDisplay.Location = New System.Drawing.Point(38, 38)
        Me.shapeDisplay.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.shapeDisplay.Name = "shapeDisplay"
        Me.shapeDisplay.Size = New System.Drawing.Size(262, 262)
        Me.shapeDisplay.TabIndex = 0
        Me.shapeDisplay.TabStop = False
        '
        'answerInput
        '
        Me.answerInput.AllowedText = "1234567890"
        Me.answerInput.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.answerInput.Location = New System.Drawing.Point(459, 320)
        Me.answerInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.answerInput.MaxLength = 3
        Me.answerInput.Name = "answerInput"
        Me.answerInput.Size = New System.Drawing.Size(148, 34)
        Me.answerInput.TabIndex = 1
        Me.answerInput.whitelist = True
        '
        'formulaTitle
        '
        Me.formulaTitle.AutoSize = True
        Me.formulaTitle.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.formulaTitle.Location = New System.Drawing.Point(459, 286)
        Me.formulaTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.formulaTitle.Name = "formulaTitle"
        Me.formulaTitle.Size = New System.Drawing.Size(147, 27)
        Me.formulaTitle.TabIndex = 2
        Me.formulaTitle.Text = "formulaTitle"
        '
        'formulaDisplay
        '
        Me.formulaDisplay.AutoSize = True
        Me.formulaDisplay.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.formulaDisplay.Location = New System.Drawing.Point(614, 286)
        Me.formulaDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.formulaDisplay.Name = "formulaDisplay"
        Me.formulaDisplay.Size = New System.Drawing.Size(98, 27)
        Me.formulaDisplay.TabIndex = 3
        Me.formulaDisplay.Text = "formula"
        '
        'markIcon
        '
        Me.markIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.markIcon.Location = New System.Drawing.Point(459, 366)
        Me.markIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.markIcon.Name = "markIcon"
        Me.markIcon.Size = New System.Drawing.Size(72, 72)
        Me.markIcon.TabIndex = 13
        Me.markIcon.TabStop = False
        '
        'correctAnswer
        '
        Me.correctAnswer.AutoSize = True
        Me.correctAnswer.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.correctAnswer.ForeColor = System.Drawing.Color.Red
        Me.correctAnswer.Location = New System.Drawing.Point(540, 402)
        Me.correctAnswer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.correctAnswer.Name = "correctAnswer"
        Me.correctAnswer.Size = New System.Drawing.Size(138, 22)
        Me.correctAnswer.TabIndex = 14
        Me.correctAnswer.Text = "correctAnswer"
        '
        'argValuePanel
        '
        Me.argValuePanel.Location = New System.Drawing.Point(459, 152)
        Me.argValuePanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.argValuePanel.Name = "argValuePanel"
        Me.argValuePanel.Size = New System.Drawing.Size(213, 130)
        Me.argValuePanel.TabIndex = 15
        '
        'correctFormula
        '
        Me.correctFormula.AutoSize = True
        Me.correctFormula.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.correctFormula.ForeColor = System.Drawing.Color.Red
        Me.correctFormula.Location = New System.Drawing.Point(540, 380)
        Me.correctFormula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.correctFormula.Name = "correctFormula"
        Me.correctFormula.Size = New System.Drawing.Size(86, 22)
        Me.correctFormula.TabIndex = 16
        Me.correctFormula.Text = "a = b + c"
        '
        'picPanel
        '
        Me.picPanel.Controls.Add(Me.argLabelBase)
        Me.picPanel.Controls.Add(Me.shapeDisplay)
        Me.picPanel.Location = New System.Drawing.Point(46, 86)
        Me.picPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPanel.Name = "picPanel"
        Me.picPanel.Size = New System.Drawing.Size(338, 338)
        Me.picPanel.TabIndex = 17
        '
        'argLabelBase
        '
        Me.argLabelBase.BackColor = System.Drawing.Color.Transparent
        Me.argLabelBase.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.argLabelBase.Location = New System.Drawing.Point(268, 80)
        Me.argLabelBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.argLabelBase.Name = "argLabelBase"
        Me.argLabelBase.Size = New System.Drawing.Size(56, 34)
        Me.argLabelBase.TabIndex = 18
        Me.argLabelBase.Text = "10"
        Me.argLabelBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuestionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.picPanel)
        Me.Controls.Add(Me.correctFormula)
        Me.Controls.Add(Me.argValuePanel)
        Me.Controls.Add(Me.correctAnswer)
        Me.Controls.Add(Me.markIcon)
        Me.Controls.Add(Me.formulaDisplay)
        Me.Controls.Add(Me.formulaTitle)
        Me.Controls.Add(Me.answerInput)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "QuestionControl"
        Me.Size = New System.Drawing.Size(750, 537)
        CType(Me.shapeDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.markIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.picPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents shapeDisplay As PictureBox
    Friend WithEvents answerInput As ValidatedTextBox
    Friend WithEvents formulaTitle As Label
    Friend WithEvents formulaDisplay As Label
    Friend WithEvents markIcon As PictureBox
    Friend WithEvents correctAnswer As Label
    Friend WithEvents argValuePanel As Panel
    Friend WithEvents correctFormula As Label
    Friend WithEvents picPanel As Panel
    Friend WithEvents argLabelBase As Label
End Class

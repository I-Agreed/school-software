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
        Me.shapeDisplay.Location = New System.Drawing.Point(25, 25)
        Me.shapeDisplay.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.shapeDisplay.Name = "shapeDisplay"
        Me.shapeDisplay.Size = New System.Drawing.Size(175, 175)
        Me.shapeDisplay.TabIndex = 0
        Me.shapeDisplay.TabStop = False
        '
        'answerInput
        '
        Me.answerInput.AllowedText = "1234567890"
        Me.answerInput.Location = New System.Drawing.Point(238, 230)
        Me.answerInput.MaxLength = 3
        Me.answerInput.Name = "answerInput"
        Me.answerInput.Size = New System.Drawing.Size(100, 23)
        Me.answerInput.TabIndex = 1
        Me.answerInput.whitelist = True
        '
        'formulaTitle
        '
        Me.formulaTitle.AutoSize = True
        Me.formulaTitle.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.formulaTitle.Location = New System.Drawing.Point(238, 208)
        Me.formulaTitle.Name = "formulaTitle"
        Me.formulaTitle.Size = New System.Drawing.Size(97, 19)
        Me.formulaTitle.TabIndex = 2
        Me.formulaTitle.Text = "formulaTitle"
        '
        'formulaDisplay
        '
        Me.formulaDisplay.AutoSize = True
        Me.formulaDisplay.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.formulaDisplay.Location = New System.Drawing.Point(341, 208)
        Me.formulaDisplay.Name = "formulaDisplay"
        Me.formulaDisplay.Size = New System.Drawing.Size(66, 19)
        Me.formulaDisplay.TabIndex = 3
        Me.formulaDisplay.Text = "formula"
        '
        'markIcon
        '
        Me.markIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.markIcon.Location = New System.Drawing.Point(242, 259)
        Me.markIcon.Name = "markIcon"
        Me.markIcon.Size = New System.Drawing.Size(48, 48)
        Me.markIcon.TabIndex = 13
        Me.markIcon.TabStop = False
        '
        'correctAnswer
        '
        Me.correctAnswer.AutoSize = True
        Me.correctAnswer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.correctAnswer.ForeColor = System.Drawing.Color.Red
        Me.correctAnswer.Location = New System.Drawing.Point(296, 283)
        Me.correctAnswer.Name = "correctAnswer"
        Me.correctAnswer.Size = New System.Drawing.Size(90, 15)
        Me.correctAnswer.TabIndex = 14
        Me.correctAnswer.Text = "correctAnswer"
        '
        'argValuePanel
        '
        Me.argValuePanel.Location = New System.Drawing.Point(238, 74)
        Me.argValuePanel.Name = "argValuePanel"
        Me.argValuePanel.Size = New System.Drawing.Size(142, 87)
        Me.argValuePanel.TabIndex = 15
        '
        'correctFormula
        '
        Me.correctFormula.AutoSize = True
        Me.correctFormula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.correctFormula.ForeColor = System.Drawing.Color.Red
        Me.correctFormula.Location = New System.Drawing.Point(296, 268)
        Me.correctFormula.Name = "correctFormula"
        Me.correctFormula.Size = New System.Drawing.Size(54, 15)
        Me.correctFormula.TabIndex = 16
        Me.correctFormula.Text = "a = b + c"
        '
        'picPanel
        '
        Me.picPanel.Controls.Add(Me.argLabelBase)
        Me.picPanel.Controls.Add(Me.shapeDisplay)
        Me.picPanel.Location = New System.Drawing.Point(7, 49)
        Me.picPanel.Name = "picPanel"
        Me.picPanel.Size = New System.Drawing.Size(225, 225)
        Me.picPanel.TabIndex = 17
        '
        'argLabelBase
        '
        Me.argLabelBase.BackColor = System.Drawing.Color.Transparent
        Me.argLabelBase.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.argLabelBase.Location = New System.Drawing.Point(179, 53)
        Me.argLabelBase.Name = "argLabelBase"
        Me.argLabelBase.Size = New System.Drawing.Size(37, 23)
        Me.argLabelBase.TabIndex = 18
        Me.argLabelBase.Text = "10"
        Me.argLabelBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuestionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
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
        Me.Size = New System.Drawing.Size(586, 358)
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

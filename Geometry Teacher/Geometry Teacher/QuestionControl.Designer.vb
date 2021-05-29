<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.answerInput = New Geometry_Teacher.ValidatedTextBox()
        Me.formulaTitle = New System.Windows.Forms.Label()
        Me.formulaDisplay = New System.Windows.Forms.Label()
        Me.arg1Display = New System.Windows.Forms.Label()
        Me.arg2Display = New System.Windows.Forms.Label()
        Me.arg3Display = New System.Windows.Forms.Label()
        Me.markIcon = New System.Windows.Forms.PictureBox()
        Me.correctAnswer = New System.Windows.Forms.Label()
        Me.argValuePanel = New System.Windows.Forms.Panel()
        Me.correctFormula = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.markIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(36, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'answerInput
        '
        Me.answerInput.AllowedText = "1234567890"
        Me.answerInput.Location = New System.Drawing.Point(206, 223)
        Me.answerInput.MaxLength = 3
        Me.answerInput.Name = "answerInput"
        Me.answerInput.Size = New System.Drawing.Size(100, 23)
        Me.answerInput.TabIndex = 1
        Me.answerInput.whitelist = True
        '
        'formulaTitle
        '
        Me.formulaTitle.AutoSize = True
        Me.formulaTitle.Location = New System.Drawing.Point(171, 49)
        Me.formulaTitle.Name = "formulaTitle"
        Me.formulaTitle.Size = New System.Drawing.Size(71, 15)
        Me.formulaTitle.TabIndex = 2
        Me.formulaTitle.Text = "formulaTitle"
        '
        'formulaDisplay
        '
        Me.formulaDisplay.AutoSize = True
        Me.formulaDisplay.Location = New System.Drawing.Point(315, 49)
        Me.formulaDisplay.Name = "formulaDisplay"
        Me.formulaDisplay.Size = New System.Drawing.Size(49, 15)
        Me.formulaDisplay.TabIndex = 3
        Me.formulaDisplay.Text = "formula"
        '
        'arg1Display
        '
        Me.arg1Display.AutoSize = True
        Me.arg1Display.Location = New System.Drawing.Point(96, 130)
        Me.arg1Display.Name = "arg1Display"
        Me.arg1Display.Size = New System.Drawing.Size(68, 15)
        Me.arg1Display.TabIndex = 10
        Me.arg1Display.Text = "arg1Display"
        '
        'arg2Display
        '
        Me.arg2Display.AutoSize = True
        Me.arg2Display.Location = New System.Drawing.Point(96, 149)
        Me.arg2Display.Name = "arg2Display"
        Me.arg2Display.Size = New System.Drawing.Size(68, 15)
        Me.arg2Display.TabIndex = 11
        Me.arg2Display.Text = "arg2Display"
        '
        'arg3Display
        '
        Me.arg3Display.AutoSize = True
        Me.arg3Display.Location = New System.Drawing.Point(96, 168)
        Me.arg3Display.Name = "arg3Display"
        Me.arg3Display.Size = New System.Drawing.Size(68, 15)
        Me.arg3Display.TabIndex = 12
        Me.arg3Display.Text = "arg3Display"
        '
        'markIcon
        '
        Me.markIcon.Location = New System.Drawing.Point(206, 252)
        Me.markIcon.Name = "markIcon"
        Me.markIcon.Size = New System.Drawing.Size(36, 36)
        Me.markIcon.TabIndex = 13
        Me.markIcon.TabStop = False
        '
        'correctAnswer
        '
        Me.correctAnswer.AutoSize = True
        Me.correctAnswer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.correctAnswer.ForeColor = System.Drawing.Color.Red
        Me.correctAnswer.Location = New System.Drawing.Point(248, 267)
        Me.correctAnswer.Name = "correctAnswer"
        Me.correctAnswer.Size = New System.Drawing.Size(90, 15)
        Me.correctAnswer.TabIndex = 14
        Me.correctAnswer.Text = "correctAnswer"
        '
        'argValuePanel
        '
        Me.argValuePanel.Location = New System.Drawing.Point(206, 130)
        Me.argValuePanel.Name = "argValuePanel"
        Me.argValuePanel.Size = New System.Drawing.Size(142, 87)
        Me.argValuePanel.TabIndex = 15
        '
        'correctFormula
        '
        Me.correctFormula.AutoSize = True
        Me.correctFormula.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.correctFormula.ForeColor = System.Drawing.Color.Red
        Me.correctFormula.Location = New System.Drawing.Point(248, 252)
        Me.correctFormula.Name = "correctFormula"
        Me.correctFormula.Size = New System.Drawing.Size(54, 15)
        Me.correctFormula.TabIndex = 16
        Me.correctFormula.Text = "a = b + c"
        '
        'QuestionControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.correctFormula)
        Me.Controls.Add(Me.argValuePanel)
        Me.Controls.Add(Me.correctAnswer)
        Me.Controls.Add(Me.markIcon)
        Me.Controls.Add(Me.arg3Display)
        Me.Controls.Add(Me.arg2Display)
        Me.Controls.Add(Me.arg1Display)
        Me.Controls.Add(Me.formulaDisplay)
        Me.Controls.Add(Me.formulaTitle)
        Me.Controls.Add(Me.answerInput)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "QuestionControl"
        Me.Size = New System.Drawing.Size(586, 358)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.markIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents answerInput As ValidatedTextBox
    Friend WithEvents formulaTitle As Label
    Friend WithEvents formulaDisplay As Label
    Friend WithEvents arg1Display As Label
    Friend WithEvents arg2Display As Label
    Friend WithEvents arg3Display As Label
    Friend WithEvents markIcon As PictureBox
    Friend WithEvents correctAnswer As Label
    Friend WithEvents argValuePanel As Panel
    Friend WithEvents correctFormula As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestForm))
        Me.nextButton = New System.Windows.Forms.Button()
        Me.questionBox = New System.Windows.Forms.Panel()
        Me.questionCounter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nextButton.Location = New System.Drawing.Point(852, 543)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(206, 56)
        Me.nextButton.TabIndex = 0
        Me.nextButton.Text = "Mark Question"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'questionBox
        '
        Me.questionBox.BackColor = System.Drawing.Color.Transparent
        Me.questionBox.Location = New System.Drawing.Point(65, 62)
        Me.questionBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.questionBox.Name = "questionBox"
        Me.questionBox.Size = New System.Drawing.Size(750, 537)
        Me.questionBox.TabIndex = 1
        '
        'questionCounter
        '
        Me.questionCounter.AutoSize = True
        Me.questionCounter.BackColor = System.Drawing.Color.Transparent
        Me.questionCounter.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.questionCounter.Location = New System.Drawing.Point(823, 62)
        Me.questionCounter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.questionCounter.Name = "questionCounter"
        Me.questionCounter.Size = New System.Drawing.Size(253, 41)
        Me.questionCounter.TabIndex = 2
        Me.questionCounter.Text = "Question 1/10"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.questionCounter)
        Me.Controls.Add(Me.questionBox)
        Me.Controls.Add(Me.nextButton)
        Me.DoubleBuffered = True
        Me.Name = "TestForm"
        Me.Text = "Quiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextButton As Button
    Friend WithEvents questionBox As Panel
    Friend WithEvents questionCounter As Label
End Class

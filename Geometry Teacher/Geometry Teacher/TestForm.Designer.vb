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
        Me.nextButton = New System.Windows.Forms.Button()
        Me.questionBox = New System.Windows.Forms.Panel()
        Me.questionCounter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(477, 401)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(96, 23)
        Me.nextButton.TabIndex = 0
        Me.nextButton.Text = "Next Question"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'questionBox
        '
        Me.questionBox.Location = New System.Drawing.Point(53, 21)
        Me.questionBox.Name = "questionBox"
        Me.questionBox.Size = New System.Drawing.Size(586, 358)
        Me.questionBox.TabIndex = 1
        '
        'questionCounter
        '
        Me.questionCounter.AutoSize = True
        Me.questionCounter.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.questionCounter.Location = New System.Drawing.Point(730, 9)
        Me.questionCounter.Name = "questionCounter"
        Me.questionCounter.Size = New System.Drawing.Size(58, 30)
        Me.questionCounter.TabIndex = 2
        Me.questionCounter.Text = "1/10"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.questionCounter)
        Me.Controls.Add(Me.questionBox)
        Me.Controls.Add(Me.nextButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TestForm"
        Me.Text = "Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nextButton As Button
    Friend WithEvents questionBox As Panel
    Friend WithEvents questionCounter As Label
End Class

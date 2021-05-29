<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestReviewForm
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
        Me.scoreDisplay = New System.Windows.Forms.Label()
        Me.questionsPanel = New System.Windows.Forms.Panel()
        Me.questionDisplayPanel = New System.Windows.Forms.Panel()
        Me.comment = New System.Windows.Forms.Label()
        Me.BackButton1 = New Geometry_Teacher.BackButton()
        Me.SuspendLayout()
        '
        'scoreDisplay
        '
        Me.scoreDisplay.AutoSize = True
        Me.scoreDisplay.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.scoreDisplay.Location = New System.Drawing.Point(102, 9)
        Me.scoreDisplay.Name = "scoreDisplay"
        Me.scoreDisplay.Size = New System.Drawing.Size(58, 30)
        Me.scoreDisplay.TabIndex = 0
        Me.scoreDisplay.Text = "8/10"
        Me.scoreDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'questionsPanel
        '
        Me.questionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.questionsPanel.Location = New System.Drawing.Point(12, 72)
        Me.questionsPanel.Name = "questionsPanel"
        Me.questionsPanel.Size = New System.Drawing.Size(148, 289)
        Me.questionsPanel.TabIndex = 1
        '
        'questionDisplayPanel
        '
        Me.questionDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.questionDisplayPanel.Location = New System.Drawing.Point(185, 72)
        Me.questionDisplayPanel.Name = "questionDisplayPanel"
        Me.questionDisplayPanel.Size = New System.Drawing.Size(586, 358)
        Me.questionDisplayPanel.TabIndex = 2
        '
        'comment
        '
        Me.comment.AutoSize = True
        Me.comment.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.comment.Location = New System.Drawing.Point(185, 9)
        Me.comment.Name = "comment"
        Me.comment.Size = New System.Drawing.Size(155, 30)
        Me.comment.TabIndex = 3
        Me.comment.Text = "comment here"
        '
        'BackButton1
        '
        Me.BackButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton1.Location = New System.Drawing.Point(12, 380)
        Me.BackButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.BackButton1.Name = "BackButton1"
        Me.BackButton1.Size = New System.Drawing.Size(50, 50)
        Me.BackButton1.TabIndex = 4
        '
        'TestReviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackButton1)
        Me.Controls.Add(Me.comment)
        Me.Controls.Add(Me.questionDisplayPanel)
        Me.Controls.Add(Me.questionsPanel)
        Me.Controls.Add(Me.scoreDisplay)
        Me.Name = "TestReviewForm"
        Me.Text = "TestReviewForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoreDisplay As Label
    Friend WithEvents questionsPanel As Panel
    Friend WithEvents questionDisplayPanel As Panel
    Friend WithEvents comment As Label
    Friend WithEvents BackButton1 As BackButton
End Class

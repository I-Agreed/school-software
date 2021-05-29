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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'scoreDisplay
        '
        Me.scoreDisplay.AutoSize = True
        Me.scoreDisplay.Location = New System.Drawing.Point(178, 74)
        Me.scoreDisplay.Name = "scoreDisplay"
        Me.scoreDisplay.Size = New System.Drawing.Size(30, 15)
        Me.scoreDisplay.TabIndex = 0
        Me.scoreDisplay.Text = "8/10"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(50, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 1
        '
        'TestReviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.scoreDisplay)
        Me.Name = "TestReviewForm"
        Me.Text = "TestReviewForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoreDisplay As Label
    Friend WithEvents Panel1 As Panel
End Class

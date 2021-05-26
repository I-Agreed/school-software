<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Root
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
        Me.open3DButton = New System.Windows.Forms.Button()
        Me.open2DButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'open3DButton
        '
        Me.open3DButton.Location = New System.Drawing.Point(330, 210)
        Me.open3DButton.Name = "open3DButton"
        Me.open3DButton.Size = New System.Drawing.Size(75, 23)
        Me.open3DButton.TabIndex = 0
        Me.open3DButton.Text = "3D"
        Me.open3DButton.UseVisualStyleBackColor = True
        '
        'open2DButton
        '
        Me.open2DButton.Location = New System.Drawing.Point(302, 303)
        Me.open2DButton.Name = "open2DButton"
        Me.open2DButton.Size = New System.Drawing.Size(75, 23)
        Me.open2DButton.TabIndex = 1
        Me.open2DButton.Text = "2D"
        Me.open2DButton.UseVisualStyleBackColor = True
        '
        'Root
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.open2DButton)
        Me.Controls.Add(Me.open3DButton)
        Me.Name = "Root"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents open3DButton As Button
    Friend WithEvents open2DButton As Button
End Class

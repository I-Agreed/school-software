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
        Me.open3DButton.Location = New System.Drawing.Point(471, 350)
        Me.open3DButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.open3DButton.Name = "open3DButton"
        Me.open3DButton.Size = New System.Drawing.Size(107, 38)
        Me.open3DButton.TabIndex = 0
        Me.open3DButton.Text = "3D"
        Me.open3DButton.UseVisualStyleBackColor = True
        '
        'open2DButton
        '
        Me.open2DButton.Location = New System.Drawing.Point(431, 505)
        Me.open2DButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.open2DButton.Name = "open2DButton"
        Me.open2DButton.Size = New System.Drawing.Size(107, 38)
        Me.open2DButton.TabIndex = 1
        Me.open2DButton.Text = "2D"
        Me.open2DButton.UseVisualStyleBackColor = True
        '
        'Root
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1143, 750)
        Me.Controls.Add(Me.open2DButton)
        Me.Controls.Add(Me.open3DButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Root"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents open3DButton As Button
    Friend WithEvents open2DButton As Button
End Class

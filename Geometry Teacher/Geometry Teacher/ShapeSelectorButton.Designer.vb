<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShapeSelectorButton
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
        Me.ShapePicture = New System.Windows.Forms.PictureBox()
        Me.ShapeLabel = New System.Windows.Forms.Label()
        CType(Me.ShapePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapePicture
        '
        Me.ShapePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ShapePicture.Location = New System.Drawing.Point(0, 0)
        Me.ShapePicture.Name = "ShapePicture"
        Me.ShapePicture.Size = New System.Drawing.Size(125, 125)
        Me.ShapePicture.TabIndex = 0
        Me.ShapePicture.TabStop = False
        '
        'ShapeLabel
        '
        Me.ShapeLabel.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ShapeLabel.Location = New System.Drawing.Point(0, 128)
        Me.ShapeLabel.Name = "ShapeLabel"
        Me.ShapeLabel.Size = New System.Drawing.Size(125, 47)
        Me.ShapeLabel.TabIndex = 1
        Me.ShapeLabel.Text = "ShapeName"
        Me.ShapeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ShapeSelectorButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ShapeLabel)
        Me.Controls.Add(Me.ShapePicture)
        Me.Name = "ShapeSelectorButton"
        Me.Size = New System.Drawing.Size(125, 175)
        CType(Me.ShapePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShapePicture As PictureBox
    Friend WithEvents ShapeLabel As Label
End Class

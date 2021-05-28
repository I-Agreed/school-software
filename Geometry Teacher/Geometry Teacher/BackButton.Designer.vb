<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackButton
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
        Me.backIcon = New System.Windows.Forms.PictureBox()
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backIcon
        '
        Me.backIcon.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.backIcon.Location = New System.Drawing.Point(0, 0)
        Me.backIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.backIcon.Name = "backIcon"
        Me.backIcon.Size = New System.Drawing.Size(50, 50)
        Me.backIcon.TabIndex = 0
        Me.backIcon.TabStop = False
        '
        'BackButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.backIcon)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "BackButton"
        Me.Size = New System.Drawing.Size(50, 50)
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backIcon As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Root
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.toggleCalc = New Geometry_Teacher.CalculatorButton()
        Me.SuspendLayout()
        '
        'toggleCalc
        '
        Me.toggleCalc.BackColor = System.Drawing.Color.Transparent
        Me.toggleCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggleCalc.Location = New System.Drawing.Point(738, 388)
        Me.toggleCalc.Name = "toggleCalc"
        Me.toggleCalc.Size = New System.Drawing.Size(50, 50)
        Me.toggleCalc.TabIndex = 0
        Me.toggleCalc.tooltip = "Open Calculator"
        '
        'Root
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.toggleCalc)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Root"
        Me.Text = "Geometry Teacher"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toggleCalc As CalculatorButton
End Class

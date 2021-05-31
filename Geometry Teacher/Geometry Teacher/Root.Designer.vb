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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Root))
        Me.toggleCalc = New Geometry_Teacher.CalculatorButton()
        Me.SuspendLayout()
        '
        'toggleCalc
        '
        Me.toggleCalc.BackColor = System.Drawing.Color.Transparent
        Me.toggleCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toggleCalc.Location = New System.Drawing.Point(1107, 582)
        Me.toggleCalc.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.toggleCalc.Name = "toggleCalc"
        Me.toggleCalc.Size = New System.Drawing.Size(75, 75)
        Me.toggleCalc.TabIndex = 0
        Me.toggleCalc.tooltip = "Open Calculator"
        '
        'Root
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.toggleCalc)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.MaximumSize = New System.Drawing.Size(1222, 731)
        Me.MinimumSize = New System.Drawing.Size(1222, 731)
        Me.Name = "Root"
        Me.Text = "Space Geometry!"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents toggleCalc As CalculatorButton
End Class

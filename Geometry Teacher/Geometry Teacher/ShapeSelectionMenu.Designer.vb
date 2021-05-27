<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShapeSelectionMenu
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
        Me.SelectorButtonsPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'SelectorButtonsPanel
        '
        Me.SelectorButtonsPanel.BackColor = System.Drawing.SystemColors.Control
        Me.SelectorButtonsPanel.Location = New System.Drawing.Point(17, 20)
        Me.SelectorButtonsPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelectorButtonsPanel.Name = "SelectorButtonsPanel"
        Me.SelectorButtonsPanel.Size = New System.Drawing.Size(826, 623)
        Me.SelectorButtonsPanel.TabIndex = 0
        '
        'ShapeSelectionMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1143, 750)
        Me.Controls.Add(Me.SelectorButtonsPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ShapeSelectionMenu"
        Me.Text = "ShapeSelectionMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SelectorButtonsPanel As Panel
End Class

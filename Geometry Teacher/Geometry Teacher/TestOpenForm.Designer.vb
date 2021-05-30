<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestOpenForm
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
        Me.select2D = New System.Windows.Forms.RadioButton()
        Me.select3D = New System.Windows.Forms.RadioButton()
        Me.selectBoth = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton1 = New Geometry_Teacher.BackButton()
        Me.selectCalculator = New System.Windows.Forms.CheckBox()
        Me.selectHints = New System.Windows.Forms.CheckBox()
        Me.selectMultipleChoice = New System.Windows.Forms.CheckBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'select2D
        '
        Me.select2D.AutoSize = True
        Me.select2D.Location = New System.Drawing.Point(2, 2)
        Me.select2D.Margin = New System.Windows.Forms.Padding(2)
        Me.select2D.Name = "select2D"
        Me.select2D.Size = New System.Drawing.Size(78, 19)
        Me.select2D.TabIndex = 0
        Me.select2D.TabStop = True
        Me.select2D.Text = "2D shapes"
        Me.select2D.UseVisualStyleBackColor = True
        '
        'select3D
        '
        Me.select3D.AutoSize = True
        Me.select3D.Location = New System.Drawing.Point(90, 2)
        Me.select3D.Margin = New System.Windows.Forms.Padding(2)
        Me.select3D.Name = "select3D"
        Me.select3D.Size = New System.Drawing.Size(78, 19)
        Me.select3D.TabIndex = 1
        Me.select3D.TabStop = True
        Me.select3D.Text = "3D shapes"
        Me.select3D.UseVisualStyleBackColor = True
        '
        'selectBoth
        '
        Me.selectBoth.AutoSize = True
        Me.selectBoth.Location = New System.Drawing.Point(178, 2)
        Me.selectBoth.Margin = New System.Windows.Forms.Padding(2)
        Me.selectBoth.Name = "selectBoth"
        Me.selectBoth.Size = New System.Drawing.Size(78, 19)
        Me.selectBoth.TabIndex = 2
        Me.selectBoth.TabStop = True
        Me.selectBoth.Text = "All shapes"
        Me.selectBoth.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.select3D)
        Me.Panel1.Controls.Add(Me.selectBoth)
        Me.Panel1.Controls.Add(Me.select2D)
        Me.Panel1.Location = New System.Drawing.Point(321, 273)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 19)
        Me.Panel1.TabIndex = 3
        '
        'BackButton1
        '
        Me.BackButton1.BackColor = System.Drawing.Color.Transparent
        Me.BackButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton1.Location = New System.Drawing.Point(9, 391)
        Me.BackButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.BackButton1.Name = "BackButton1"
        Me.BackButton1.Size = New System.Drawing.Size(50, 50)
        Me.BackButton1.TabIndex = 4
        '
        'selectCalculator
        '
        Me.selectCalculator.AutoSize = True
        Me.selectCalculator.Location = New System.Drawing.Point(499, 106)
        Me.selectCalculator.Margin = New System.Windows.Forms.Padding(2)
        Me.selectCalculator.Name = "selectCalculator"
        Me.selectCalculator.Size = New System.Drawing.Size(118, 19)
        Me.selectCalculator.TabIndex = 5
        Me.selectCalculator.Text = "Enable Calculator"
        Me.selectCalculator.UseVisualStyleBackColor = True
        '
        'selectHints
        '
        Me.selectHints.AutoSize = True
        Me.selectHints.Location = New System.Drawing.Point(444, 143)
        Me.selectHints.Margin = New System.Windows.Forms.Padding(2)
        Me.selectHints.Name = "selectHints"
        Me.selectHints.Size = New System.Drawing.Size(86, 19)
        Me.selectHints.TabIndex = 6
        Me.selectHints.Text = "Show Hints"
        Me.selectHints.UseVisualStyleBackColor = True
        '
        'selectMultipleChoice
        '
        Me.selectMultipleChoice.AutoSize = True
        Me.selectMultipleChoice.Location = New System.Drawing.Point(444, 172)
        Me.selectMultipleChoice.Margin = New System.Windows.Forms.Padding(2)
        Me.selectMultipleChoice.Name = "selectMultipleChoice"
        Me.selectMultipleChoice.Size = New System.Drawing.Size(110, 19)
        Me.selectMultipleChoice.TabIndex = 7
        Me.selectMultipleChoice.Text = "Multiple Choice"
        Me.selectMultipleChoice.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(499, 394)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 8
        Me.startButton.Text = "Start!"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'TestOpenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.selectMultipleChoice)
        Me.Controls.Add(Me.selectHints)
        Me.Controls.Add(Me.selectCalculator)
        Me.Controls.Add(Me.BackButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TestOpenForm"
        Me.Text = "Test Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents select2D As RadioButton
    Friend WithEvents select3D As RadioButton
    Friend WithEvents selectBoth As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton1 As BackButton
    Friend WithEvents selectCalculator As CheckBox
    Friend WithEvents selectHints As CheckBox
    Friend WithEvents selectMultipleChoice As CheckBox
    Friend WithEvents startButton As Button
End Class

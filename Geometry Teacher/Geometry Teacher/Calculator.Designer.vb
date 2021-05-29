<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.mainDisplay = New Geometry_Teacher.ValidatedTextBox()
        Me.prevDisplay = New System.Windows.Forms.Label()
        Me.plusButton = New System.Windows.Forms.Button()
        Me.minusButton = New System.Windows.Forms.Button()
        Me.divideButton = New System.Windows.Forms.Button()
        Me.multiplyButton = New System.Windows.Forms.Button()
        Me.equalsButton = New System.Windows.Forms.Button()
        Me.button0 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mainDisplay
        '
        Me.mainDisplay.AllowedText = "1234567890"
        Me.mainDisplay.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mainDisplay.Location = New System.Drawing.Point(12, 22)
        Me.mainDisplay.MaxLength = 14
        Me.mainDisplay.Name = "mainDisplay"
        Me.mainDisplay.Size = New System.Drawing.Size(188, 36)
        Me.mainDisplay.TabIndex = 0
        Me.mainDisplay.whitelist = True
        '
        'prevDisplay
        '
        Me.prevDisplay.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.prevDisplay.Location = New System.Drawing.Point(12, 6)
        Me.prevDisplay.Margin = New System.Windows.Forms.Padding(0)
        Me.prevDisplay.Name = "prevDisplay"
        Me.prevDisplay.Size = New System.Drawing.Size(188, 13)
        Me.prevDisplay.TabIndex = 1
        Me.prevDisplay.Text = "Label1"
        Me.prevDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'plusButton
        '
        Me.plusButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.plusButton.Location = New System.Drawing.Point(186, 64)
        Me.plusButton.Name = "plusButton"
        Me.plusButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.plusButton.Size = New System.Drawing.Size(50, 50)
        Me.plusButton.TabIndex = 2
        Me.plusButton.Text = "+"
        Me.plusButton.UseVisualStyleBackColor = True
        '
        'minusButton
        '
        Me.minusButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.minusButton.Location = New System.Drawing.Point(186, 232)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.minusButton.Size = New System.Drawing.Size(50, 50)
        Me.minusButton.TabIndex = 3
        Me.minusButton.Text = "-"
        Me.minusButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.divideButton.Location = New System.Drawing.Point(186, 120)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.divideButton.Size = New System.Drawing.Size(50, 50)
        Me.divideButton.TabIndex = 4
        Me.divideButton.Text = "÷"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.multiplyButton.Location = New System.Drawing.Point(186, 176)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.multiplyButton.Size = New System.Drawing.Size(50, 50)
        Me.multiplyButton.TabIndex = 5
        Me.multiplyButton.Text = "×"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'equalsButton
        '
        Me.equalsButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.equalsButton.Location = New System.Drawing.Point(186, 289)
        Me.equalsButton.Name = "equalsButton"
        Me.equalsButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.equalsButton.Size = New System.Drawing.Size(50, 50)
        Me.equalsButton.TabIndex = 6
        Me.equalsButton.Text = "="
        Me.equalsButton.UseVisualStyleBackColor = True
        '
        'button0
        '
        Me.button0.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button0.Location = New System.Drawing.Point(12, 64)
        Me.button0.Name = "button0"
        Me.button0.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button0.Size = New System.Drawing.Size(50, 50)
        Me.button0.TabIndex = 7
        Me.button0.Text = "+"
        Me.button0.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button1.Location = New System.Drawing.Point(68, 64)
        Me.button1.Name = "button1"
        Me.button1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button1.Size = New System.Drawing.Size(50, 50)
        Me.button1.TabIndex = 8
        Me.button1.Text = "+"
        Me.button1.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button2.Location = New System.Drawing.Point(124, 64)
        Me.button2.Name = "button2"
        Me.button2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button2.Size = New System.Drawing.Size(50, 50)
        Me.button2.TabIndex = 9
        Me.button2.Text = "+"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button3
        '
        Me.button3.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button3.Location = New System.Drawing.Point(12, 120)
        Me.button3.Name = "button3"
        Me.button3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button3.Size = New System.Drawing.Size(50, 50)
        Me.button3.TabIndex = 10
        Me.button3.Text = "+"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button4
        '
        Me.button4.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button4.Location = New System.Drawing.Point(68, 120)
        Me.button4.Name = "button4"
        Me.button4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button4.Size = New System.Drawing.Size(50, 50)
        Me.button4.TabIndex = 11
        Me.button4.Text = "+"
        Me.button4.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 351)
        Me.Controls.Add(Me.button4)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button0)
        Me.Controls.Add(Me.equalsButton)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.divideButton)
        Me.Controls.Add(Me.minusButton)
        Me.Controls.Add(Me.plusButton)
        Me.Controls.Add(Me.prevDisplay)
        Me.Controls.Add(Me.mainDisplay)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainDisplay As ValidatedTextBox
    Friend WithEvents prevDisplay As Label
    Friend WithEvents plusButton As Button
    Friend WithEvents minusButton As Button
    Friend WithEvents divideButton As Button
    Friend WithEvents multiplyButton As Button
    Friend WithEvents equalsButton As Button
    Friend WithEvents button0 As Button
    Friend WithEvents button1 As Button
    Friend WithEvents button2 As Button
    Friend WithEvents button3 As Button
    Friend WithEvents button4 As Button
End Class

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
        Me.button5 = New System.Windows.Forms.Button()
        Me.button6 = New System.Windows.Forms.Button()
        Me.button7 = New System.Windows.Forms.Button()
        Me.button8 = New System.Windows.Forms.Button()
        Me.button9 = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.delButton = New System.Windows.Forms.Button()
        Me.ACButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'mainDisplay
        '
        Me.mainDisplay.AllowedText = "1234567890"
        Me.mainDisplay.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mainDisplay.Location = New System.Drawing.Point(12, 22)
        Me.mainDisplay.MaxLength = 12
        Me.mainDisplay.Name = "mainDisplay"
        Me.mainDisplay.Size = New System.Drawing.Size(230, 45)
        Me.mainDisplay.TabIndex = 0
        Me.mainDisplay.whitelist = True
        '
        'prevDisplay
        '
        Me.prevDisplay.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.prevDisplay.Location = New System.Drawing.Point(12, 6)
        Me.prevDisplay.Margin = New System.Windows.Forms.Padding(0)
        Me.prevDisplay.Name = "prevDisplay"
        Me.prevDisplay.Size = New System.Drawing.Size(230, 13)
        Me.prevDisplay.TabIndex = 1
        Me.prevDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'plusButton
        '
        Me.plusButton.BackColor = System.Drawing.Color.DarkGray
        Me.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plusButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.plusButton.Location = New System.Drawing.Point(192, 73)
        Me.plusButton.Name = "plusButton"
        Me.plusButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.plusButton.Size = New System.Drawing.Size(50, 50)
        Me.plusButton.TabIndex = 2
        Me.plusButton.Text = "+"
        Me.plusButton.UseVisualStyleBackColor = False
        '
        'minusButton
        '
        Me.minusButton.BackColor = System.Drawing.Color.DarkGray
        Me.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minusButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.minusButton.Location = New System.Drawing.Point(192, 129)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.minusButton.Size = New System.Drawing.Size(50, 50)
        Me.minusButton.TabIndex = 3
        Me.minusButton.Text = "-"
        Me.minusButton.UseVisualStyleBackColor = False
        '
        'divideButton
        '
        Me.divideButton.BackColor = System.Drawing.Color.DarkGray
        Me.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.divideButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.divideButton.Location = New System.Drawing.Point(192, 241)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.divideButton.Size = New System.Drawing.Size(50, 50)
        Me.divideButton.TabIndex = 4
        Me.divideButton.Text = "÷"
        Me.divideButton.UseVisualStyleBackColor = False
        '
        'multiplyButton
        '
        Me.multiplyButton.BackColor = System.Drawing.Color.DarkGray
        Me.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.multiplyButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.multiplyButton.Location = New System.Drawing.Point(192, 185)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.multiplyButton.Size = New System.Drawing.Size(50, 50)
        Me.multiplyButton.TabIndex = 5
        Me.multiplyButton.Text = "×"
        Me.multiplyButton.UseVisualStyleBackColor = False
        '
        'equalsButton
        '
        Me.equalsButton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.equalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.equalsButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.equalsButton.Location = New System.Drawing.Point(192, 297)
        Me.equalsButton.Name = "equalsButton"
        Me.equalsButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.equalsButton.Size = New System.Drawing.Size(50, 50)
        Me.equalsButton.TabIndex = 6
        Me.equalsButton.Text = "="
        Me.equalsButton.UseVisualStyleBackColor = False
        '
        'button0
        '
        Me.button0.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button0.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button0.Location = New System.Drawing.Point(12, 297)
        Me.button0.Name = "button0"
        Me.button0.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button0.Size = New System.Drawing.Size(50, 50)
        Me.button0.TabIndex = 7
        Me.button0.Text = "0"
        Me.button0.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button1.Location = New System.Drawing.Point(12, 129)
        Me.button1.Name = "button1"
        Me.button1.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button1.Size = New System.Drawing.Size(50, 50)
        Me.button1.TabIndex = 8
        Me.button1.Text = "1"
        Me.button1.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button2.Location = New System.Drawing.Point(68, 129)
        Me.button2.Name = "button2"
        Me.button2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button2.Size = New System.Drawing.Size(50, 50)
        Me.button2.TabIndex = 9
        Me.button2.Text = "2"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button3.Location = New System.Drawing.Point(124, 129)
        Me.button3.Name = "button3"
        Me.button3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button3.Size = New System.Drawing.Size(50, 50)
        Me.button3.TabIndex = 10
        Me.button3.Text = "3"
        Me.button3.UseVisualStyleBackColor = False
        '
        'button4
        '
        Me.button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button4.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button4.Location = New System.Drawing.Point(12, 184)
        Me.button4.Name = "button4"
        Me.button4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button4.Size = New System.Drawing.Size(50, 50)
        Me.button4.TabIndex = 11
        Me.button4.Text = "4"
        Me.button4.UseVisualStyleBackColor = False
        '
        'button5
        '
        Me.button5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button5.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button5.Location = New System.Drawing.Point(68, 185)
        Me.button5.Name = "button5"
        Me.button5.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button5.Size = New System.Drawing.Size(50, 50)
        Me.button5.TabIndex = 12
        Me.button5.Text = "5"
        Me.button5.UseVisualStyleBackColor = False
        '
        'button6
        '
        Me.button6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button6.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button6.Location = New System.Drawing.Point(124, 185)
        Me.button6.Name = "button6"
        Me.button6.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button6.Size = New System.Drawing.Size(50, 50)
        Me.button6.TabIndex = 13
        Me.button6.Text = "6"
        Me.button6.UseVisualStyleBackColor = False
        '
        'button7
        '
        Me.button7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button7.Location = New System.Drawing.Point(12, 241)
        Me.button7.Name = "button7"
        Me.button7.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button7.Size = New System.Drawing.Size(50, 50)
        Me.button7.TabIndex = 14
        Me.button7.Text = "7"
        Me.button7.UseVisualStyleBackColor = False
        '
        'button8
        '
        Me.button8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button8.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button8.Location = New System.Drawing.Point(68, 241)
        Me.button8.Name = "button8"
        Me.button8.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button8.Size = New System.Drawing.Size(50, 50)
        Me.button8.TabIndex = 15
        Me.button8.Text = "8"
        Me.button8.UseVisualStyleBackColor = False
        '
        'button9
        '
        Me.button9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button9.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.button9.Location = New System.Drawing.Point(124, 241)
        Me.button9.Name = "button9"
        Me.button9.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.button9.Size = New System.Drawing.Size(50, 50)
        Me.button9.TabIndex = 16
        Me.button9.Text = "9"
        Me.button9.UseVisualStyleBackColor = False
        '
        'clearButton
        '
        Me.clearButton.BackColor = System.Drawing.Color.DarkOrange
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.clearButton.Location = New System.Drawing.Point(124, 73)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.clearButton.Size = New System.Drawing.Size(50, 50)
        Me.clearButton.TabIndex = 17
        Me.clearButton.Text = "C"
        Me.clearButton.UseVisualStyleBackColor = False
        '
        'delButton
        '
        Me.delButton.BackColor = System.Drawing.Color.DarkOrange
        Me.delButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.delButton.Location = New System.Drawing.Point(68, 297)
        Me.delButton.Name = "delButton"
        Me.delButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.delButton.Size = New System.Drawing.Size(106, 50)
        Me.delButton.TabIndex = 18
        Me.delButton.Text = "DEL"
        Me.delButton.UseVisualStyleBackColor = False
        '
        'ACButton
        '
        Me.ACButton.BackColor = System.Drawing.Color.DarkOrange
        Me.ACButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ACButton.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ACButton.Location = New System.Drawing.Point(12, 73)
        Me.ACButton.Name = "ACButton"
        Me.ACButton.Padding = New System.Windows.Forms.Padding(3, 0, 0, 2)
        Me.ACButton.Size = New System.Drawing.Size(106, 50)
        Me.ACButton.TabIndex = 19
        Me.ACButton.Text = "AC"
        Me.ACButton.UseVisualStyleBackColor = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(254, 358)
        Me.Controls.Add(Me.ACButton)
        Me.Controls.Add(Me.delButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.button9)
        Me.Controls.Add(Me.button8)
        Me.Controls.Add(Me.button7)
        Me.Controls.Add(Me.button6)
        Me.Controls.Add(Me.button5)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents button5 As Button
    Friend WithEvents button6 As Button
    Friend WithEvents button7 As Button
    Friend WithEvents button8 As Button
    Friend WithEvents button9 As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents delButton As Button
    Friend WithEvents ACButton As Button
End Class

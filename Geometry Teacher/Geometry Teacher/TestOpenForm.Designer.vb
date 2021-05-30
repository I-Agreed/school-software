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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestOpenForm))
        Me.select2D = New System.Windows.Forms.RadioButton()
        Me.select3D = New System.Windows.Forms.RadioButton()
        Me.selectBoth = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton1 = New Geometry_Teacher.BackButton()
        Me.selectCalculator = New System.Windows.Forms.CheckBox()
        Me.selectHints = New System.Windows.Forms.CheckBox()
        Me.startButton = New System.Windows.Forms.Button()
        Me.testHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.smallNums = New System.Windows.Forms.CheckBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.mainTitle = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'select2D
        '
        Me.select2D.AutoSize = True
        Me.select2D.BackColor = System.Drawing.Color.Transparent
        Me.select2D.Checked = True
        Me.select2D.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.select2D.Location = New System.Drawing.Point(2, 0)
        Me.select2D.Margin = New System.Windows.Forms.Padding(2)
        Me.select2D.Name = "select2D"
        Me.select2D.Size = New System.Drawing.Size(119, 25)
        Me.select2D.TabIndex = 0
        Me.select2D.TabStop = True
        Me.select2D.Text = "2D shapes"
        Me.testHelp.SetToolTip(Me.select2D, "Include only 2D shapes")
        Me.select2D.UseVisualStyleBackColor = False
        '
        'select3D
        '
        Me.select3D.AutoSize = True
        Me.select3D.BackColor = System.Drawing.Color.Transparent
        Me.select3D.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.select3D.Location = New System.Drawing.Point(125, 0)
        Me.select3D.Margin = New System.Windows.Forms.Padding(2)
        Me.select3D.Name = "select3D"
        Me.select3D.Size = New System.Drawing.Size(119, 25)
        Me.select3D.TabIndex = 1
        Me.select3D.TabStop = True
        Me.select3D.Text = "3D shapes"
        Me.testHelp.SetToolTip(Me.select3D, "Include only 3D shapes")
        Me.select3D.UseVisualStyleBackColor = False
        '
        'selectBoth
        '
        Me.selectBoth.AutoSize = True
        Me.selectBoth.BackColor = System.Drawing.Color.Transparent
        Me.selectBoth.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.selectBoth.Location = New System.Drawing.Point(248, 0)
        Me.selectBoth.Margin = New System.Windows.Forms.Padding(2)
        Me.selectBoth.Name = "selectBoth"
        Me.selectBoth.Size = New System.Drawing.Size(120, 25)
        Me.selectBoth.TabIndex = 2
        Me.selectBoth.TabStop = True
        Me.selectBoth.Text = "All shapes"
        Me.testHelp.SetToolTip(Me.selectBoth, "Include all shapes")
        Me.selectBoth.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.select3D)
        Me.Panel1.Controls.Add(Me.selectBoth)
        Me.Panel1.Controls.Add(Me.select2D)
        Me.Panel1.Location = New System.Drawing.Point(266, 314)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 42)
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
        Me.selectCalculator.BackColor = System.Drawing.Color.Transparent
        Me.selectCalculator.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.selectCalculator.Location = New System.Drawing.Point(424, 261)
        Me.selectCalculator.Margin = New System.Windows.Forms.Padding(2)
        Me.selectCalculator.Name = "selectCalculator"
        Me.selectCalculator.Size = New System.Drawing.Size(184, 25)
        Me.selectCalculator.TabIndex = 5
        Me.selectCalculator.Text = "Enable calculator"
        Me.testHelp.SetToolTip(Me.selectCalculator, "Allow for the calculator to be used")
        Me.selectCalculator.UseVisualStyleBackColor = False
        '
        'selectHints
        '
        Me.selectHints.AutoSize = True
        Me.selectHints.BackColor = System.Drawing.Color.Transparent
        Me.selectHints.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.selectHints.Location = New System.Drawing.Point(267, 261)
        Me.selectHints.Margin = New System.Windows.Forms.Padding(2)
        Me.selectHints.Name = "selectHints"
        Me.selectHints.Size = New System.Drawing.Size(149, 25)
        Me.selectHints.TabIndex = 6
        Me.selectHints.Text = "Show formula"
        Me.testHelp.SetToolTip(Me.selectHints, "Show the formula for area or volume")
        Me.selectHints.UseVisualStyleBackColor = False
        '
        'startButton
        '
        Me.startButton.BackColor = System.Drawing.Color.LightGray
        Me.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.startButton.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startButton.Location = New System.Drawing.Point(589, 367)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(98, 44)
        Me.startButton.TabIndex = 8
        Me.startButton.Text = "Start!"
        Me.startButton.UseVisualStyleBackColor = False
        '
        'smallNums
        '
        Me.smallNums.AutoSize = True
        Me.smallNums.BackColor = System.Drawing.Color.Transparent
        Me.smallNums.Checked = True
        Me.smallNums.CheckState = System.Windows.Forms.CheckState.Checked
        Me.smallNums.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.smallNums.Location = New System.Drawing.Point(267, 287)
        Me.smallNums.Margin = New System.Windows.Forms.Padding(2)
        Me.smallNums.Name = "smallNums"
        Me.smallNums.Size = New System.Drawing.Size(216, 25)
        Me.smallNums.TabIndex = 12
        Me.smallNums.Text = "Use smaller numbers"
        Me.testHelp.SetToolTip(Me.smallNums, "Make all numbers in the quiz smaller than 10")
        Me.smallNums.UseVisualStyleBackColor = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(84, 254)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(183, 31)
        Me.Title.TabIndex = 9
        Me.Title.Text = "Quiz Options:"
        '
        'mainTitle
        '
        Me.mainTitle.AutoSize = True
        Me.mainTitle.BackColor = System.Drawing.Color.Transparent
        Me.mainTitle.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mainTitle.Location = New System.Drawing.Point(84, 56)
        Me.mainTitle.Name = "mainTitle"
        Me.mainTitle.Size = New System.Drawing.Size(137, 36)
        Me.mainTitle.TabIndex = 10
        Me.mainTitle.Text = "Quizzes:"
        '
        'info
        '
        Me.info.BackColor = System.Drawing.Color.Transparent
        Me.info.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.info.Location = New System.Drawing.Point(227, 68)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(495, 149)
        Me.info.TabIndex = 11
        Me.info.Text = resources.GetString("info.Text")
        '
        'TestOpenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.smallNums)
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.mainTitle)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.selectHints)
        Me.Controls.Add(Me.selectCalculator)
        Me.Controls.Add(Me.BackButton1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TestOpenForm"
        Me.Text = "Quiz options"
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
    Friend WithEvents startButton As Button
    Friend WithEvents testHelp As ToolTip
    Friend WithEvents Title As Label
    Friend WithEvents mainTitle As Label
    Friend WithEvents info As Label
    Friend WithEvents smallNums As CheckBox
End Class

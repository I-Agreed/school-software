<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpPi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpPi))
        Me.circleDiagram = New System.Windows.Forms.PictureBox()
        Me.circleDiagramLabels = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.piImage = New System.Windows.Forms.PictureBox()
        Me.infoBox = New System.Windows.Forms.Label()
        Me.BackButton1 = New Geometry_Teacher.BackButton()
        Me.infobox2infobox2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.circleDiagram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circleDiagramLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.piImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'circleDiagram
        '
        Me.circleDiagram.BackColor = System.Drawing.Color.Transparent
        Me.circleDiagram.BackgroundImage = CType(resources.GetObject("circleDiagram.BackgroundImage"), System.Drawing.Image)
        Me.circleDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.circleDiagram.Location = New System.Drawing.Point(47, 158)
        Me.circleDiagram.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.circleDiagram.Name = "circleDiagram"
        Me.circleDiagram.Size = New System.Drawing.Size(100, 100)
        Me.circleDiagram.TabIndex = 0
        Me.circleDiagram.TabStop = False
        '
        'circleDiagramLabels
        '
        Me.circleDiagramLabels.BackColor = System.Drawing.Color.Transparent
        Me.circleDiagramLabels.BackgroundImage = CType(resources.GetObject("circleDiagramLabels.BackgroundImage"), System.Drawing.Image)
        Me.circleDiagramLabels.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.circleDiagramLabels.Location = New System.Drawing.Point(147, 174)
        Me.circleDiagramLabels.Margin = New System.Windows.Forms.Padding(0)
        Me.circleDiagramLabels.Name = "circleDiagramLabels"
        Me.circleDiagramLabels.Size = New System.Drawing.Size(150, 75)
        Me.circleDiagramLabels.TabIndex = 1
        Me.circleDiagramLabels.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(94, 52)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(53, 33)
        Me.Title.TabIndex = 2
        Me.Title.Text = "Pi:"
        '
        'piImage
        '
        Me.piImage.BackColor = System.Drawing.Color.Transparent
        Me.piImage.BackgroundImage = CType(resources.GetObject("piImage.BackgroundImage"), System.Drawing.Image)
        Me.piImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.piImage.Location = New System.Drawing.Point(460, 233)
        Me.piImage.Name = "piImage"
        Me.piImage.Size = New System.Drawing.Size(293, 141)
        Me.piImage.TabIndex = 3
        Me.piImage.TabStop = False
        '
        'infoBox
        '
        Me.infoBox.BackColor = System.Drawing.Color.Transparent
        Me.infoBox.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.infoBox.Location = New System.Drawing.Point(94, 85)
        Me.infoBox.Name = "infoBox"
        Me.infoBox.Size = New System.Drawing.Size(615, 73)
        Me.infoBox.TabIndex = 10
        Me.infoBox.Text = resources.GetString("infoBox.Text")
        '
        'BackButton1
        '
        Me.BackButton1.BackColor = System.Drawing.Color.Transparent
        Me.BackButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton1.Location = New System.Drawing.Point(9, 391)
        Me.BackButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.BackButton1.Name = "BackButton1"
        Me.BackButton1.Size = New System.Drawing.Size(50, 50)
        Me.BackButton1.TabIndex = 11
        '
        'infobox2infobox2
        '
        Me.infobox2infobox2.BackColor = System.Drawing.Color.Transparent
        Me.infobox2infobox2.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.infobox2infobox2.Location = New System.Drawing.Point(300, 158)
        Me.infobox2infobox2.Name = "infobox2infobox2"
        Me.infobox2infobox2.Size = New System.Drawing.Size(453, 100)
        Me.infobox2infobox2.TabIndex = 12
        Me.infobox2infobox2.Text = resources.GetString("infobox2infobox2.Text")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(47, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 113)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'HelpPi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.infobox2infobox2)
        Me.Controls.Add(Me.BackButton1)
        Me.Controls.Add(Me.infoBox)
        Me.Controls.Add(Me.piImage)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.circleDiagramLabels)
        Me.Controls.Add(Me.circleDiagram)
        Me.DoubleBuffered = True
        Me.Name = "HelpPi"
        Me.Text = "What is Pi?"
        CType(Me.circleDiagram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circleDiagramLabels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.piImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents circleDiagram As PictureBox
    Friend WithEvents circleDiagramLabels As PictureBox
    Friend WithEvents Title As Label
    Friend WithEvents piImage As PictureBox
    Friend WithEvents infoBox As Label
    Friend WithEvents BackButton1 As BackButton
    Friend WithEvents infobox2infobox2 As Label
    Friend WithEvents Label1 As Label
End Class

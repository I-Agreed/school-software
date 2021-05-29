<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorButton
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculatorButton))
        Me.icon = New System.Windows.Forms.PictureBox()
        Me.Images = New System.Windows.Forms.ImageList(Me.components)
        Me.CalculatorHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'icon
        '
        Me.icon.BackgroundImage = CType(resources.GetObject("icon.BackgroundImage"), System.Drawing.Image)
        Me.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.icon.Location = New System.Drawing.Point(0, 0)
        Me.icon.Name = "icon"
        Me.icon.Size = New System.Drawing.Size(50, 50)
        Me.icon.TabIndex = 0
        Me.icon.TabStop = False
        Me.CalculatorHelp.SetToolTip(Me.icon, "Open Calculator")
        '
        'Images
        '
        Me.Images.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.Images.ImageStream = CType(resources.GetObject("Images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Images.TransparentColor = System.Drawing.Color.Transparent
        Me.Images.Images.SetKeyName(0, "calculator.png")
        Me.Images.Images.SetKeyName(1, "close calculator.png")
        '
        'CalculatorButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.icon)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "CalculatorButton"
        Me.Size = New System.Drawing.Size(50, 50)
        CType(Me.icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents icon As PictureBox
    Friend WithEvents Images As ImageList
    Friend WithEvents CalculatorHelp As ToolTip
End Class

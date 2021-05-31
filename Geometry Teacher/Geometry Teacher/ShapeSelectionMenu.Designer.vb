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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShapeSelectionMenu))
        Me.SelectorButtonsPanel = New System.Windows.Forms.Panel()
        Me.BackButton1 = New Geometry_Teacher.BackButton()
        Me.HelpButton1 = New Geometry_Teacher.HelpButton()
        Me.title = New System.Windows.Forms.Label()
        Me.selectShapeHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'SelectorButtonsPanel
        '
        Me.SelectorButtonsPanel.BackColor = System.Drawing.Color.Transparent
        Me.SelectorButtonsPanel.Location = New System.Drawing.Point(116, 124)
        Me.SelectorButtonsPanel.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.SelectorButtonsPanel.Name = "SelectorButtonsPanel"
        Me.SelectorButtonsPanel.Size = New System.Drawing.Size(957, 501)
        Me.SelectorButtonsPanel.TabIndex = 0
        '
        'BackButton1
        '
        Me.BackButton1.BackColor = System.Drawing.Color.Transparent
        Me.BackButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackButton1.Location = New System.Drawing.Point(14, 586)
        Me.BackButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.BackButton1.Name = "BackButton1"
        Me.BackButton1.Size = New System.Drawing.Size(75, 75)
        Me.BackButton1.TabIndex = 1
        '
        'HelpButton1
        '
        Me.HelpButton1.BackColor = System.Drawing.Color.Transparent
        Me.HelpButton1.BackgroundImage = CType(resources.GetObject("HelpButton1.BackgroundImage"), System.Drawing.Image)
        Me.HelpButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HelpButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HelpButton1.helpForms = CType(resources.GetObject("HelpButton1.helpForms"), System.Collections.Generic.Dictionary(Of String, System.Windows.Forms.Form))
        Me.HelpButton1.helpMessage = "What are 2D and 3D shape?"
        Me.HelpButton1.helpPage = "D"
        Me.HelpButton1.Location = New System.Drawing.Point(366, 74)
        Me.HelpButton1.Margin = New System.Windows.Forms.Padding(0, 4, 4, 4)
        Me.HelpButton1.Name = "HelpButton1"
        Me.HelpButton1.Size = New System.Drawing.Size(38, 38)
        Me.HelpButton1.TabIndex = 2
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.BackColor = System.Drawing.Color.Transparent
        Me.title.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.title.Location = New System.Drawing.Point(135, 68)
        Me.title.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(231, 50)
        Me.title.TabIndex = 3
        Me.title.Text = "2D Shapes"
        '
        'ShapeSelectionMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 675)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.HelpButton1)
        Me.Controls.Add(Me.BackButton1)
        Me.Controls.Add(Me.SelectorButtonsPanel)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "ShapeSelectionMenu"
        Me.Text = "ShapeSelectionMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelectorButtonsPanel As Panel
    Friend WithEvents BackButton1 As BackButton
    Friend WithEvents HelpButton1 As HelpButton
    Friend WithEvents title As Label
    Friend WithEvents selectShapeHelp As ToolTip
End Class

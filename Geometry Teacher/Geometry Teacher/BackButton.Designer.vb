<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackButton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackButton))
        Me.backIcon = New System.Windows.Forms.PictureBox()
        Me.backButtonHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backIcon
        '
        Me.backIcon.BackColor = System.Drawing.Color.Transparent
        Me.backIcon.BackgroundImage = CType(resources.GetObject("backIcon.BackgroundImage"), System.Drawing.Image)
        Me.backIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.backIcon.Location = New System.Drawing.Point(0, 0)
        Me.backIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.backIcon.Name = "backIcon"
        Me.backIcon.Size = New System.Drawing.Size(50, 50)
        Me.backIcon.TabIndex = 0
        Me.backIcon.TabStop = False
        Me.backButtonHelp.SetToolTip(Me.backIcon, "Go Back")
        '
        'BackButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.backIcon)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "BackButton"
        Me.Size = New System.Drawing.Size(50, 50)
        CType(Me.backIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents backIcon As PictureBox
    Friend WithEvents backButtonHelp As ToolTip
End Class

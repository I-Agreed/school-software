<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestReviewItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestReviewItem))
        Me.Title = New System.Windows.Forms.Label()
        Me.correctIcon = New System.Windows.Forms.PictureBox()
        Me.icons = New System.Windows.Forms.ImageList(Me.components)
        Me.reviewItemHelp = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.correctIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Title.Location = New System.Drawing.Point(0, -1)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(115, 30)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Question 10:"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reviewItemHelp.SetToolTip(Me.Title, "Click to show question")
        '
        'correctIcon
        '
        Me.correctIcon.BackColor = System.Drawing.Color.Transparent
        Me.correctIcon.BackgroundImage = CType(resources.GetObject("correctIcon.BackgroundImage"), System.Drawing.Image)
        Me.correctIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.correctIcon.Location = New System.Drawing.Point(120, 1)
        Me.correctIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.correctIcon.Name = "correctIcon"
        Me.correctIcon.Size = New System.Drawing.Size(27, 27)
        Me.correctIcon.TabIndex = 1
        Me.correctIcon.TabStop = False
        Me.reviewItemHelp.SetToolTip(Me.correctIcon, "Click to show question")
        '
        'icons
        '
        Me.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.icons.ImageStream = CType(resources.GetObject("icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.icons.TransparentColor = System.Drawing.Color.Transparent
        Me.icons.Images.SetKeyName(0, "check.png")
        Me.icons.Images.SetKeyName(1, "cross.png")
        '
        'TestReviewItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.correctIcon)
        Me.Controls.Add(Me.Title)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "TestReviewItem"
        Me.Size = New System.Drawing.Size(154, 30)
        Me.reviewItemHelp.SetToolTip(Me, "Click to show question")
        CType(Me.correctIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents correctIcon As PictureBox
    Friend WithEvents icons As ImageList
    Friend WithEvents reviewItemHelp As ToolTip
End Class

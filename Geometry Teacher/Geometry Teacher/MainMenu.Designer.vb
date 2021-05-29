<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.testButton = New System.Windows.Forms.Button()
        Me.open2DButton = New System.Windows.Forms.Button()
        Me.open3DButton = New System.Windows.Forms.Button()
        Me.ExitButton1 = New Geometry_Teacher.ExitButton()
        Me.SuspendLayout()
        '
        'testButton
        '
        Me.testButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.testButton.Location = New System.Drawing.Point(458, 102)
        Me.testButton.Margin = New System.Windows.Forms.Padding(2)
        Me.testButton.Name = "testButton"
        Me.testButton.Size = New System.Drawing.Size(78, 20)
        Me.testButton.TabIndex = 5
        Me.testButton.Text = "tests"
        Me.testButton.UseVisualStyleBackColor = True
        '
        'open2DButton
        '
        Me.open2DButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.open2DButton.Location = New System.Drawing.Point(263, 326)
        Me.open2DButton.Name = "open2DButton"
        Me.open2DButton.Size = New System.Drawing.Size(75, 23)
        Me.open2DButton.TabIndex = 4
        Me.open2DButton.Text = "2D"
        Me.open2DButton.UseVisualStyleBackColor = True
        '
        'open3DButton
        '
        Me.open3DButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.open3DButton.Location = New System.Drawing.Point(291, 233)
        Me.open3DButton.Name = "open3DButton"
        Me.open3DButton.Size = New System.Drawing.Size(75, 23)
        Me.open3DButton.TabIndex = 3
        Me.open3DButton.Text = "3D"
        Me.open3DButton.UseVisualStyleBackColor = True
        '
        'ExitButton1
        '
        Me.ExitButton1.BackColor = System.Drawing.Color.Transparent
        Me.ExitButton1.BackgroundImage = CType(resources.GetObject("ExitButton1.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ExitButton1.Location = New System.Drawing.Point(12, 388)
        Me.ExitButton1.Name = "ExitButton1"
        Me.ExitButton1.Size = New System.Drawing.Size(50, 50)
        Me.ExitButton1.TabIndex = 6
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton1)
        Me.Controls.Add(Me.testButton)
        Me.Controls.Add(Me.open2DButton)
        Me.Controls.Add(Me.open3DButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents testButton As Button
    Friend WithEvents open2DButton As Button
    Friend WithEvents open3DButton As Button
    Friend WithEvents ExitButton1 As ExitButton
End Class

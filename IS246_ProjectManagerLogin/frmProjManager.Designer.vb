<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProjManager))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnProject1 = New System.Windows.Forms.Button()
        Me.btnProject2 = New System.Windows.Forms.Button()
        Me.btnProject3 = New System.Windows.Forms.Button()
        Me.btnProject4 = New System.Windows.Forms.Button()
        Me.btnProject5 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnProjectG = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Blue
        Me.lblTitle.Location = New System.Drawing.Point(108, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(618, 63)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "IS246- Project Manager"
        '
        'btnProject1
        '
        Me.btnProject1.Location = New System.Drawing.Point(194, 78)
        Me.btnProject1.Name = "btnProject1"
        Me.btnProject1.Size = New System.Drawing.Size(397, 23)
        Me.btnProject1.TabIndex = 4
        Me.btnProject1.Text = "Project 1 -Factorial Calculator"
        Me.btnProject1.UseVisualStyleBackColor = True
        '
        'btnProject2
        '
        Me.btnProject2.Location = New System.Drawing.Point(194, 107)
        Me.btnProject2.Name = "btnProject2"
        Me.btnProject2.Size = New System.Drawing.Size(397, 23)
        Me.btnProject2.TabIndex = 5
        Me.btnProject2.Text = "Project 2 - Conversions"
        Me.btnProject2.UseVisualStyleBackColor = True
        '
        'btnProject3
        '
        Me.btnProject3.Location = New System.Drawing.Point(194, 136)
        Me.btnProject3.Name = "btnProject3"
        Me.btnProject3.Size = New System.Drawing.Size(397, 23)
        Me.btnProject3.TabIndex = 6
        Me.btnProject3.Text = "Project 3 - Simple Calculator"
        Me.btnProject3.UseVisualStyleBackColor = True
        '
        'btnProject4
        '
        Me.btnProject4.Enabled = False
        Me.btnProject4.Location = New System.Drawing.Point(194, 165)
        Me.btnProject4.Name = "btnProject4"
        Me.btnProject4.Size = New System.Drawing.Size(397, 23)
        Me.btnProject4.TabIndex = 7
        Me.btnProject4.Text = "Project 4"
        Me.btnProject4.UseVisualStyleBackColor = True
        '
        'btnProject5
        '
        Me.btnProject5.Enabled = False
        Me.btnProject5.Location = New System.Drawing.Point(194, 194)
        Me.btnProject5.Name = "btnProject5"
        Me.btnProject5.Size = New System.Drawing.Size(397, 23)
        Me.btnProject5.TabIndex = 8
        Me.btnProject5.Text = "Project 5"
        Me.btnProject5.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(516, 252)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnProjectG
        '
        Me.btnProjectG.Enabled = False
        Me.btnProjectG.Location = New System.Drawing.Point(194, 223)
        Me.btnProjectG.Name = "btnProjectG"
        Me.btnProjectG.Size = New System.Drawing.Size(397, 23)
        Me.btnProjectG.TabIndex = 10
        Me.btnProjectG.Text = "Group Project- A basic Calculator"
        Me.btnProjectG.UseVisualStyleBackColor = True
        '
        'frmProjManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 291)
        Me.Controls.Add(Me.btnProjectG)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnProject5)
        Me.Controls.Add(Me.btnProject4)
        Me.Controls.Add(Me.btnProject3)
        Me.Controls.Add(Me.btnProject2)
        Me.Controls.Add(Me.btnProject1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmProjManager"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnProject1 As System.Windows.Forms.Button
    Friend WithEvents btnProject2 As System.Windows.Forms.Button
    Friend WithEvents btnProject3 As System.Windows.Forms.Button
    Friend WithEvents btnProject4 As System.Windows.Forms.Button
    Friend WithEvents btnProject5 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnProjectG As System.Windows.Forms.Button
End Class

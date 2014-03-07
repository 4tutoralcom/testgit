<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorial
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
        Me.btnCalcualte = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtFactorial = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbNunmber = New System.Windows.Forms.ComboBox()
        Me.lblCreateBy = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalcualte
        '
        Me.btnCalcualte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcualte.Location = New System.Drawing.Point(15, 111)
        Me.btnCalcualte.Name = "btnCalcualte"
        Me.btnCalcualte.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcualte.TabIndex = 0
        Me.btnCalcualte.Text = "&Calculate"
        Me.btnCalcualte.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(151, 111)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtFactorial
        '
        Me.txtFactorial.Location = New System.Drawing.Point(105, 77)
        Me.txtFactorial.Name = "txtFactorial"
        Me.txtFactorial.ReadOnly = True
        Me.txtFactorial.Size = New System.Drawing.Size(121, 20)
        Me.txtFactorial.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Factorial:"
        '
        'cmbNunmber
        '
        Me.cmbNunmber.FormattingEnabled = True
        Me.cmbNunmber.Location = New System.Drawing.Point(105, 8)
        Me.cmbNunmber.Name = "cmbNunmber"
        Me.cmbNunmber.Size = New System.Drawing.Size(121, 21)
        Me.cmbNunmber.TabIndex = 6
        '
        'lblCreateBy
        '
        Me.lblCreateBy.AutoSize = True
        Me.lblCreateBy.Location = New System.Drawing.Point(129, 173)
        Me.lblCreateBy.Name = "lblCreateBy"
        Me.lblCreateBy.Size = New System.Drawing.Size(0, 13)
        Me.lblCreateBy.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Created By Andrew Dittmann on  1/15/2014"
        '
        'frmFactorial
        '
        Me.AcceptButton = Me.btnCalcualte
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(245, 198)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCreateBy)
        Me.Controls.Add(Me.cmbNunmber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFactorial)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalcualte)
        Me.Name = "frmFactorial"
        Me.Text = "Factorial Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcualte As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtFactorial As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbNunmber As System.Windows.Forms.ComboBox
    Friend WithEvents lblCreateBy As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class

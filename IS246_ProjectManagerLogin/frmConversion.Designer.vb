<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversion
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
        Me.tabConversion = New System.Windows.Forms.TabControl()
        Me.tabTemperatures = New System.Windows.Forms.TabPage()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.txtFahrenheit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnCelsiusToFahrenheit = New System.Windows.Forms.RadioButton()
        Me.rbtnFahrenheitToCelsius = New System.Windows.Forms.RadioButton()
        Me.tabLength = New System.Windows.Forms.TabPage()
        Me.cmbConversion = New System.Windows.Forms.ComboBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabConversion.SuspendLayout()
        Me.tabTemperatures.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabLength.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabConversion
        '
        Me.tabConversion.Controls.Add(Me.tabTemperatures)
        Me.tabConversion.Controls.Add(Me.tabLength)
        Me.tabConversion.Location = New System.Drawing.Point(48, 12)
        Me.tabConversion.Name = "tabConversion"
        Me.tabConversion.SelectedIndex = 0
        Me.tabConversion.Size = New System.Drawing.Size(266, 209)
        Me.tabConversion.TabIndex = 0
        '
        'tabTemperatures
        '
        Me.tabTemperatures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabTemperatures.Controls.Add(Me.txtCelsius)
        Me.tabTemperatures.Controls.Add(Me.txtFahrenheit)
        Me.tabTemperatures.Controls.Add(Me.Label2)
        Me.tabTemperatures.Controls.Add(Me.Label1)
        Me.tabTemperatures.Controls.Add(Me.GroupBox1)
        Me.tabTemperatures.Location = New System.Drawing.Point(4, 22)
        Me.tabTemperatures.Name = "tabTemperatures"
        Me.tabTemperatures.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTemperatures.Size = New System.Drawing.Size(258, 183)
        Me.tabTemperatures.TabIndex = 0
        Me.tabTemperatures.Text = "Temperatures"
        Me.tabTemperatures.UseVisualStyleBackColor = True
        '
        'txtCelsius
        '
        Me.txtCelsius.Location = New System.Drawing.Point(126, 150)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.ReadOnly = True
        Me.txtCelsius.Size = New System.Drawing.Size(97, 20)
        Me.txtCelsius.TabIndex = 4
        '
        'txtFahrenheit
        '
        Me.txtFahrenheit.Location = New System.Drawing.Point(126, 117)
        Me.txtFahrenheit.Name = "txtFahrenheit"
        Me.txtFahrenheit.Size = New System.Drawing.Size(97, 20)
        Me.txtFahrenheit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Celsius"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fahrenheit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnCelsiusToFahrenheit)
        Me.GroupBox1.Controls.Add(Me.rbtnFahrenheitToCelsius)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 87)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversion"
        '
        'rbtnCelsiusToFahrenheit
        '
        Me.rbtnCelsiusToFahrenheit.AutoSize = True
        Me.rbtnCelsiusToFahrenheit.Location = New System.Drawing.Point(22, 53)
        Me.rbtnCelsiusToFahrenheit.Name = "rbtnCelsiusToFahrenheit"
        Me.rbtnCelsiusToFahrenheit.Size = New System.Drawing.Size(123, 17)
        Me.rbtnCelsiusToFahrenheit.TabIndex = 1
        Me.rbtnCelsiusToFahrenheit.Text = "Celsius to Fahrenheit"
        Me.rbtnCelsiusToFahrenheit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnCelsiusToFahrenheit.UseVisualStyleBackColor = True
        '
        'rbtnFahrenheitToCelsius
        '
        Me.rbtnFahrenheitToCelsius.AutoSize = True
        Me.rbtnFahrenheitToCelsius.Checked = True
        Me.rbtnFahrenheitToCelsius.Location = New System.Drawing.Point(22, 19)
        Me.rbtnFahrenheitToCelsius.Name = "rbtnFahrenheitToCelsius"
        Me.rbtnFahrenheitToCelsius.Size = New System.Drawing.Size(123, 17)
        Me.rbtnFahrenheitToCelsius.TabIndex = 0
        Me.rbtnFahrenheitToCelsius.TabStop = True
        Me.rbtnFahrenheitToCelsius.Text = "Fahrenheit to Celsius"
        Me.rbtnFahrenheitToCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbtnFahrenheitToCelsius.UseVisualStyleBackColor = True
        '
        'tabLength
        '
        Me.tabLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabLength.Controls.Add(Me.cmbConversion)
        Me.tabLength.Controls.Add(Me.txtTo)
        Me.tabLength.Controls.Add(Me.txtFrom)
        Me.tabLength.Controls.Add(Me.lblTo)
        Me.tabLength.Controls.Add(Me.lblFrom)
        Me.tabLength.Controls.Add(Me.Label4)
        Me.tabLength.Location = New System.Drawing.Point(4, 22)
        Me.tabLength.Name = "tabLength"
        Me.tabLength.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLength.Size = New System.Drawing.Size(258, 183)
        Me.tabLength.TabIndex = 1
        Me.tabLength.Text = "Length"
        Me.tabLength.UseVisualStyleBackColor = True
        '
        'cmbConversion
        '
        Me.cmbConversion.FormattingEnabled = True
        Me.cmbConversion.Items.AddRange(New Object() {"Miles To Kilometers", "Kilometers To Miles", "Feet To Meters", "Meters To Feet", "Inches To Centimeters", "Centimeters To Inches"})
        Me.cmbConversion.Location = New System.Drawing.Point(115, 38)
        Me.cmbConversion.Name = "cmbConversion"
        Me.cmbConversion.Size = New System.Drawing.Size(107, 21)
        Me.cmbConversion.TabIndex = 5
        '
        'txtTo
        '
        Me.txtTo.Enabled = False
        Me.txtTo.Location = New System.Drawing.Point(115, 120)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(107, 20)
        Me.txtTo.TabIndex = 4
        Me.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(115, 81)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(107, 20)
        Me.txtFrom.TabIndex = 3
        Me.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(72, 123)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(62, 84)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 1
        Me.lblFrom.Text = "From"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Conversion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(52, 227)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(235, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(77, 294)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(200, 16)
        Me.lblDate.TabIndex = 3
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Created by Andrew Dittmann on 1/22/2014"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmConversion
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(363, 334)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.tabConversion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConversion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversions"
        Me.tabConversion.ResumeLayout(False)
        Me.tabTemperatures.ResumeLayout(False)
        Me.tabTemperatures.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabLength.ResumeLayout(False)
        Me.tabLength.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabConversion As System.Windows.Forms.TabControl
    Friend WithEvents tabTemperatures As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnCelsiusToFahrenheit As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnFahrenheitToCelsius As System.Windows.Forms.RadioButton
    Friend WithEvents tabLength As System.Windows.Forms.TabPage
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtCelsius As System.Windows.Forms.TextBox
    Friend WithEvents txtFahrenheit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbConversion As System.Windows.Forms.ComboBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

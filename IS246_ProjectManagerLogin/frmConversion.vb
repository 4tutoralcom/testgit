Public Class frmConversion

    '*******************************************************************************************************
    ' Class Name:   frmConversion
    ' Created by:   Andrew Dittmann
    ' Created Date: 1/29/14
    ' Description:  The class is designed for converting Temperature and Lengths
    '********************************************************************************************************


    Sub New(intTabIndex As Integer)
        InitializeComponent()
        tabConversion.SelectedIndex = intTabIndex
    End Sub

    Private Sub frmConversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cmbConversion
            'loads data to lable
            .Items.Add("Miles to Kilometers")
            .Items.Add("Kilometers to Miles")
            .Items.Add("Feet to Meters")
            .Items.Add("Meters to Feet")
            .Items.Add("Inches to Centmeters")
            .Items.Add("Centmeters to Inches")
            .SelectedIndex = 0

        End With

        'set focus on From text box
        Me.txtFrom.Focus()

        'convert Temperatures initialize
        txtFahrenheit.Focus()
        txtFahrenheit.SelectAll()
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'close and return to frmProjectManager
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If tabConversion.SelectedIndex = 0 Then
            'Code for convert temperature
            Try
                'Declare Local Variable
                Dim sConversionTemperature As Single
                'Input Data
                If rbtnCelsiusToFahrenheit.Checked Then
                    'Validate Input Data Convert txtCelsius to Singal and preform calculation to convert to Fahrenheit.
                    sConversionTemperature = Single.Parse(txtCelsius.Text) * 5 / 9 + 32
                    'Display Result
                    txtFahrenheit.Text = sConversionTemperature.ToString("n2")
                Else
                    sConversionTemperature = (Single.Parse(txtFahrenheit.Text) - 32) * 5 / 9
                    'Display Result
                    txtCelsius.Text = sConversionTemperature.ToString("n2")
                End If
            Catch ex As Exception
                'Display Error Message
                MessageBox.Show(" A numeric number should be entered!")
            Finally
                'Set focus to txtCelsius or txtFahrenheit depending on selection
                If rbtnCelsiusToFahrenheit.Checked Then
                    txtCelsius.Focus()
                    txtCelsius.SelectAll()
                Else
                    txtFahrenheit.Focus()
                    txtFahrenheit.SelectAll()
                End If
            End Try


        ElseIf tabConversion.SelectedIndex = 1 Then
            'code for convert length
            Dim sngMultiplier As Single

            If IsNumeric(Me.txtFrom.Text) Then
                Select Case Me.cmbConversion.SelectedIndex
                    Case 0
                        sngMultiplier = 1.6093
                    Case 1
                        sngMultiplier = 0.6214
                    Case 2
                        sngMultiplier = 0.3048
                    Case 3
                        sngMultiplier = 3.2808
                    Case 4
                        sngMultiplier = 2.54
                    Case 5
                        sngMultiplier = 0.3937

                End Select
                txtTo.Text = FormatNumber(sngMultiplier * Me.txtFrom.Text)
            Else
                'Display Error Mesage
                MessageBox.Show(" A numeric number should be entered!", "Entry Error")
                'Clear Text boxes
                txtFrom.Clear()
                txtTo.Clear()
            End If

            'Set Focus
            txtFrom.Focus()
            txtFrom.SelectAll()





        End If
    End Sub

    Private Sub cmbConversion_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConversion.SelectedIndexChanged
        Select Case cmbConversion.SelectedIndex
            Case 0          'Miles to Kilometers is selected
                lblFrom.Text = "Miles"
                lblTo.Text = "Kilometers"
            Case 1          'Kilometers to Miles is selected
                lblFrom.Text = "Kilometers"
                lblTo.Text = "Miles"
            Case 2          'Feet to Meters is selected
                lblFrom.Text = "Feet"
                lblTo.Text = "Meters"
            Case 3          'Meters to Feet is selected
                lblFrom.Text = "Meters"
                lblTo.Text = "Feet"
            Case 4          'Inches to Centimeters is selected
                lblFrom.Text = "Inches"
                lblTo.Text = "Centimeters"
            Case 5          'Centimeters to Inches is selected
                lblFrom.Text = "Centimeters"
                lblTo.Text = "Inches"

        End Select

        'Clear textboxes and set focus
        txtFrom.Clear()
        txtFrom.Focus()
        txtTo.Clear()

    End Sub

    Private Sub rbtnCelsisusToFelrenheit_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCelsiusToFahrenheit.CheckedChanged
        'Set ReadOnly Property
        txtCelsius.ReadOnly = Not rbtnCelsiusToFahrenheit.Checked
        txtFahrenheit.ReadOnly = rbtnCelsiusToFahrenheit.Checked

        'Clear textboxes and set focus
        txtCelsius.Clear()
        txtFahrenheit.Clear()
        txtCelsius.Focus()
    End Sub

    Private Sub rbtnFahrenheitToCelsius_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFahrenheitToCelsius.CheckedChanged
        'Set ReadOnly Property
        txtCelsius.ReadOnly = rbtnFahrenheitToCelsius.Checked
        txtFahrenheit.ReadOnly = Not rbtnFahrenheitToCelsius.Checked

        'Clear textboxes and set focus
        txtCelsius.Clear()
        txtFahrenheit.Clear()
        txtFahrenheit.Focus()
    End Sub

    Private Sub txtFrom_TextChanged(sender As Object, e As EventArgs) Handles txtFrom.TextChanged
        'Clear txtTo textbox
        txtTo.Text = String.Empty
    End Sub

    Private Sub txtFahrenheit_TextChanged(sender As Object, e As EventArgs) Handles txtFahrenheit.TextChanged
        'Clear txtCelsius textbox when it is for displaying result
        If (rbtnFahrenheitToCelsius.Checked) Then
            txtCelsius.Text = String.Empty
        End If
    End Sub

    Private Sub txtCelsius_TextChanged(sender As Object, e As EventArgs) Handles txtCelsius.TextChanged
        'Clear txtFahrenheit textbox when it is for dsiplaying result
        If (rbtnCelsiusToFahrenheit.Checked) Then
            txtFahrenheit.Text = String.Empty
        End If
    End Sub
End Class
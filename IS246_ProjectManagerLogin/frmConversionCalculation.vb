Public Class frmConversionCalculation

    '**************************************************************************************************************************
    '   Class Name:     frmConversionCalculations
    '   Created By:     Andrew Dittmann
    '   Created Date:   1/29/2014
    '   Description:    The SDI application lets the user display two of the forms from a parent form.
    '**************************************************************************************************************************

    Private Sub btnConvertTemperature_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertTemperature.Click
        Dim ConversionForm As frmConversion = New frmConversion(0)
        Me.Visible = False
        ConversionForm.ShowDialog()

        Me.Visible = True
    End Sub

    Private Sub btnConvertLength_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertLength.Click
        Dim ConversionForm As frmConversion = New frmConversion(1)
        Me.Visible = False
        ConversionForm.ShowDialog()
        Me.Visible = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
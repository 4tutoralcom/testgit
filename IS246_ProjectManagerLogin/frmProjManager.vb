'==============================================================================
'Class Name     : frm ProjectManager
'Created By     : Andrew Dittmann
'Creation Date  : 1/22/2014
'Description    : The class allows the user to seellect form diffrent projects.
'==============================================================================
Public Class frmProjManager

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close() 'close this form.
    End Sub
#Region "Removed"

    'Private Sub btnProject1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProject1.Click
    '    MessageBox.Show("It is not available at this time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) 'This project not implimented yet.
    'End Sub
#End Region

    Private Sub btnProject1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProject1.Click
        Dim factorial As frmConversionCalculation = New frmConversionCalculation()  '
        Me.Visible = False                                                          '
        factorial.ShowDialog()                                                      '
        Me.Visible = True                                                           '
    End Sub

    Private Sub btnProject2_Click(sender As System.Object, e As System.EventArgs) Handles btnProject2.Click
        Dim conversion As frmConversionCalculation = New frmConversionCalculation() '
        Me.Visible = False                                                          '
        conversion.ShowDialog()                                                     '
        Me.Visible = True                                                           '
    End Sub

    Private Sub btnProject3_Click(sender As System.Object, e As System.EventArgs) Handles btnProject3.Click
        Dim SimpleCalculator As frmSimpleCalculator = New frmSimpleCalculator() '
        Me.Visible = False                                                          '
        SimpleCalculator.ShowDialog()                                                     '
        Me.Visible = True
    End Sub
End Class
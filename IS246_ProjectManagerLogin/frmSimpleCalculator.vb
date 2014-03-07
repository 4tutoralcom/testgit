Public Class frmSimpleCalculator
    Private Function CalculateResult(operand1 As Decimal, operator1 As String, operand2 As Decimal) As Decimal
        Dim result As Decimal = 0
        'out put result depending on +, -, /, or *
        Select Case operator1
            Case "+"
                result = operand1 + operand2
            Case "-"
                result = operand1 - operand2
            Case "/"
                result = operand1 / operand2
            Case "*"
                result = operand1 * operand2
            Case Else
        End Select
        Return result
    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close() 'Close Window
    End Sub

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim operand1 As Decimal
        Dim operator1 As String
        Dim operand2 As Decimal
        Dim result As String
        'validate input`
        If ValidateInput.IsDecimal(txtOperand1, "Operand 1") AndAlso _
           ValidateInput.IsOperator(txtOperator, "Operator") AndAlso _
           ValidateInput.IsDecimal(txtOperand2, "Operand 2") Then

            'get input
            operand1 = Decimal.Parse(txtOperand1.Text)
            operator1 = txtOperator.Text
            operand2 = Decimal.Parse(txtOperand2.Text)
            'error message if divide by 0
            If txtOperand2.Text = "0" And txtOperator.Text = "/" Then
                result = "N/A: Divide by 0"
                txtOperand2.Select()
                txtOperand2.SelectAll()
            Else
                'calculate result
                result = Math.Round(CalculateResult(operand1, operator1, operand2), 4)
            End If
            'display result
            txtResult.Text = result
        End If
    End Sub
End Class
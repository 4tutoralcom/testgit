'CType
Public Class frmFactorial

    Private Sub btnCalcualte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcualte.Click
        Try
            Dim intInput As Integer = Integer.Parse(cmbNunmber.Text())
            Dim intCount As Integer = 1
            Dim lngTotal As ULong = 1
            If intInput > 0 Then
                Do While (intCount <= intInput)
                    lngTotal *= Long.Parse(intCount)
                    intCount += 1
                Loop
                txtFactorial.Text = lngTotal.ToString("n0")
            Else
                'throws Exception to get get out Try and in to the Catch to dispaly Error
                Throw New Exception()
            End If
        Catch ex As Exception
            'display error on Exception
            MessageBox.Show("You need to enter in a number between 1 amd 20" _
                            & vbNewLine & "Please enter a valid Number", _
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbNunmber.SelectAll()
            cmbNunmber.Focus()
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmFactorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblCreateBy.Text = "Updated on " & Format(DateTime.Now, "dddd, MMM d yyyy")
        lblCreateBy.Location = New Point(Me.Width / 2 - lblCreateBy.Width / 2, lblCreateBy.Location.Y)

        For i As Integer = 1 To 20
            cmbNunmber.Items.Add(i)
        Next
    End Sub
End Class
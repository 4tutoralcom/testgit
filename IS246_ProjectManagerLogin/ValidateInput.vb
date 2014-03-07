'====================================================================================
'Class Name     : ValidateInput
'Created By     : Andrew Dittmann
'Creation Date  : 3/4/2014
'Description    : The class controls vilidation of input by the controls fo the form.
'====================================================================================
Public Class ValidateInput
    Private Shared ReadOnly Operators As String() = {"-", "*", "/", "+"}
    'checks if the text box is empty, false if empy, true if the text box has text.
    Public Shared Function IsPresent(textbox As TextBox, strName As String) As Boolean
        Dim bolIsPresent As Boolean = String.IsNullOrEmpty(textbox.Text)

        If Not bolIsPresent Then
            MessageBox.Show(strName & "is required field.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textbox.Select()
        End If
        Return bolIsPresent
    End Function
    'returns true if the textbox's text can be converted into a integer value.
    Public Shared Function IsInt32(textbox As TextBox, strName As String, Optional errorMessage As String = "must be an integer value") As Boolean
        Dim intNumber As Integer = 0
        Dim bolIsInt32 As Boolean = Integer.TryParse(textbox.Text, intNumber)
        If Not bolIsInt32 Then
            MessageBox.Show(strName & errorMessage, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textbox.Select()
            textbox.SelectAll()
        End If
        Return bolIsInt32
    End Function
    'returns true if the textbox's text can be converted into a decimal value.
    Public Shared Function IsDecimal(textbox As TextBox, strName As String, Optional errorMessage As String = " must be an decimal value") As Boolean
        Dim decNumber As Decimal = 0.0
        Dim bolIsDecimal As Boolean = Decimal.TryParse(textbox.Text, decNumber)
        If Not bolIsDecimal Then
            MessageBox.Show(strName & errorMessage, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textbox.Select()
            textbox.SelectAll()
        End If
        Return bolIsDecimal
    End Function
    Public Shared Function IsOperator(textbox As TextBox, strName As String) As Boolean
        Dim strMessage As String = ""
        Dim bolIsOperator As Boolean = Array.BinarySearch(Operators, textbox.Text) > -1

        If Not bolIsOperator Then
            strMessage = " must be "
            For Each item As String In Operators
                strMessage += item + ", "

            Next
            MessageBox.Show(strName & strMessage, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            textbox.Select()
            textbox.SelectAll()
        End If
        Return bolIsOperator
    End Function
    Public Shared Function IsWithinRange(textbox As TextBox, strName As String, dMin As Decimal, dMax As Decimal, Optional errorMessage As String = " must be between %1 and %2") As Boolean
        Dim decNumber As Decimal = 0.0
        Dim strMessage As String = ""
        errorMessage = Replace(Replace(Replace(Replace(errorMessage, "%%", "%3"), "%1", dMin), "%2", dMax), "%3", "%") 'repalce all %% with %3. Then repalce %1 and %2 with min and max values. Finally repalce %3 with % to prevent unexpected errors.
        Dim boolIsWithinRange As Boolean = IsDecimal(textbox, strName, errorMessage)
        If boolIsWithinRange Then
            Decimal.TryParse(textbox.Text, decNumber)
            If decNumber > dMax Or decNumber < dMin Then
                MessageBox.Show(strName & errorMessage, "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textbox.Select()
                textbox.SelectAll()
                boolIsWithinRange = False
            End If
        End If
        Return boolIsWithinRange
    End Function
End Class

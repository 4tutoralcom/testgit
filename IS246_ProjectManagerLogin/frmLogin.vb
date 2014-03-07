'==========================================================================
'Class Name    : frm ProjectManagerLogin
'Created By    : Andrew Dittmann
'Creation Date : 1/22/2014
'Description:
Public Class frmLogin
    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load	
        lblCreateBy.Text = "Updated on " & Format(DateTime.Now, "dddd, MMM d yyyy") 'Format for data string display
        lblCreateBy.Location = New Point(Me.Width / 2 - lblCreateBy.Width / 2, lblCreateBy.Location.Y) 'set the textbox half way between the screen.
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        'Declare Local Values
        Dim strUserName As String = txtUserName.Text 'string from username textbox
        Dim strPassword As String = txtPassword.Text 'string from password textbox
        If (String.IsNullOrEmpty(strUserName) Or strUserName.Trim().ToUpper() <> "USERNAME") Then 'if username is not equal to the corrent username then show an error.
            MessageBox.Show("Your User Name is not correct. Please Try Again", "Error UserName Incorect", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Display Error  Message
            txtUserName.SelectAll()     'Select All text in username textbox
            txtUserName.Focus()         'Set Fouse in username textbox
        ElseIf (String.IsNullOrEmpty(strPassword) Or strPassword.Trim().ToUpper() <> "PASSWORD") Then 'if password is not equal to the corrent password then show an error.
            MessageBox.Show("Your Passowrd is not correct. Please Try Again", "Error Password Incorect", MessageBoxButtons.OK, MessageBoxIcon.Error) 'Display Error  Message
            txtPassword.SelectAll()     'Select All text in password textbox
            txtPassword.Focus()         'Set Fouse in password textbox
        Else
            Me.Visible = False          'make this form invisiable to the user.
            Dim projectmanager As frmProjManager = New frmProjManager() 'Create New Project Manager Form
            projectmanager.ShowDialog() 'show Project Manager Form
            'clear all text boxes.
            txtPassword.Clear()
            txtUserName.Clear()
            txtUserName.Focus()
            Me.Visible = True           'return visiablity of the form to the user.
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Application.Exit() 'Exit App
    End Sub

End Class

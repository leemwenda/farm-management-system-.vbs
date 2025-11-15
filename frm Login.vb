Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' Simple validation (you can later connect this to a database)
        If username = "" Or password = "" Then
            lblMessage.Text = "Please fill in all fields!"
            Exit Sub
        End If

        ' Example login credentials (you can change later)
        If username.ToLower() = "admin" And password = "1234" Then
            lblMessage.ForeColor = Color.Green
            lblMessage.Text = "Login successful!"
            MessageBox.Show("Welcome " & username & "!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Open Main Menu
            Dim mainForm As New FormMainMenu()
            mainForm.Show()
            Me.Hide()
        Else
            lblMessage.ForeColor = Color.Red
            lblMessage.Text = "Invalid username or password!"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()

        '=== FORM DESIGN ===
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Login - Farm Management System"

        '=== TITLE ===
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(60, 30)
        Me.lblTitle.Text = "🐄 Farm Management System"

        '=== USERNAME LABEL ===
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(50, 100)
        Me.lblUsername.Text = "Username:"

        '=== PASSWORD LABEL ===
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(50, 140)
        Me.lblPassword.Text = "Password:"

        '=== USERNAME TEXTBOX ===
        Me.txtUsername.Location = New System.Drawing.Point(150, 100)
        Me.txtUsername.Size = New System.Drawing.Size(180, 23)

        '=== PASSWORD TEXTBOX ===
        Me.txtPassword.Location = New System.Drawing.Point(150, 140)
        Me.txtPassword.Size = New System.Drawing.Size(180, 23)
        Me.txtPassword.PasswordChar = "•"c

        '=== LOGIN BUTTON ===
        Me.btnLogin.BackColor = System.Drawing.Color.DarkGreen
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.Location = New System.Drawing.Point(150, 190)
        Me.btnLogin.Size = New System.Drawing.Size(80, 30)
        Me.btnLogin.Text = "Login"

        '=== EXIT BUTTON ===
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(250, 190)
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.Text = "Exit"

        '=== MESSAGE LABEL ===
        Me.lblMessage.AutoSize = True
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(150, 230)
        Me.lblMessage.Text = ""

        '=== ADD CONTROLS ===
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblMessage)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMessage As Label
End Class

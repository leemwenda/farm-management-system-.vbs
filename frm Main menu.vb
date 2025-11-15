Public Class FormMainMenu

    Private Sub FormMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional initialization code
    End Sub

    Private Sub btnCrops_Click(sender As Object, e As EventArgs) Handles btnCrops.Click
        Dim frm As New FormCrops
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLivestock_Click(sender As Object, e As EventArgs) Handles btnLivestock.Click
        Dim frm As New frmLivestock
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnFinance_Click(sender As Object, e As EventArgs) Handles btnFinance.Click
        Dim frm As New frmFinance
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        Dim frm As New frmEmployee
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Dim frm As New frmReports
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim frmLogin As New FormLogin
        frmLogin.Show()
        Me.Close()
    End Sub

End Class

Friend Class FormLogin
    Friend Sub Show()
        Throw New NotImplementedException()
    End Sub
End Class

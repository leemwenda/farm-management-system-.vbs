Public Class frmEmployee
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtSalary.Text = "" Or txtContact.Text = "" Then
            MessageBox.Show("Please fill all fields.", "Missing Info")
            Exit Sub
        End If

        dgvEmployees.Rows.Add(txtName.Text, cboRole.Text, txtSalary.Text, txtContact.Text)
        MessageBox.Show("Employee added successfully!", "Success")
        ClearFields()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvEmployees.CurrentRow IsNot Nothing Then
            dgvEmployees.CurrentRow.Cells(0).Value = txtName.Text
            dgvEmployees.CurrentRow.Cells(1).Value = cboRole.Text
            dgvEmployees.CurrentRow.Cells(2).Value = txtSalary.Text
            dgvEmployees.CurrentRow.Cells(3).Value = txtContact.Text
            MessageBox.Show("Employee updated!", "Updated")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvEmployees.CurrentRow IsNot Nothing Then
            dgvEmployees.Rows.Remove(dgvEmployees.CurrentRow)
            MessageBox.Show("Employee deleted!", "Deleted")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtSalary.Clear()
        txtContact.Clear()
        cboRole.SelectedIndex = -1
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormMainMenu.Show()
        Me.Hide()
    End Sub
End Class

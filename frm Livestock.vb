Public Class frmLivestock
    Dim table As New DataTable()

    Private Sub frmLivestock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Animal ID")
        table.Columns.Add("Type")
        table.Columns.Add("Breed")
        table.Columns.Add("Date of Birth")
        table.Columns.Add("Age")
        table.Columns.Add("Gender")
        table.Columns.Add("Weight")
        table.Columns.Add("Health")
        table.Columns.Add("Location")

        dgvLivestock.DataSource = table
    End Sub

    Private Sub dtpDOB_ValueChanged(sender As Object, e As EventArgs) Handles dtpDOB.ValueChanged
        Dim dob As Date = dtpDOB.Value
        Dim age As Integer = Date.Now.Year - dob.Year
        If Date.Now < dob.AddYears(age) Then age -= 1
        txtAge.Text = age.ToString() & " yrs"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        table.Rows.Add(txtAnimalID.Text, cboType.Text, txtBreed.Text, dtpDOB.Text, txtAge.Text, cboGender.Text, txtWeight.Text, cboHealth.Text, txtLocation.Text)
        MessageBox.Show("Livestock Added Successfully!", "Success")
        ClearFields()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvLivestock.CurrentRow IsNot Nothing Then
            With dgvLivestock.CurrentRow
                .Cells("Animal ID").Value = txtAnimalID.Text
                .Cells("Type").Value = cboType.Text
                .Cells("Breed").Value = txtBreed.Text
                .Cells("Date of Birth").Value = dtpDOB.Text
                .Cells("Age").Value = txtAge.Text
                .Cells("Gender").Value = cboGender.Text
                .Cells("Weight").Value = txtWeight.Text
                .Cells("Health").Value = cboHealth.Text
                .Cells("Location").Value = txtLocation.Text
            End With
            MessageBox.Show("Record Updated!", "Updated")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvLivestock.CurrentRow IsNot Nothing Then
            dgvLivestock.Rows.Remove(dgvLivestock.CurrentRow)
            MessageBox.Show("Record Deleted!", "Deleted")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtAnimalID.Clear()
        cboType.SelectedIndex = -1
        txtBreed.Clear()
        txtAge.Clear()
        cboGender.SelectedIndex = -1
        txtWeight.Clear()
        cboHealth.SelectedIndex = -1
        txtLocation.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainMenu As New FormMainMenu()
        mainMenu.Show()
        Me.Hide()
    End Sub
End Class

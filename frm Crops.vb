Public Class FormCrops

    Dim dt As New DataTable()

    Private Sub FormCrops_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize DataTable columns
        dt.Columns.Add("Crop Name")
        dt.Columns.Add("Crop Type")
        dt.Columns.Add("Planting Date")
        dt.Columns.Add("Quantity (kg)")

        dgvCrops.DataSource = dt
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCropName.Text = "" Or txtCropType.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please fill all fields before adding.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        dt.Rows.Add(txtCropName.Text, txtCropType.Text, dtpPlantingDate.Value.ToShortDateString(), txtQuantity.Text)
        MessageBox.Show("Crop added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearFields()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvCrops.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a crop record to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvCrops.SelectedRows(0)
        row.Cells(0).Value = txtCropName.Text
        row.Cells(1).Value = txtCropType.Text
        row.Cells(2).Value = dtpPlantingDate.Value.ToShortDateString()
        row.Cells(3).Value = txtQuantity.Text

        MessageBox.Show("Crop record updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearFields()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvCrops.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        dt.Rows.RemoveAt(dgvCrops.SelectedRows(0).Index)
        MessageBox.Show("Crop deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearFields()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtCropName.Clear()
        txtCropType.Clear()
        txtQuantity.Clear()
        dtpPlantingDate.Value = Date.Now
        txtCropName.Focus()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim frm As New FormMainMenu
        frm.Show()
        Me.Close()
    End Sub

    Private Sub dgvCrops_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCrops.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCrops.Rows(e.RowIndex)
            txtCropName.Text = row.Cells(0).Value.ToString()
            txtCropType.Text = row.Cells(1).Value.ToString()
            dtpPlantingDate.Value = Date.Parse(row.Cells(2).Value)
            txtQuantity.Text = row.Cells(3).Value.ToString()
        End If
    End Sub

End Class

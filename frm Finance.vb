Public Class frmFinance
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim income, expenses, profit As Decimal

        If Decimal.TryParse(txtIncome.Text, income) AndAlso Decimal.TryParse(txtExpenses.Text, expenses) Then
            profit = income - expenses
            txtProfit.Text = profit.ToString("C2")

            If profit < 0 Then
                txtProfit.ForeColor = Color.Red
            Else
                txtProfit.ForeColor = Color.Green
            End If
        Else
            MessageBox.Show("Please enter valid numeric values for income and expenses.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIncome.Clear()
        txtExpenses.Clear()
        txtProfit.Clear()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Example of saving finance data (you could use DatabaseModule to insert)
        Dim record As String = $"Income: {txtIncome.Text}, Expenses: {txtExpenses.Text}, Profit: {txtProfit.Text}"
        MessageBox.Show("Record saved successfully!" & vbCrLf & record, "Finance", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' Refresh DataGridView if connected to database
    End Sub
End Class

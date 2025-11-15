Public Class frmReports
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim reportType As String = cboReportType.Text
        rtbReport.Clear()

        Select Case reportType
            Case "Crops Summary"
                rtbReport.AppendText("🌾 CROPS REPORT" & vbCrLf)
                rtbReport.AppendText("Total Crop Types: 5" & vbCrLf & "Active Fields: 12" & vbCrLf & "Expected Yield: 2500 kg")
            Case "Livestock Summary"
                rtbReport.AppendText("🐄 LIVESTOCK REPORT" & vbCrLf)
                rtbReport.AppendText("Total Cows: 20" & vbCrLf & "Goats: 15" & vbCrLf & "Daily Milk Production: 120L")
            Case "Employee List"
                rtbReport.AppendText("👷 EMPLOYEE REPORT" & vbCrLf)
                rtbReport.AppendText("Total Employees: 8" & vbCrLf & "Average Salary: Ksh 35,000")
            Case "Financial Overview"
                rtbReport.AppendText("💰 FINANCIAL REPORT" & vbCrLf)
                rtbReport.AppendText("Monthly Income: Ksh 120,000" & vbCrLf & "Expenses: Ksh 80,000" & vbCrLf & "Profit: Ksh 40,000")
            Case Else
                MessageBox.Show("Please select a report type.")
        End Select
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "Text Files|*.txt"
        sfd.Title = "Save Report"
        If sfd.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllText(sfd.FileName, rtbReport.Text)
            MessageBox.Show("Report exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormMainMenu.Show()
        Me.Hide()
    End Sub
End Class

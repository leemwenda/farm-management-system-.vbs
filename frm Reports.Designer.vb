<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboReportType = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.rtbReport = New System.Windows.Forms.RichTextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblTitle.Location = New System.Drawing.Point(180, 20)
        Me.lblTitle.Text = "📈 Farm Reports & Analytics"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboReportType
        '
        Me.cboReportType.Items.AddRange(New Object() {"Crops Summary", "Livestock Summary", "Employee List", "Financial Overview"})
        Me.cboReportType.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cboReportType.Location = New System.Drawing.Point(150, 90)
        Me.cboReportType.Size = New System.Drawing.Size(250, 28)
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(420, 90)
        Me.btnGenerate.Text = "Generate Report"
        '
        'rtbReport
        '
        Me.rtbReport.Location = New System.Drawing.Point(70, 140)
        Me.rtbReport.Size = New System.Drawing.Size(500, 300)
        Me.rtbReport.ReadOnly = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(150, 460)
        Me.btnExport.Text = "Export Report"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(320, 460)
        Me.btnBack.Text = "Back"
        '
        'frmReports
        '
        Me.ClientSize = New System.Drawing.Size(650, 520)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.cboReportType)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.rtbReport)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnBack)
        Me.Text = "Farm Reports"
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboReportType As ComboBox
    Friend WithEvents btnGenerate, btnExport, btnBack As Button
    Friend WithEvents rtbReport As RichTextBox
End Class

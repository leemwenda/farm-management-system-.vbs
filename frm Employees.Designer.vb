<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployee
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.cboRole = New System.Windows.Forms.ComboBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTitle.Location = New System.Drawing.Point(180, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(350, 40)
        Me.lblTitle.Text = "👷 Farm Employee Management"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(70, 90)
        Me.lblName.Text = "Full Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(170, 85)
        Me.txtName.Size = New System.Drawing.Size(220, 27)
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(70, 130)
        Me.lblRole.Text = "Role:"
        '
        'cboRole
        '
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.Items.AddRange(New Object() {"Manager", "Farmhand", "Veterinarian", "Driver", "Cleaner"})
        Me.cboRole.Location = New System.Drawing.Point(170, 125)
        Me.cboRole.Size = New System.Drawing.Size(220, 28)
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(70, 170)
        Me.lblSalary.Text = "Salary:"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(170, 165)
        Me.txtSalary.Size = New System.Drawing.Size(220, 27)
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(70, 210)
        Me.lblContact.Text = "Contact:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(170, 205)
        Me.txtContact.Size = New System.Drawing.Size(220, 27)
        '
        'Buttons
        '
        Me.btnAdd.Location = New System.Drawing.Point(420, 90)
        Me.btnAdd.Text = "Add Employee"
        Me.btnUpdate.Location = New System.Drawing.Point(420, 130)
        Me.btnUpdate.Text = "Update"
        Me.btnDelete.Location = New System.Drawing.Point(420, 170)
        Me.btnDelete.Text = "Delete"
        Me.btnClear.Location = New System.Drawing.Point(420, 210)
        Me.btnClear.Text = "Clear"
        Me.btnBack.Location = New System.Drawing.Point(420, 250)
        Me.btnBack.Text = "Back"
        '
        'dgvEmployees
        '
        Me.dgvEmployees.Location = New System.Drawing.Point(70, 300)
        Me.dgvEmployees.Size = New System.Drawing.Size(500, 200)
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        '
        'frmEmployee
        '
        Me.ClientSize = New System.Drawing.Size(650, 550)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.cboRole)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Text = "Employee Management"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Friend WithEvents lblTitle, lblName, lblRole, lblSalary, lblContact As Label
    Friend WithEvents txtName, txtSalary, txtContact As TextBox
    Friend WithEvents cboRole As ComboBox
    Friend WithEvents btnAdd, btnUpdate, btnDelete, btnClear, btnBack As Button
    Friend WithEvents dgvEmployees As DataGridView
End Class

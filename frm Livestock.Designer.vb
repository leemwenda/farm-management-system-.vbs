<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLivestock
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up components.
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpLivestock = New System.Windows.Forms.GroupBox()
        Me.txtAnimalID = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.cboHealth = New System.Windows.Forms.ComboBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.dgvLivestock = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()

        Me.pnlMain.SuspendLayout()
        Me.grpLivestock.SuspendLayout()
        CType(Me.dgvLivestock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '=== Panel (scrollable container) ===
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke

        '=== Title Label ===
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI", 16.0!, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.DarkGreen
        Me.lblTitle.Location = New Point(260, 20)
        Me.lblTitle.Text = "🐄 Livestock Management"

        '=== GroupBox ===
        Me.grpLivestock.Text = "Livestock Details"
        Me.grpLivestock.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.grpLivestock.BackColor = Color.Honeydew
        Me.grpLivestock.Location = New Point(40, 70)
        Me.grpLivestock.Size = New Size(700, 280)

        '=== Labels & Inputs ===
        Dim lblX = 20, txtX = 150, y = 40, gap = 28

        Me.lblID.Text = "Animal ID:" : Me.lblID.Location = New Point(lblX, y)
        Me.txtAnimalID.Location = New Point(txtX, y - 3) : Me.txtAnimalID.Width = 150
        y += gap
        Me.lblType.Text = "Type:" : Me.lblType.Location = New Point(lblX, y)
        Me.cboType.Items.AddRange(New Object() {"Cow", "Goat", "Sheep", "Pig", "Chicken"})
        Me.cboType.Location = New Point(txtX, y - 3) : Me.cboType.Width = 150
        y += gap
        Me.lblBreed.Text = "Breed:" : Me.lblBreed.Location = New Point(lblX, y)
        Me.txtBreed.Location = New Point(txtX, y - 3) : Me.txtBreed.Width = 150
        y += gap
        Me.lblDOB.Text = "Date of Birth:" : Me.lblDOB.Location = New Point(lblX, y)
        Me.dtpDOB.Location = New Point(txtX, y - 3) : Me.dtpDOB.Width = 150
        y += gap
        Me.lblAge.Text = "Age:" : Me.lblAge.Location = New Point(lblX, y)
        Me.txtAge.Location = New Point(txtX, y - 3) : Me.txtAge.Width = 150 : Me.txtAge.ReadOnly = True
        y += gap
        Me.lblGender.Text = "Gender:" : Me.lblGender.Location = New Point(lblX, y)
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New Point(txtX, y - 3) : Me.cboGender.Width = 150
        y += gap
        Me.lblWeight.Text = "Weight (kg):" : Me.lblWeight.Location = New Point(lblX, y)
        Me.txtWeight.Location = New Point(txtX, y - 3) : Me.txtWeight.Width = 150
        y += gap
        Me.lblHealth.Text = "Health:" : Me.lblHealth.Location = New Point(lblX, y)
        Me.cboHealth.Items.AddRange(New Object() {"Healthy", "Sick", "Under Treatment"})
        Me.cboHealth.Location = New Point(txtX, y - 3) : Me.cboHealth.Width = 150
        y += gap
        Me.lblLocation.Text = "Location:" : Me.lblLocation.Location = New Point(lblX, y)
        Me.txtLocation.Location = New Point(txtX, y - 3) : Me.txtLocation.Width = 150

        Me.grpLivestock.Controls.AddRange(New Control() {
            lblID, txtAnimalID, lblType, cboType, lblBreed, txtBreed,
            lblDOB, dtpDOB, lblAge, txtAge, lblGender, cboGender,
            lblWeight, txtWeight, lblHealth, cboHealth, lblLocation, txtLocation
        })

        '=== DataGridView ===
        Me.dgvLivestock.Location = New Point(40, 370)
        Me.dgvLivestock.Size = New Size(700, 220)
        Me.dgvLivestock.BackgroundColor = Color.White
        Me.dgvLivestock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLivestock.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvLivestock.ReadOnly = True

        '=== Buttons ===
        Me.btnAdd.Text = "Add"
        Me.btnAdd.Location = New Point(40, 610)
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.Location = New Point(130, 610)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Location = New Point(220, 610)
        Me.btnClear.Text = "Clear"
        Me.btnClear.Location = New Point(310, 610)
        Me.btnBack.Text = "⬅ Back to Main Menu"
        Me.btnBack.Location = New Point(560, 610)
        Me.btnBack.Width = 180

        '=== Add Everything to Panel ===
        Me.pnlMain.Controls.AddRange(New Control() {
            lblTitle, grpLivestock, dgvLivestock,
            btnAdd, btnEdit, btnDelete, btnClear, btnBack
        })

        '=== Form Settings ===
        Me.ClientSize = New Size(800, 700)
        Me.Controls.Add(Me.pnlMain)
        Me.Text = "Livestock Management"

        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.grpLivestock.ResumeLayout(False)
        Me.grpLivestock.PerformLayout()
        CType(Me.dgvLivestock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpLivestock As GroupBox
    Friend WithEvents txtAnimalID As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents cboHealth As ComboBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblBreed As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHealth As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents dgvLivestock As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
End Class

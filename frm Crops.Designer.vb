<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCrops
    Inherits System.Windows.Forms.Form

    ' Dispose method
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCropName = New System.Windows.Forms.Label()
        Me.lblCropType = New System.Windows.Forms.Label()
        Me.lblPlantingDate = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()

        Me.txtCropName = New System.Windows.Forms.TextBox()
        Me.txtCropType = New System.Windows.Forms.TextBox()
        Me.dtpPlantingDate = New System.Windows.Forms.DateTimePicker()
        Me.txtQuantity = New System.Windows.Forms.TextBox()

        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()

        Me.dgvCrops = New System.Windows.Forms.DataGridView()

        Me.PanelHeader.SuspendLayout()
        CType(Me.dgvCrops, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        ' PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.ForestGreen
        Me.PanelHeader.Controls.Add(Me.lblTitle)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(850, 70)
        Me.PanelHeader.TabIndex = 0

        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(300, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(280, 30)
        Me.lblTitle.Text = "🌱 Crops Management"

        '
        ' Labels
        '
        Me.lblCropName.AutoSize = True
        Me.lblCropName.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblCropName.Location = New System.Drawing.Point(50, 100)
        Me.lblCropName.Text = "Crop Name:"

        Me.lblCropType.AutoSize = True
        Me.lblCropType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblCropType.Location = New System.Drawing.Point(50, 140)
        Me.lblCropType.Text = "Crop Type:"

        Me.lblPlantingDate.AutoSize = True
        Me.lblPlantingDate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblPlantingDate.Location = New System.Drawing.Point(50, 180)
        Me.lblPlantingDate.Text = "Planting Date:"

        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblQuantity.Location = New System.Drawing.Point(50, 220)
        Me.lblQuantity.Text = "Quantity (kg):"

        '
        ' Inputs
        '
        Me.txtCropName.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCropName.Location = New System.Drawing.Point(180, 97)
        Me.txtCropName.Size = New System.Drawing.Size(200, 27)

        Me.txtCropType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCropType.Location = New System.Drawing.Point(180, 137)
        Me.txtCropType.Size = New System.Drawing.Size(200, 27)

        Me.dtpPlantingDate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpPlantingDate.Location = New System.Drawing.Point(180, 177)
        Me.dtpPlantingDate.Size = New System.Drawing.Size(200, 27)

        Me.txtQuantity.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtQuantity.Location = New System.Drawing.Point(180, 217)
        Me.txtQuantity.Size = New System.Drawing.Size(200, 27)

        '
        ' Buttons
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.Location = New System.Drawing.Point(420, 100)
        Me.btnAdd.Size = New System.Drawing.Size(100, 40)
        Me.btnAdd.Text = "Add"
        Me.btnAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAdd.ForeColor = System.Drawing.Color.White

        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.Location = New System.Drawing.Point(540, 100)
        Me.btnUpdate.Size = New System.Drawing.Size(100, 40)
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.BackColor = System.Drawing.Color.Teal
        Me.btnUpdate.ForeColor = System.Drawing.Color.White

        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.Location = New System.Drawing.Point(660, 100)
        Me.btnDelete.Size = New System.Drawing.Size(100, 40)
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.BackColor = System.Drawing.Color.Maroon
        Me.btnDelete.ForeColor = System.Drawing.Color.White

        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(540, 160)
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.Text = "Clear"
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.ForeColor = System.Drawing.Color.White

        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.Location = New System.Drawing.Point(660, 160)
        Me.btnBack.Size = New System.Drawing.Size(100, 40)
        Me.btnBack.Text = "Back"
        Me.btnBack.BackColor = System.Drawing.Color.DarkOrange
        Me.btnBack.ForeColor = System.Drawing.Color.White

        '
        ' DataGridView
        '
        Me.dgvCrops.Location = New System.Drawing.Point(50, 280)
        Me.dgvCrops.Size = New System.Drawing.Size(720, 200)
        Me.dgvCrops.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCrops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize

        '
        ' FormCrops
        '
        Me.ClientSize = New System.Drawing.Size(850, 520)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.lblCropName)
        Me.Controls.Add(Me.txtCropName)
        Me.Controls.Add(Me.lblCropType)
        Me.Controls.Add(Me.txtCropType)
        Me.Controls.Add(Me.lblPlantingDate)
        Me.Controls.Add(Me.dtpPlantingDate)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvCrops)
        Me.BackColor = System.Drawing.Color.Beige
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crops Management"

        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.dgvCrops, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCropName As Label
    Friend WithEvents lblCropType As Label
    Friend WithEvents lblPlantingDate As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtCropName As TextBox
    Friend WithEvents txtCropType As TextBox
    Friend WithEvents dtpPlantingDate As DateTimePicker
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvCrops As DataGridView
End Class

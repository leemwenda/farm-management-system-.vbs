<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFinance
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.lblExpenses = New System.Windows.Forms.Label()
        Me.txtExpenses = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblProfit = New System.Windows.Forms.Label()
        Me.txtProfit = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvFinance = New System.Windows.Forms.DataGridView()
        CType(Me.dgvFinance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblTitle.Location = New System.Drawing.Point(150, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(350, 40)
        Me.lblTitle.Text = "💰 Farm Finance Management"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Location = New System.Drawing.Point(80, 90)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(60, 20)
        Me.lblIncome.Text = "Income:"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(200, 85)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(200, 27)
        '
        'lblExpenses
        '
        Me.lblExpenses.AutoSize = True
        Me.lblExpenses.Location = New System.Drawing.Point(80, 130)
        Me.lblExpenses.Name = "lblExpenses"
        Me.lblExpenses.Size = New System.Drawing.Size(75, 20)
        Me.lblExpenses.Text = "Expenses:"
        '
        'txtExpenses
        '
        Me.txtExpenses.Location = New System.Drawing.Point(200, 125)
        Me.txtExpenses.Name = "txtExpenses"
        Me.txtExpenses.Size = New System.Drawing.Size(200, 27)
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(420, 105)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 35)
        Me.btnCalculate.Text = "Calculate Profit"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.Location = New System.Drawing.Point(80, 180)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(83, 20)
        Me.lblProfit.Text = "Profit/Loss:"
        '
        'txtProfit
        '
        Me.txtProfit.Location = New System.Drawing.Point(200, 175)
        Me.txtProfit.Name = "txtProfit"
        Me.txtProfit.ReadOnly = True
        Me.txtProfit.Size = New System.Drawing.Size(200, 27)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(80, 230)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(200, 230)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 35)
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(320, 230)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 35)
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvFinance
        '
        Me.dgvFinance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinance.Location = New System.Drawing.Point(80, 290)
        Me.dgvFinance.Name = "dgvFinance"
        Me.dgvFinance.Size = New System.Drawing.Size(460, 180)
        '
        'frmFinance
        '
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.lblExpenses)
        Me.Controls.Add(Me.txtExpenses)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblProfit)
        Me.Controls.Add(Me.txtProfit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvFinance)
        Me.Name = "frmFinance"
        Me.Text = "Farm Finance Management"
        CType(Me.dgvFinance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents lblExpenses As Label
    Friend WithEvents txtExpenses As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblProfit As Label
    Friend WithEvents txtProfit As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvFinance As DataGridView
End Class

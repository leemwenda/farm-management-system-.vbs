<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMainMenu
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

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCrops = New System.Windows.Forms.Button()
        Me.btnLivestock = New System.Windows.Forms.Button()
        Me.btnFinance = New System.Windows.Forms.Button()
        Me.btnEmployees = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PanelHeader = New System.Windows.Forms.Panel()

        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()

        '
        ' PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.DarkGreen
        Me.PanelHeader.Controls.Add(Me.lblTitle)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(800, 70)
        Me.PanelHeader.TabIndex = 0

        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(200, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(390, 32)
        Me.lblTitle.Text = "🌾 FARM MANAGEMENT SYSTEM"

        '
        ' btnCrops
        '
        Me.btnCrops.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCrops.Location = New System.Drawing.Point(80, 120)
        Me.btnCrops.Name = "btnCrops"
        Me.btnCrops.Size = New System.Drawing.Size(250, 60)
        Me.btnCrops.Text = "🌱 Crops Management"
        Me.btnCrops.UseVisualStyleBackColor = True

        '
        ' btnLivestock
        '
        Me.btnLivestock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLivestock.Location = New System.Drawing.Point(420, 120)
        Me.btnLivestock.Name = "btnLivestock"
        Me.btnLivestock.Size = New System.Drawing.Size(250, 60)
        Me.btnLivestock.Text = "🐄 Livestock Management"
        Me.btnLivestock.UseVisualStyleBackColor = True

        '
        ' btnFinance
        '
        Me.btnFinance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinance.Location = New System.Drawing.Point(80, 220)
        Me.btnFinance.Name = "btnFinance"
        Me.btnFinance.Size = New System.Drawing.Size(250, 60)
        Me.btnFinance.Text = "💰 Finance Management"
        Me.btnFinance.UseVisualStyleBackColor = True

        '
        ' btnEmployees
        '
        Me.btnEmployees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmployees.Location = New System.Drawing.Point(420, 220)
        Me.btnEmployees.Name = "btnEmployees"
        Me.btnEmployees.Size = New System.Drawing.Size(250, 60)
        Me.btnEmployees.Text = "👷 Employee Management"
        Me.btnEmployees.UseVisualStyleBackColor = True

        '
        ' btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnReports.Location = New System.Drawing.Point(250, 320)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(300, 60)
        Me.btnReports.Text = "📊 View Reports"
        Me.btnReports.UseVisualStyleBackColor = True

        '
        ' btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.Red
        Me.btnLogout.Location = New System.Drawing.Point(650, 400)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(120, 40)
        Me.btnLogout.Text = "🔒 Logout"
        Me.btnLogout.UseVisualStyleBackColor = True

        '
        ' FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.btnCrops)
        Me.Controls.Add(Me.btnLivestock)
        Me.Controls.Add(Me.btnFinance)
        Me.Controls.Add(Me.btnEmployees)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnLogout)
        Me.Name = "FormMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Farm Management System"

        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCrops As Button
    Friend WithEvents btnLivestock As Button
    Friend WithEvents btnFinance As Button
    Friend WithEvents btnEmployees As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents PanelHeader As Panel
End Class

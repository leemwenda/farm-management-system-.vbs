import { supabase } from '../config/supabase.js'
import { showPage } from '../main.js'

export function initReports() {
  window.addEventListener('page-loaded', (e) => {
    if (e.detail.page === 'reports') {
      loadReportsPage()
    }
  })
}

async function loadReportsPage() {
  const container = document.getElementById('reports-page')

  container.innerHTML = `
    <div class="page-header">
      <h2>📊 Farm Reports & Analytics</h2>
      <button class="btn btn-secondary" onclick="window.showPage('dashboard')">Back to Dashboard</button>
    </div>

    <div class="form-container">
      <div class="form-grid" style="grid-template-columns: 1fr 1fr auto;">
        <div class="form-group">
          <label for="report-type">Report Type</label>
          <select id="report-type">
            <option value="crops">Crops Summary</option>
            <option value="livestock">Livestock Summary</option>
            <option value="employees">Employees Summary</option>
            <option value="finance">Financial Overview</option>
            <option value="all">Complete Farm Report</option>
          </select>
        </div>
        <div></div>
        <div class="form-group" style="display: flex; align-items: flex-end;">
          <button id="generate-report-btn" class="btn btn-success">Generate Report</button>
        </div>
      </div>
    </div>

    <div class="report-content" id="report-content">
      <p style="text-align: center; color: #666;">Select a report type and click "Generate Report" to view analytics.</p>
    </div>
  `

  window.showPage = showPage

  document.getElementById('generate-report-btn').addEventListener('click', generateReport)
}

async function generateReport() {
  const reportType = document.getElementById('report-type').value
  const reportContent = document.getElementById('report-content')

  reportContent.innerHTML = '<p style="text-align: center;">Loading report...</p>'

  let content = ''

  switch (reportType) {
    case 'crops':
      content = await generateCropsReport()
      break
    case 'livestock':
      content = await generateLivestockReport()
      break
    case 'employees':
      content = await generateEmployeesReport()
      break
    case 'finance':
      content = await generateFinanceReport()
      break
    case 'all':
      content = await generateCompleteReport()
      break
  }

  reportContent.innerHTML = `<pre>${content}</pre>`
}

async function generateCropsReport() {
  const { data, error } = await supabase
    .from('crops')
    .select('*')

  if (error) {
    return 'Error loading crops data'
  }

  let report = '═══════════════════════════════════════════\n'
  report += '            CROPS SUMMARY REPORT           \n'
  report += '═══════════════════════════════════════════\n\n'

  if (!data || data.length === 0) {
    report += 'No crops data available.\n'
    return report
  }

  report += `Total Crop Entries: ${data.length}\n\n`

  const typeCount = {}
  let totalQuantity = 0

  data.forEach(crop => {
    typeCount[crop.crop_type] = (typeCount[crop.crop_type] || 0) + 1
    totalQuantity += crop.quantity
  })

  report += 'Crop Types Distribution:\n'
  report += '─────────────────────────────────────────\n'
  for (const [type, count] of Object.entries(typeCount)) {
    report += `  ${type}: ${count} entries\n`
  }

  report += `\nTotal Quantity: ${totalQuantity.toLocaleString()} kg\n\n`

  report += 'Recent Crops:\n'
  report += '─────────────────────────────────────────\n'
  data.slice(0, 5).forEach(crop => {
    report += `  • ${crop.crop_name} (${crop.crop_type})\n`
    report += `    Planted: ${new Date(crop.planting_date).toLocaleDateString()}\n`
    report += `    Quantity: ${crop.quantity} kg\n\n`
  })

  return report
}

async function generateLivestockReport() {
  const { data, error } = await supabase
    .from('livestock')
    .select('*')

  if (error) {
    return 'Error loading livestock data'
  }

  let report = '═══════════════════════════════════════════\n'
  report += '          LIVESTOCK SUMMARY REPORT         \n'
  report += '═══════════════════════════════════════════\n\n'

  if (!data || data.length === 0) {
    report += 'No livestock data available.\n'
    return report
  }

  report += `Total Animals: ${data.length}\n\n`

  const typeCount = {}
  const healthCount = {}
  let totalWeight = 0

  data.forEach(animal => {
    typeCount[animal.animal_type] = (typeCount[animal.animal_type] || 0) + 1
    healthCount[animal.health_status] = (healthCount[animal.health_status] || 0) + 1
    totalWeight += animal.weight
  })

  report += 'Animal Types:\n'
  report += '─────────────────────────────────────────\n'
  for (const [type, count] of Object.entries(typeCount)) {
    report += `  ${type}: ${count}\n`
  }

  report += '\nHealth Status:\n'
  report += '─────────────────────────────────────────\n'
  for (const [status, count] of Object.entries(healthCount)) {
    report += `  ${status}: ${count}\n`
  }

  report += `\nTotal Weight: ${totalWeight.toLocaleString()} kg\n`
  report += `Average Weight: ${(totalWeight / data.length).toFixed(2)} kg\n`

  return report
}

async function generateEmployeesReport() {
  const { data, error } = await supabase
    .from('employees')
    .select('*')

  if (error) {
    return 'Error loading employees data'
  }

  let report = '═══════════════════════════════════════════\n'
  report += '         EMPLOYEES SUMMARY REPORT          \n'
  report += '═══════════════════════════════════════════\n\n'

  if (!data || data.length === 0) {
    report += 'No employees data available.\n'
    return report
  }

  report += `Total Employees: ${data.length}\n\n`

  const roleCount = {}
  let totalSalary = 0

  data.forEach(emp => {
    roleCount[emp.role] = (roleCount[emp.role] || 0) + 1
    totalSalary += emp.salary
  })

  report += 'Roles Distribution:\n'
  report += '─────────────────────────────────────────\n'
  for (const [role, count] of Object.entries(roleCount)) {
    report += `  ${role}: ${count}\n`
  }

  report += `\nTotal Payroll: $${totalSalary.toLocaleString()}\n`
  report += `Average Salary: $${(totalSalary / data.length).toLocaleString()}\n\n`

  report += 'Employee List:\n'
  report += '─────────────────────────────────────────\n'
  data.forEach(emp => {
    report += `  • ${emp.full_name} - ${emp.role}\n`
    report += `    Salary: $${emp.salary.toLocaleString()}\n`
    report += `    Contact: ${emp.contact}\n\n`
  })

  return report
}

async function generateFinanceReport() {
  const { data, error } = await supabase
    .from('finance')
    .select('*')

  if (error) {
    return 'Error loading finance data'
  }

  let report = '═══════════════════════════════════════════\n'
  report += '         FINANCIAL OVERVIEW REPORT         \n'
  report += '═══════════════════════════════════════════\n\n'

  if (!data || data.length === 0) {
    report += 'No financial data available.\n'
    return report
  }

  let totalIncome = 0
  let totalExpense = 0

  data.forEach(transaction => {
    if (transaction.transaction_type === 'income') {
      totalIncome += transaction.amount
    } else {
      totalExpense += transaction.amount
    }
  })

  const profit = totalIncome - totalExpense

  report += `Total Income:    $${totalIncome.toLocaleString()}\n`
  report += `Total Expenses:  $${totalExpense.toLocaleString()}\n`
  report += `───────────────────────────────────────\n`
  report += `Net Profit/Loss: $${profit.toLocaleString()}\n`
  report += `Status: ${profit >= 0 ? 'PROFITABLE ✓' : 'LOSS ✗'}\n\n`

  report += 'Recent Transactions:\n'
  report += '─────────────────────────────────────────\n'
  data.slice(0, 10).forEach(transaction => {
    const type = transaction.transaction_type.toUpperCase()
    const sign = transaction.transaction_type === 'income' ? '+' : '-'
    report += `  ${sign} ${type}: ${transaction.description}\n`
    report += `    Amount: $${transaction.amount.toLocaleString()}\n`
    report += `    Date: ${new Date(transaction.transaction_date).toLocaleDateString()}\n\n`
  })

  return report
}

async function generateCompleteReport() {
  let report = '═══════════════════════════════════════════\n'
  report += '        COMPLETE FARM MANAGEMENT REPORT    \n'
  report += '═══════════════════════════════════════════\n'
  report += `Generated: ${new Date().toLocaleString()}\n`
  report += '═══════════════════════════════════════════\n\n'

  report += await generateCropsReport()
  report += '\n\n'
  report += await generateLivestockReport()
  report += '\n\n'
  report += await generateEmployeesReport()
  report += '\n\n'
  report += await generateFinanceReport()

  return report
}

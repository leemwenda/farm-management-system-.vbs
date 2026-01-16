import { supabase } from '../config/supabase.js'
import { showPage } from '../main.js'

let editingId = null

export function initFinance() {
  window.addEventListener('page-loaded', (e) => {
    if (e.detail.page === 'finance') {
      loadFinancePage()
    }
  })
}

async function loadFinancePage() {
  const container = document.getElementById('finance-page')

  container.innerHTML = `
    <div class="page-header">
      <h2>💰 Finance Management</h2>
      <button class="btn btn-secondary" onclick="window.showPage('dashboard')">Back to Dashboard</button>
    </div>

    <div class="finance-summary" id="finance-summary"></div>

    <div class="form-container">
      <form id="finance-form">
        <div class="form-grid">
          <div class="form-group">
            <label for="transaction-type">Transaction Type</label>
            <select id="transaction-type" required>
              <option value="">Select type</option>
              <option value="income">Income</option>
              <option value="expense">Expense</option>
            </select>
          </div>
          <div class="form-group">
            <label for="description">Description</label>
            <input type="text" id="description" required>
          </div>
          <div class="form-group">
            <label for="amount">Amount</label>
            <input type="number" id="amount" step="0.01" required>
          </div>
          <div class="form-group">
            <label for="transaction-date">Date</label>
            <input type="date" id="transaction-date" required>
          </div>
        </div>
        <div class="form-actions">
          <button type="submit" class="btn btn-success">
            <span id="finance-submit-text">Add Transaction</span>
          </button>
          <button type="button" class="btn btn-secondary" id="finance-clear-btn">Clear</button>
        </div>
      </form>
    </div>

    <div class="table-container">
      <table>
        <thead>
          <tr>
            <th>Date</th>
            <th>Type</th>
            <th>Description</th>
            <th>Amount</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody id="finance-tbody"></tbody>
      </table>
    </div>
  `

  window.showPage = showPage

  const form = document.getElementById('finance-form')
  const clearBtn = document.getElementById('finance-clear-btn')

  document.getElementById('transaction-date').valueAsDate = new Date()

  form.addEventListener('submit', async (e) => {
    e.preventDefault()
    await saveTransaction()
  })

  clearBtn.addEventListener('click', clearForm)

  await loadFinance()
  await loadSummary()
}

async function saveTransaction() {
  const transactionData = {
    transaction_type: document.getElementById('transaction-type').value,
    description: document.getElementById('description').value,
    amount: parseFloat(document.getElementById('amount').value),
    transaction_date: document.getElementById('transaction-date').value
  }

  if (editingId) {
    const { error } = await supabase
      .from('finance')
      .update(transactionData)
      .eq('id', editingId)

    if (error) {
      alert('Error updating transaction: ' + error.message)
      return
    }
    alert('Transaction updated successfully!')
  } else {
    const { error } = await supabase
      .from('finance')
      .insert([transactionData])

    if (error) {
      alert('Error adding transaction: ' + error.message)
      return
    }
    alert('Transaction added successfully!')
  }

  clearForm()
  await loadFinance()
  await loadSummary()
}

async function loadFinance() {
  const { data, error } = await supabase
    .from('finance')
    .select('*')
    .order('transaction_date', { ascending: false })

  if (error) {
    console.error('Error loading finance:', error)
    return
  }

  const tbody = document.getElementById('finance-tbody')

  if (!data || data.length === 0) {
    tbody.innerHTML = '<tr><td colspan="5" class="empty-state">No transactions found. Add your first transaction above.</td></tr>'
    return
  }

  tbody.innerHTML = data.map(transaction => `
    <tr>
      <td>${new Date(transaction.transaction_date).toLocaleDateString()}</td>
      <td><span style="color: ${transaction.transaction_type === 'income' ? '#28a745' : '#dc3545'}">${transaction.transaction_type.toUpperCase()}</span></td>
      <td>${transaction.description}</td>
      <td>$${transaction.amount.toLocaleString()}</td>
      <td class="action-buttons">
        <button class="btn btn-sm btn-secondary btn-icon" onclick="window.editTransaction('${transaction.id}')">Edit</button>
        <button class="btn btn-sm btn-danger btn-icon" onclick="window.deleteTransaction('${transaction.id}')">Delete</button>
      </td>
    </tr>
  `).join('')
}

async function loadSummary() {
  const { data, error } = await supabase
    .from('finance')
    .select('transaction_type, amount')

  if (error) {
    console.error('Error loading summary:', error)
    return
  }

  let totalIncome = 0
  let totalExpense = 0

  if (data) {
    data.forEach(transaction => {
      if (transaction.transaction_type === 'income') {
        totalIncome += transaction.amount
      } else {
        totalExpense += transaction.amount
      }
    })
  }

  const profit = totalIncome - totalExpense

  const summary = document.getElementById('finance-summary')
  summary.innerHTML = `
    <div class="finance-card">
      <h3>Total Income</h3>
      <div class="amount income">$${totalIncome.toLocaleString()}</div>
    </div>
    <div class="finance-card">
      <h3>Total Expenses</h3>
      <div class="amount expense">$${totalExpense.toLocaleString()}</div>
    </div>
    <div class="finance-card">
      <h3>Net Profit/Loss</h3>
      <div class="amount profit" style="color: ${profit >= 0 ? '#28a745' : '#dc3545'}">$${profit.toLocaleString()}</div>
    </div>
  `
}

async function editTransaction(id) {
  const { data, error } = await supabase
    .from('finance')
    .select('*')
    .eq('id', id)
    .maybeSingle()

  if (error || !data) {
    alert('Error loading transaction')
    return
  }

  editingId = id
  document.getElementById('transaction-type').value = data.transaction_type
  document.getElementById('description').value = data.description
  document.getElementById('amount').value = data.amount
  document.getElementById('transaction-date').value = data.transaction_date
  document.getElementById('finance-submit-text').textContent = 'Update Transaction'
}

async function deleteTransaction(id) {
  if (!confirm('Are you sure you want to delete this transaction?')) return

  const { error } = await supabase
    .from('finance')
    .delete()
    .eq('id', id)

  if (error) {
    alert('Error deleting transaction: ' + error.message)
    return
  }

  alert('Transaction deleted successfully!')
  await loadFinance()
  await loadSummary()
}

function clearForm() {
  editingId = null
  document.getElementById('finance-form').reset()
  document.getElementById('transaction-date').valueAsDate = new Date()
  document.getElementById('finance-submit-text').textContent = 'Add Transaction'
}

window.editTransaction = editTransaction
window.deleteTransaction = deleteTransaction

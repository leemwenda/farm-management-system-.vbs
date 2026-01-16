import { supabase } from '../config/supabase.js'
import { showPage } from '../main.js'

let editingId = null

export function initEmployees() {
  window.addEventListener('page-loaded', (e) => {
    if (e.detail.page === 'employees') {
      loadEmployeesPage()
    }
  })
}

async function loadEmployeesPage() {
  const container = document.getElementById('employees-page')

  container.innerHTML = `
    <div class="page-header">
      <h2>👷 Employee Management</h2>
      <button class="btn btn-secondary" onclick="window.showPage('dashboard')">Back to Dashboard</button>
    </div>

    <div class="form-container">
      <form id="employees-form">
        <div class="form-grid">
          <div class="form-group">
            <label for="emp-name">Full Name</label>
            <input type="text" id="emp-name" required>
          </div>
          <div class="form-group">
            <label for="emp-role">Role</label>
            <select id="emp-role" required>
              <option value="">Select role</option>
              <option value="Manager">Manager</option>
              <option value="Farmhand">Farmhand</option>
              <option value="Veterinarian">Veterinarian</option>
              <option value="Driver">Driver</option>
              <option value="Cleaner">Cleaner</option>
            </select>
          </div>
          <div class="form-group">
            <label for="emp-salary">Salary</label>
            <input type="number" id="emp-salary" step="0.01" required>
          </div>
          <div class="form-group">
            <label for="emp-contact">Contact</label>
            <input type="text" id="emp-contact" required>
          </div>
        </div>
        <div class="form-actions">
          <button type="submit" class="btn btn-success">
            <span id="emp-submit-text">Add Employee</span>
          </button>
          <button type="button" class="btn btn-secondary" id="emp-clear-btn">Clear</button>
        </div>
      </form>
    </div>

    <div class="table-container">
      <table>
        <thead>
          <tr>
            <th>Full Name</th>
            <th>Role</th>
            <th>Salary</th>
            <th>Contact</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody id="employees-tbody"></tbody>
      </table>
    </div>
  `

  window.showPage = showPage

  const form = document.getElementById('employees-form')
  const clearBtn = document.getElementById('emp-clear-btn')

  form.addEventListener('submit', async (e) => {
    e.preventDefault()
    await saveEmployee()
  })

  clearBtn.addEventListener('click', clearForm)

  await loadEmployees()
}

async function saveEmployee() {
  const employeeData = {
    full_name: document.getElementById('emp-name').value,
    role: document.getElementById('emp-role').value,
    salary: parseFloat(document.getElementById('emp-salary').value),
    contact: document.getElementById('emp-contact').value
  }

  if (editingId) {
    const { error } = await supabase
      .from('employees')
      .update(employeeData)
      .eq('id', editingId)

    if (error) {
      alert('Error updating employee: ' + error.message)
      return
    }
    alert('Employee updated successfully!')
  } else {
    const { error } = await supabase
      .from('employees')
      .insert([employeeData])

    if (error) {
      alert('Error adding employee: ' + error.message)
      return
    }
    alert('Employee added successfully!')
  }

  clearForm()
  await loadEmployees()
}

async function loadEmployees() {
  const { data, error } = await supabase
    .from('employees')
    .select('*')
    .order('created_at', { ascending: false })

  if (error) {
    console.error('Error loading employees:', error)
    return
  }

  const tbody = document.getElementById('employees-tbody')

  if (!data || data.length === 0) {
    tbody.innerHTML = '<tr><td colspan="5" class="empty-state">No employees found. Add your first employee above.</td></tr>'
    return
  }

  tbody.innerHTML = data.map(emp => `
    <tr>
      <td>${emp.full_name}</td>
      <td>${emp.role}</td>
      <td>$${emp.salary.toLocaleString()}</td>
      <td>${emp.contact}</td>
      <td class="action-buttons">
        <button class="btn btn-sm btn-secondary btn-icon" onclick="window.editEmployee('${emp.id}')">Edit</button>
        <button class="btn btn-sm btn-danger btn-icon" onclick="window.deleteEmployee('${emp.id}')">Delete</button>
      </td>
    </tr>
  `).join('')
}

async function editEmployee(id) {
  const { data, error } = await supabase
    .from('employees')
    .select('*')
    .eq('id', id)
    .maybeSingle()

  if (error || !data) {
    alert('Error loading employee')
    return
  }

  editingId = id
  document.getElementById('emp-name').value = data.full_name
  document.getElementById('emp-role').value = data.role
  document.getElementById('emp-salary').value = data.salary
  document.getElementById('emp-contact').value = data.contact
  document.getElementById('emp-submit-text').textContent = 'Update Employee'
}

async function deleteEmployee(id) {
  if (!confirm('Are you sure you want to delete this employee?')) return

  const { error } = await supabase
    .from('employees')
    .delete()
    .eq('id', id)

  if (error) {
    alert('Error deleting employee: ' + error.message)
    return
  }

  alert('Employee deleted successfully!')
  await loadEmployees()
}

function clearForm() {
  editingId = null
  document.getElementById('employees-form').reset()
  document.getElementById('emp-submit-text').textContent = 'Add Employee'
}

window.editEmployee = editEmployee
window.deleteEmployee = deleteEmployee

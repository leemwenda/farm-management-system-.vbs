import { supabase } from '../config/supabase.js'
import { showPage } from '../main.js'

let editingId = null

export function initLivestock() {
  window.addEventListener('page-loaded', (e) => {
    if (e.detail.page === 'livestock') {
      loadLivestockPage()
    }
  })
}

async function loadLivestockPage() {
  const container = document.getElementById('livestock-page')

  container.innerHTML = `
    <div class="page-header">
      <h2>🐄 Livestock Management</h2>
      <button class="btn btn-secondary" onclick="window.showPage('dashboard')">Back to Dashboard</button>
    </div>

    <div class="form-container">
      <form id="livestock-form">
        <div class="form-grid">
          <div class="form-group">
            <label for="animal-id">Animal ID</label>
            <input type="text" id="animal-id" required>
          </div>
          <div class="form-group">
            <label for="animal-type">Type</label>
            <select id="animal-type" required>
              <option value="">Select type</option>
              <option value="Cow">Cow</option>
              <option value="Goat">Goat</option>
              <option value="Sheep">Sheep</option>
              <option value="Pig">Pig</option>
              <option value="Chicken">Chicken</option>
            </select>
          </div>
          <div class="form-group">
            <label for="breed">Breed</label>
            <input type="text" id="breed" required>
          </div>
          <div class="form-group">
            <label for="dob">Date of Birth</label>
            <input type="date" id="dob" required>
          </div>
          <div class="form-group">
            <label for="gender">Gender</label>
            <select id="gender" required>
              <option value="">Select gender</option>
              <option value="Male">Male</option>
              <option value="Female">Female</option>
            </select>
          </div>
          <div class="form-group">
            <label for="weight">Weight (kg)</label>
            <input type="number" id="weight" step="0.01" required>
          </div>
          <div class="form-group">
            <label for="health">Health Status</label>
            <select id="health" required>
              <option value="">Select status</option>
              <option value="Healthy">Healthy</option>
              <option value="Sick">Sick</option>
              <option value="Under Treatment">Under Treatment</option>
            </select>
          </div>
          <div class="form-group">
            <label for="location">Location</label>
            <input type="text" id="location" required>
          </div>
        </div>
        <div class="form-actions">
          <button type="submit" class="btn btn-success">
            <span id="livestock-submit-text">Add Livestock</span>
          </button>
          <button type="button" class="btn btn-secondary" id="livestock-clear-btn">Clear</button>
        </div>
      </form>
    </div>

    <div class="table-container">
      <table>
        <thead>
          <tr>
            <th>Animal ID</th>
            <th>Type</th>
            <th>Breed</th>
            <th>Age</th>
            <th>Gender</th>
            <th>Weight</th>
            <th>Health</th>
            <th>Location</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody id="livestock-tbody"></tbody>
      </table>
    </div>
  `

  window.showPage = showPage

  const form = document.getElementById('livestock-form')
  const clearBtn = document.getElementById('livestock-clear-btn')

  form.addEventListener('submit', async (e) => {
    e.preventDefault()
    await saveLivestock()
  })

  clearBtn.addEventListener('click', clearForm)

  await loadLivestock()
}

function calculateAge(dob) {
  const birthDate = new Date(dob)
  const today = new Date()
  let age = today.getFullYear() - birthDate.getFullYear()
  const monthDiff = today.getMonth() - birthDate.getMonth()

  if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthDate.getDate())) {
    age--
  }

  return age + ' yrs'
}

async function saveLivestock() {
  const livestockData = {
    animal_id: document.getElementById('animal-id').value,
    animal_type: document.getElementById('animal-type').value,
    breed: document.getElementById('breed').value,
    date_of_birth: document.getElementById('dob').value,
    gender: document.getElementById('gender').value,
    weight: parseFloat(document.getElementById('weight').value),
    health_status: document.getElementById('health').value,
    location: document.getElementById('location').value
  }

  if (editingId) {
    const { error } = await supabase
      .from('livestock')
      .update(livestockData)
      .eq('id', editingId)

    if (error) {
      alert('Error updating livestock: ' + error.message)
      return
    }
    alert('Livestock updated successfully!')
  } else {
    const { error } = await supabase
      .from('livestock')
      .insert([livestockData])

    if (error) {
      alert('Error adding livestock: ' + error.message)
      return
    }
    alert('Livestock added successfully!')
  }

  clearForm()
  await loadLivestock()
}

async function loadLivestock() {
  const { data, error } = await supabase
    .from('livestock')
    .select('*')
    .order('created_at', { ascending: false })

  if (error) {
    console.error('Error loading livestock:', error)
    return
  }

  const tbody = document.getElementById('livestock-tbody')

  if (!data || data.length === 0) {
    tbody.innerHTML = '<tr><td colspan="9" class="empty-state">No livestock found. Add your first animal above.</td></tr>'
    return
  }

  tbody.innerHTML = data.map(animal => `
    <tr>
      <td>${animal.animal_id}</td>
      <td>${animal.animal_type}</td>
      <td>${animal.breed}</td>
      <td>${calculateAge(animal.date_of_birth)}</td>
      <td>${animal.gender}</td>
      <td>${animal.weight} kg</td>
      <td>${animal.health_status}</td>
      <td>${animal.location}</td>
      <td class="action-buttons">
        <button class="btn btn-sm btn-secondary btn-icon" onclick="window.editLivestock('${animal.id}')">Edit</button>
        <button class="btn btn-sm btn-danger btn-icon" onclick="window.deleteLivestock('${animal.id}')">Delete</button>
      </td>
    </tr>
  `).join('')
}

async function editLivestock(id) {
  const { data, error } = await supabase
    .from('livestock')
    .select('*')
    .eq('id', id)
    .maybeSingle()

  if (error || !data) {
    alert('Error loading livestock')
    return
  }

  editingId = id
  document.getElementById('animal-id').value = data.animal_id
  document.getElementById('animal-type').value = data.animal_type
  document.getElementById('breed').value = data.breed
  document.getElementById('dob').value = data.date_of_birth
  document.getElementById('gender').value = data.gender
  document.getElementById('weight').value = data.weight
  document.getElementById('health').value = data.health_status
  document.getElementById('location').value = data.location
  document.getElementById('livestock-submit-text').textContent = 'Update Livestock'
}

async function deleteLivestock(id) {
  if (!confirm('Are you sure you want to delete this livestock?')) return

  const { error } = await supabase
    .from('livestock')
    .delete()
    .eq('id', id)

  if (error) {
    alert('Error deleting livestock: ' + error.message)
    return
  }

  alert('Livestock deleted successfully!')
  await loadLivestock()
}

function clearForm() {
  editingId = null
  document.getElementById('livestock-form').reset()
  document.getElementById('livestock-submit-text').textContent = 'Add Livestock'
}

window.editLivestock = editLivestock
window.deleteLivestock = deleteLivestock

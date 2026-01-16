import { supabase } from '../config/supabase.js'
import { showPage } from '../main.js'

let editingId = null

export function initCrops() {
  window.addEventListener('page-loaded', (e) => {
    if (e.detail.page === 'crops') {
      loadCropsPage()
    }
  })
}

async function loadCropsPage() {
  const container = document.getElementById('crops-page')

  container.innerHTML = `
    <div class="page-header">
      <h2>🌱 Crops Management</h2>
      <button class="btn btn-secondary" onclick="window.showPage('dashboard')">Back to Dashboard</button>
    </div>

    <div class="form-container">
      <form id="crops-form">
        <div class="form-grid">
          <div class="form-group">
            <label for="crop-name">Crop Name</label>
            <input type="text" id="crop-name" required>
          </div>
          <div class="form-group">
            <label for="crop-type">Crop Type</label>
            <input type="text" id="crop-type" required>
          </div>
          <div class="form-group">
            <label for="planting-date">Planting Date</label>
            <input type="date" id="planting-date" required>
          </div>
          <div class="form-group">
            <label for="quantity">Quantity (kg)</label>
            <input type="number" id="quantity" step="0.01" required>
          </div>
        </div>
        <div class="form-actions">
          <button type="submit" class="btn btn-success">
            <span id="crop-submit-text">Add Crop</span>
          </button>
          <button type="button" class="btn btn-secondary" id="crop-clear-btn">Clear</button>
        </div>
      </form>
    </div>

    <div class="table-container">
      <table>
        <thead>
          <tr>
            <th>Crop Name</th>
            <th>Type</th>
            <th>Planting Date</th>
            <th>Quantity (kg)</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody id="crops-tbody"></tbody>
      </table>
    </div>
  `

  window.showPage = showPage

  const form = document.getElementById('crops-form')
  const clearBtn = document.getElementById('crop-clear-btn')

  form.addEventListener('submit', async (e) => {
    e.preventDefault()
    await saveCrop()
  })

  clearBtn.addEventListener('click', clearForm)

  await loadCrops()
}

async function saveCrop() {
  const cropData = {
    crop_name: document.getElementById('crop-name').value,
    crop_type: document.getElementById('crop-type').value,
    planting_date: document.getElementById('planting-date').value,
    quantity: parseFloat(document.getElementById('quantity').value)
  }

  if (editingId) {
    const { error } = await supabase
      .from('crops')
      .update(cropData)
      .eq('id', editingId)

    if (error) {
      alert('Error updating crop: ' + error.message)
      return
    }
    alert('Crop updated successfully!')
  } else {
    const { error } = await supabase
      .from('crops')
      .insert([cropData])

    if (error) {
      alert('Error adding crop: ' + error.message)
      return
    }
    alert('Crop added successfully!')
  }

  clearForm()
  await loadCrops()
}

async function loadCrops() {
  const { data, error } = await supabase
    .from('crops')
    .select('*')
    .order('created_at', { ascending: false })

  if (error) {
    console.error('Error loading crops:', error)
    return
  }

  const tbody = document.getElementById('crops-tbody')

  if (!data || data.length === 0) {
    tbody.innerHTML = '<tr><td colspan="5" class="empty-state">No crops found. Add your first crop above.</td></tr>'
    return
  }

  tbody.innerHTML = data.map(crop => `
    <tr>
      <td>${crop.crop_name}</td>
      <td>${crop.crop_type}</td>
      <td>${new Date(crop.planting_date).toLocaleDateString()}</td>
      <td>${crop.quantity}</td>
      <td class="action-buttons">
        <button class="btn btn-sm btn-secondary btn-icon" onclick="window.editCrop('${crop.id}')">Edit</button>
        <button class="btn btn-sm btn-danger btn-icon" onclick="window.deleteCrop('${crop.id}')">Delete</button>
      </td>
    </tr>
  `).join('')
}

async function editCrop(id) {
  const { data, error } = await supabase
    .from('crops')
    .select('*')
    .eq('id', id)
    .maybeSingle()

  if (error || !data) {
    alert('Error loading crop')
    return
  }

  editingId = id
  document.getElementById('crop-name').value = data.crop_name
  document.getElementById('crop-type').value = data.crop_type
  document.getElementById('planting-date').value = data.planting_date
  document.getElementById('quantity').value = data.quantity
  document.getElementById('crop-submit-text').textContent = 'Update Crop'
}

async function deleteCrop(id) {
  if (!confirm('Are you sure you want to delete this crop?')) return

  const { error } = await supabase
    .from('crops')
    .delete()
    .eq('id', id)

  if (error) {
    alert('Error deleting crop: ' + error.message)
    return
  }

  alert('Crop deleted successfully!')
  await loadCrops()
}

function clearForm() {
  editingId = null
  document.getElementById('crops-form').reset()
  document.getElementById('crop-submit-text').textContent = 'Add Crop'
}

window.editCrop = editCrop
window.deleteCrop = deleteCrop

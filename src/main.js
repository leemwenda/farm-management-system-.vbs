import { supabase } from './config/supabase.js'
import { initAuth } from './modules/auth.js'
import { initDashboard } from './modules/dashboard.js'
import { initCrops } from './modules/crops.js'
import { initLivestock } from './modules/livestock.js'
import { initEmployees } from './modules/employees.js'
import { initFinance } from './modules/finance.js'
import { initReports } from './modules/reports.js'

let currentUser = null

async function init() {
  const { data: { session } } = await supabase.auth.getSession()

  if (session) {
    currentUser = session.user
    showMainApp()
  } else {
    showAuth()
  }

  supabase.auth.onAuthStateChange((event, session) => {
    (() => {
      if (event === 'SIGNED_IN' && session) {
        currentUser = session.user
        showMainApp()
      } else if (event === 'SIGNED_OUT') {
        currentUser = null
        showAuth()
      }
    })()
  })

  initAuth()
  initDashboard()
  initCrops()
  initLivestock()
  initEmployees()
  initFinance()
  initReports()
}

function showAuth() {
  document.getElementById('auth-container').style.display = 'flex'
  document.getElementById('main-container').style.display = 'none'
}

function showMainApp() {
  document.getElementById('auth-container').style.display = 'none'
  document.getElementById('main-container').style.display = 'block'
  document.getElementById('user-email').textContent = currentUser?.email || ''
  showPage('dashboard')
}

export function showPage(pageName) {
  const pages = ['dashboard', 'crops-page', 'livestock-page', 'employees-page', 'finance-page', 'reports-page']

  pages.forEach(page => {
    const element = document.getElementById(page)
    if (element) {
      element.style.display = page === pageName || page === `${pageName}-page` ? 'block' : 'none'
    }
  })

  if (pageName !== 'dashboard') {
    const event = new CustomEvent('page-loaded', { detail: { page: pageName } })
    window.dispatchEvent(event)
  }
}

init()

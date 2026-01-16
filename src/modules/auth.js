import { supabase } from '../config/supabase.js'

export function initAuth() {
  const loginForm = document.getElementById('login-form')
  const logoutBtn = document.getElementById('logout-btn')
  const authMessage = document.getElementById('auth-message')

  loginForm.addEventListener('submit', async (e) => {
    e.preventDefault()

    const email = document.getElementById('email').value
    const password = document.getElementById('password').value

    authMessage.textContent = 'Logging in...'
    authMessage.className = 'auth-message'

    const { data, error } = await supabase.auth.signInWithPassword({
      email,
      password
    })

    if (error) {
      authMessage.textContent = error.message
      authMessage.className = 'auth-message error'
    } else {
      authMessage.textContent = 'Login successful!'
      authMessage.className = 'auth-message success'
      loginForm.reset()
    }
  })

  logoutBtn.addEventListener('click', async () => {
    await supabase.auth.signOut()
  })
}

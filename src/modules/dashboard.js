import { showPage } from '../main.js'

export function initDashboard() {
  const cards = document.querySelectorAll('.dashboard-card')

  cards.forEach(card => {
    card.addEventListener('click', () => {
      const page = card.dataset.page
      showPage(page)
    })
  })
}

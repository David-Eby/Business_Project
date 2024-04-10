// Function to save checkbox states to Local Storage
function saveCheckboxStates() {
  const checkboxes = document.querySelectorAll('input[type="checkbox"]');
  checkboxes.forEach((checkbox) => {
    localStorage.setItem(checkbox.id, checkbox.checked);
  });
}

// Function to load checkbox states from Local Storage
function loadCheckboxStates() {
  const checkboxes = document.querySelectorAll('input[type="checkbox"]');
  checkboxes.forEach((checkbox) => {
    const savedState = localStorage.getItem(checkbox.id);
    if (savedState !== null) {
      checkbox.checked = savedState === 'true';
    }
  });
}

// Attach event listener to the checkboxes to save their states
const checkboxes = document.querySelectorAll('input[type="checkbox"]');
checkboxes.forEach((checkbox) => {
  checkbox.addEventListener('change', saveCheckboxStates);
});

// Load checkbox states on page load
document.addEventListener('DOMContentLoaded', loadCheckboxStates);
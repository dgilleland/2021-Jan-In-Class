const makeTransparent = function(evt) {
    evt.target.classList.add('reveal');
    evt.target.innerHTML = '';
}
const addReveal = function(el) {
    el.addEventListener('mouseover', makeTransparent);
}
document.querySelectorAll('div').forEach(addReveal);

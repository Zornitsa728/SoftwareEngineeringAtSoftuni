function addItem() {
    const textEl = document.getElementById('newItemText');
    const itemsEls = document.getElementById('items');

    const newTextEl = document.createElement('li');
    newTextEl.textContent = textEl.value;

    itemsEls.appendChild(newTextEl);

    textEl.value = '';
}
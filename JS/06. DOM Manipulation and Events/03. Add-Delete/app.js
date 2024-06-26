function addItem() {
    const textEl = document.getElementById('newItemText');
    const itemsEls = document.getElementById('items');

    const newTextEl = document.createElement('li');
    newTextEl.textContent = textEl.value;

    //create link el
    const deleteLinkEl = document.createElement('a');
    deleteLinkEl.textContent = '[Delete]';
    deleteLinkEl.href = '#';

    function deleteItem() {
        newTextEl.remove();
    }

    deleteLinkEl.addEventListener('click', deleteItem);
    //Append link element to new item el
    newTextEl.appendChild(deleteLinkEl);

    //append new el to list
    itemsEls.appendChild(newTextEl);

    textEl.value = '';
}
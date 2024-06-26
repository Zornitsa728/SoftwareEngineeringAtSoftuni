function extractText() {
    let itemElements = document.getElementById('items');
    const textAreaEl = document.getElementById('result');

    textAreaEl.value = itemElements.textContent;
}
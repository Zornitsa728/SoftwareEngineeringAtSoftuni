function deleteByEmail() {
    const inputEl = document.querySelector('label input');
    const resultEl = document.getElementById('result');
    const allTrs = document.querySelectorAll('tbody tr');
    let isFound = false;

    for (const tr of allTrs) {
        if (tr.lastElementChild.textContent === inputEl.value) {
            tr.parentElement.removeChild(tr);
            isFound = true;
            break;
        }
    }

    if (!isFound) {
        const erorrEl = document.createElement('div');
        erorrEl.textContent = "Not found.";
        resultEl.appendChild(erorrEl);
    } else {
        resultEl.textContent = 'Deleted.';
    }
}
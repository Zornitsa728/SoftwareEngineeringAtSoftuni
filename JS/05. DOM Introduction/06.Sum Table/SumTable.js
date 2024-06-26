function sumTable() {
    const allValues = document.querySelectorAll('table td:nth-child(2n)');
    const total = document.getElementById('sum');

    let sum = 0;

    for (const value of allValues) {
        if (Number(value.textContent)) {
            sum += Number(value.textContent);
        }
    }

    total.textContent = sum;
}
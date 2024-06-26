function subtract() {
    const firstNumEl = document.getElementById('firstNumber');
    const secondNumEl = document.getElementById('secondNumber');
    const resultEl = document.getElementById('result');

    let subtraction = Number(firstNumEl.value) - Number(secondNumEl.value);

    resultEl.textContent = subtraction;
}
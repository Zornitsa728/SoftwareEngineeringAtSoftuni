function calc() {
    const firstNumber = document.getElementById('num1');
    const secondNumber = document.getElementById('num2');
    let text = document.getElementById('sum');

    const result = Number(firstNumber.value) + Number(secondNumber.value);

    text.value = result;
}

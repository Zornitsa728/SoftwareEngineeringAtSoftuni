function focused() {
    const inputElements = document.querySelectorAll('input[type=text]');

    Array.from(inputElements)
        .forEach(inputElement => inputElement.addEventListener('focus', (event) => {
            inputElement.parentElement.classList.add('focused');
        }));

    Array.from(inputElements)
        .forEach(inputElement => inputElement.addEventListener('blur', (event) => {
            inputElement.parentElement.classList.remove('focused');
        }));
}
function toggle() {
    const buttonEl = document.getElementsByClassName('button');
    const extraTextEl = document.getElementById('extra');

    if (buttonEl[0].textContent == 'More') {
        extraTextEl.style.display = 'block';
        buttonEl[0].textContent = 'Less';
    } else {
        extraTextEl.style.display = 'none';
        buttonEl[0].textContent = 'More';
    }
}
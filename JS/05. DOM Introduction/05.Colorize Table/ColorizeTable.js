function colorize() {
    const evenRowEls = document.querySelectorAll('table tr:nth-child(2n)');

    for (const el of evenRowEls) {
        el.style.backgroundColor = 'teal'
    }
}
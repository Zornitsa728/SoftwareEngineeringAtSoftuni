function attachGradientEvents() {
    const gradientElement = document.getElementById('gradient');
    const resultElement = document.getElementById('result');

    gradientElement.addEventListener('mousemove', (event) => {
        const currWidth = event.offsetX;
        console.log(currWidth);
        const elementWidth = event.target.clientWidth;
        const progress = Math.floor((currWidth/elementWidth) * 100);
        
        resultElement.textContent = `${progress}%`;
    });
}
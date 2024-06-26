function solve() {
    const outputEl = document.getElementById('output');
    const textAreaEl = document.getElementById('input');
    const text = textAreaEl.value;

    const result = text
        .split('.')
        .filter(sentance => sentance)
        .reduce((result, sentance, i) => {
            const resultIndex = Math.floor(i / 3);
            if (!result[resultIndex]) {
                result[resultIndex] = [];
            }

            result[resultIndex].push(sentance.trim());

            return result;
        }, [])
        .map(sentances => `<p>${sentances.join('. ')}.</p>`)
        .join('\n');


        outputEl.innerHTML = result;
    }

//   const result = text
//   .split('.')
//   .map(sentance => {
//     const pEl = document.createElement('p');
//     pEl.textContent = sentance

//     return pEl;
//   });

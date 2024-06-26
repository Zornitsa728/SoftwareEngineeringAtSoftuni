function RevealWords(words, text) {
    let wordsArray = words.split(', ');

    for (let i = 0; i < wordsArray.length; i++) {
        let currWord = '*'.repeat(wordsArray[i].length);
        text = text.replace(currWord, wordsArray[i])
    }

    console.log(text);
}

RevealWords('great, learning',
    'softuni is ***** place for ******** new programming languages'
);
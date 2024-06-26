function CensoredWords(text, word) {
    let stars = '*'.repeat(word.length);
    
    let newText = text.replace(word, stars);

    while (newText.includes(word)) {
        newText = newText.replace(word, stars);
    }

    console.log(newText);
}

CensoredWords('A small sentence with some words', 'small');
CensoredWords('Find the hidden word', 'hidden');
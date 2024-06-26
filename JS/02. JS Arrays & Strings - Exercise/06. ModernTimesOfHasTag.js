function FindHashWords(text) {
    let words = text.split(' ');
    let results = [];

    for (let i = 0; i < words.length; i++) {
        if (words[i].startsWith('#') && words[i].length > 1) {
            let currWord = words[i].substring(1, words[i].length);

            if (/^[a-zA-Z]+$/.test(currWord)) {
                results.push(currWord);
            }
        }
    }

    for (let result of results) {
        console.log(result);
    }
}

FindHashWords('Nowadays everyone uses # to tag a #special word in #socialMedia');
FindHashWords('The symbol # is known #variously in English-speaking #regions as the #number sign');

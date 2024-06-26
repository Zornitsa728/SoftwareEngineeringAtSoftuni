function CountOccurrences(text, word) {
    let words = text.split(' ');
    let count = 0;

    for (let index = 0; index < words.length; index++) {
        if (words[index] === word) {
            count++;
        }
    }

    console.log(count);
}

CountOccurrences('This is a word and it also is a sentence','is');
CountOccurrences('softuni is great place for learning new programming languages','softuni');
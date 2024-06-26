// function FindAMatch(word, text) {

//     let words = text.split(' ');

//     for (let i = 0; i < words.length; i++) {
//         if (words[i].toLowerCase() === word.toLowerCase()) {
//             return word;
//         }
//     }

//     return `${word} not found!`;

// }

function FindAMatch(word, text) {

    let words = text.toLowerCase().split(' ');


    if (words.includes(word.toLowerCase())) {
        return word;
    }

    return `${word} not found!`;

}

FindAMatch('python',
    'JavaScript is the best programming language'
); FindAMatch('javascript',
    'JavaScript is the best programming language'
);

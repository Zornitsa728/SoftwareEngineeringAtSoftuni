function solve(input) {
    let searchWords = input[0].split(' ');
    const otherWords = input.slice(1);
    let result = [];

    for (const searchWord of searchWords) {
        let currWord = otherWords.filter(otherWord => (otherWord == searchWord));
        let resultArr = [searchWord, currWord.length];
        result.push(resultArr);
    }

    // let sortedArray = Object.entries(result);

    result
        .sort((a, b) => b[1] - a[1])
        .forEach(arr => (console.log(`${arr[0]} - ${arr[1]}`)))
}

solve([
    'this sentence',
    'In', 'this', 'sentence', 'you', 'have', 'to', 'count', 'the', 'occurrences', 'of', 'the', 'words', 'this', 'and', 'sentence', 'because', 'this', 'is', 'your', 'task'
]
);

solve([
    'is the',
    'first', 'sentence', 'Here', 'is', 'another', 'the', 'And', 'finally', 'the', 'the', 'sentence']
);
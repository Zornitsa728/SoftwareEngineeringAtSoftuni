function nXnMatrix(number) {
    let rowMaker = number => new Array(number).fill(number);

    const currRow = rowMaker(number);

    currRow.forEach(row => console.log(currRow.join(' ')));
}

nXnMatrix(3);
console.log('----');
nXnMatrix(7);
console.log('----');
nXnMatrix(2);
function SortingNumbers(numbers) {
    numbers.sort((a, b) => a - b);

    let arrayLength = numbers.length;
    let result = [];

    for (let index = 0; index < arrayLength; index++) {
        if (index % 2 == 0) {
            result[index] = numbers.shift();
        } else {
            result[index] = numbers.pop();
        }

    }
    
    return result;
}

SortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);
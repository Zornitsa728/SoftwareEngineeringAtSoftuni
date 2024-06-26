function Rotation(numbers, rotationsCount) {
    for (let index = 0; index < rotationsCount; index++) {

        let firstEl = numbers[0];

        for (let index = 0; index < numbers.length - 1; index++) {

            numbers[index] = numbers[index + 1];
        }

        numbers[numbers.length - 1] = firstEl;
    }

    console.log(numbers.join(' '));
}

function quickSolve(arr, rotations) {
    for (let index = 0; index < rotations; index++) {
        arr.push(arr.shift());
    }
    console.log(arr.join(' '));
}

Rotation([51, 47, 32, 61, 21], 2);
Rotation([32, 21, 61, 1], 4);
quickSolve([51, 47, 32, 61, 21], 2);
quickSolve([32, 21, 61, 1], 4);
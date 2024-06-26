// function oddAndEvenSum(number) {
//     let numberToString = number.toString();
//     let sumEven = num => num % 2 == 0;
//     evenSum = 0;
//     let oddSum = 0;

//     for (let i = 0; i < numberToString.length ; i++) {
//         let digit = parseInt(numberToString[i]);

//         if (sumEven(digit)) {
//             evenSum += digit;
//         } else {
//             oddSum += digit;
//         }
//     }

//     console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
// }

// oddAndEvenSum(3495892137259234);

function calculateDigitSum(number, filter) {
    
    //get digit array
    const digits = number
    .toString()
    .split('')
    .map(Number)
    .filter(filter);

    // calculate sum
    const sum = digits.reduce((acc, digit) => acc + digit, 0);

    return sum;
}

function solve(number) {
    const evenSum = calculateDigitSum(number, (d => d % 2 === 0));
    const oddSum = calculateDigitSum(number, (d => d % 2 !== 0));

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}

solve(3495892137259234);
function findLargestNum(firstNum, secondNum, thirdNum) {
    let largestNum = firstNum;

    if (secondNum > largestNum) {
        largestNum = secondNum;
    }

    if (thirdNum > largestNum) {
        largestNum = thirdNum;
    }

    console.log(`The largest number is ${largestNum}.`);
}

findLargestNum(-3, -5, -22.5);
function mathOperations (firstNum, secondNum, sign){
    let result = null;

    if (sign === '+') {
        result = firstNum + secondNum;
    } else if (sign === '-') {
        result = firstNum - secondNum;
    } else if (sign === '*') {
        result = firstNum * secondNum;
    } else if (sign === '/') {
        result = firstNum / secondNum;
    } else if (sign === '%') {
        result = firstNum % secondNum;
    } else if (sign === '**') {
        result = firstNum ** secondNum;
    }

    console.log(result);
}

mathOperations(3, 5.5, '*');
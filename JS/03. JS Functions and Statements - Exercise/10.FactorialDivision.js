function solve(firstNum, secondNum) {
    let firstFactorial = getFactorial(firstNum);
    let secondFactorial = getFactorial(secondNum);

    function getFactorial(num) {
        let factorial = 1;
        for (let i = 1; i <= num; i++) {
            factorial *= i;
        }
        return factorial;
    }

    let result = firstFactorial / secondFactorial;

    console.log(result.toFixed(2));
}

solve(5, 2);
solve(6, 2);

function fancySolve(a, b) {
    const result = calculateFactorial(a) / calculateFactorial(b);

    console.log(result.toFixed(2));
}

function calculateFactorial(num) {
    if (num <= 1) {
        return 1;
    }

    return num * calculateFactorial(num - 1);
}

fancySolve(5, 2);
fancySolve(6, 2);
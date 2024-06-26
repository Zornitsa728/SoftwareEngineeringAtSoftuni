function printResult(a, b, c) {
    function sum (a, b) {
         return a + b;
    } 

    function subtract (sum, c){
        return sum - c;
    }

    let result = subtract(sum(a,b), c);

    console.log(result);
}

printResult (23, 6, 10);
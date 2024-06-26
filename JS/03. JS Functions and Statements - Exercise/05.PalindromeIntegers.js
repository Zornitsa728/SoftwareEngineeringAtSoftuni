function solve(numbers) {
    for (let i = 0; i < numbers.length; i++) {
        if (numbers[i] === reverseNumberDigits(numbers[i])) {
            console.log('true');
        } else {
            console.log('false');
        }
    }

    function reverseNumberDigits(number) {
        // Convert the number to a string
        let numberStr = number.toString();
        
        // Reverse the string
        let reversedNumberStr = numberStr.split('').reverse().join('');
        
        // Convert the reversed string back to a number
        let reversedNumber = parseInt(reversedNumberStr);
        
        return reversedNumber;
      }
}

solve([123,323,421,121]);
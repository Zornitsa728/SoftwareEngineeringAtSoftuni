function sameNumbersCheck(number) {
    let check = true;
    let sum = 0;

    while(number !== 0) {

        let currDigit = number % 10;
        sum += currDigit;

        // Convert number to string
        let numberAsString = number.toString();

        // Remove last character
        let newNumberAsString = numberAsString.slice(0, -1);

        if (newNumberAsString === '') {
            number = 0;
            break;
        }
        else {
            // Convert back to number
            number = parseInt(newNumberAsString);
        }

        if (currDigit !== number % 10) {
            check = false;
        }
    }

    if (check) {
        console.log(`true`);
    } else {
        console.log('false');
    }
    console.log(sum);
}

sameNumbersCheck(1234);
function sumDigits(number) {
    let result = 0;

    while (number !== 0) {
        result += number % 10;

        number = Math.trunc(number/10);
    }

    console.log(result);
}

sumDigits(245678);
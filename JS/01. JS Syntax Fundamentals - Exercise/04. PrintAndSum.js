function printAndSum(startNum, endNum) {
    let sum = null;
    let result = '';

    for (let index = startNum; index <= endNum; index++) {
        sum += index;
        result += index + ' ';
    }

    console.log(result);
    console.log(`Sum: ${sum}`);
}

printAndSum(0,26);
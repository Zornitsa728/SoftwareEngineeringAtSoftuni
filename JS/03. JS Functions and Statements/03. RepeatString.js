function Repeat(text, number){
    let result = '';
    for (i = 0; i < number; i++){
        result += text;
    }

    return result;
}

function PrintResult(text, number){
    console.log(Repeat(text, number));
}

PrintResult('abc', 3);
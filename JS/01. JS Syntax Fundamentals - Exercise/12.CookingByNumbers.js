function mathOperations(num, op1, op2, op3, op4, op5) {
    let number = parseInt(num);
    let operations = op1[0] + op2[0] + op3[0] + op4[0] + op5[0];

    for (let index = 0; index < operations.length; index++) {

        switch (operations[index]) {
            case 'c':
                number /= 2;
                break;
            case 'd':
                number = Math.sqrt(number);
                break;
            case 's':
                number += 1;
                break;
            case 'b':
                number *= 3;
                break;
            case 'f':
                number -= number * 0.2;
                break;
        }
            console.log(number);  
    }
} 

mathOperations('9', 'dice', 'spice', 'chop', 'bake', 'fillet');


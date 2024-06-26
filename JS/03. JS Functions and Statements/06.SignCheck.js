function solve (numOne, numTwo, numThree){
    const result = signCheck(numOne, numTwo, numThree);
    let currSign = '';

    if (result == 1) {
        currSign = 'Negative';
    } else {
        currSign = 'Positive';
    }
    
    console.log(currSign);

    function signCheck(numOne,numTwo,numThree) {
        let sign = 0;
    
        if (numOne < 0) {
            sign++;
        }
    
        if (numTwo < 0) {
            sign++;
        }
    
        if (numThree < 0) {
            sign++;
        }
    
        if (sign == 1 || sign == 3) {
            return 1;
        }
    
        return 0;
    }
}


solve( 5,
    12,
   -15
   );

   solve( -6,
    -12,
     14    
   );
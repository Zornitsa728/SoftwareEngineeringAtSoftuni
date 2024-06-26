function calculator(a, b, operator) {
   const operation = getOperation(operator);

   const result = operation(a,b);

   console.log(result);

   function getOperation(operator) {
    switch (operator) {
        case 'multiply':
            return (a,b) => a * b;
        case 'divide':
            return (a,b) => a / b;
        case 'add':
            return (a,b) => a + b;
        case 'subtract':
            return (a,b) => a - b;
    }
}
}

calculator(5, 5, 'multiply'); 
function solve(password) {
    let lengthResult = lengthCheck(password);
    let lettersAndDigitsResult = onlyLettersAndDigits(password);
    let atLeastTwoDigitsResult = atLeastTwoDigits(password);

    if (lengthResult && lettersAndDigitsResult && atLeastTwoDigitsResult) {
        console.log("Password is valid");
    }

    function lengthCheck(password) {
        if (password.length >= 6 && password.length <= 10) {
            return true;
        } else {
            console.log('Password must be between 6 and 10 characters');
            return false;
        }
    }

    function onlyLettersAndDigits(password) {
        if (/^[a-zA-Z0-9]+$/.test(password)) {
            return true;
        } else {
            console.log("Password must consist only of letters and digits");
            return false;
        }
    }

    function atLeastTwoDigits(password) {
        if (/[0-9]{2,}/.test(password)) {
            return true;
        } else {
            console.log("Password must have at least 2 digits");
            return false;
        }
    }
}


function fancySolve(password) {
    const isValidLength = password => password.length >= 6 && password.length <= 10;
    const isAlphaNumerical = password => /^[a-zA-Z0-9]+$/.test(password);
    const isStrong = password => /[0-9]{2,}/.test(password);

    const validations = [
        [isValidLength, 'Password must be between 6 and 10 characters'],
        [isAlphaNumerical, 'Password must consist only of letters and digits'],
        [isStrong, 'Password must have at least 2 digits']
    ];

    const result = validations
    .map(([validator, message]) => validator(password) ? '' : message)
    .filter(message => message);

    
    result.forEach(message => console.log(message));

    if (result.length < 1) {
        console.log("Password is valid");
    }
}

fancySolve('logIn');
console.log('-----');
fancySolve('MyPass123');
console.log('-----');
// solve('Pa$s$s');
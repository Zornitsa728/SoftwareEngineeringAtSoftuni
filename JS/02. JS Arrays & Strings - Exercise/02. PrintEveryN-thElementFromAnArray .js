function Solve(array, step) {
    let results = [];

    for (let index = 0; index < array.length; index+= step) {
        results.push(array[index]);
    }

    return results;
}

Solve(['5', 
'20', 
'31', 
'4', 
'20'], 
2
);

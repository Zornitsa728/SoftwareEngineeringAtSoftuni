function solve(tokens) {
    const townsInfo = [];

    for (const townInfo of tokens) {
        const [townName, latitude, longitude] = townInfo.split(' | ');

        const currTown = {
            town: townName,
            latitude: Number(latitude).toFixed(2),
            longitude: Number(longitude).toFixed(2),
        };

        townsInfo.push(currTown);
    }

    for (const town of townsInfo) {
        console.log(town)
    }
}

solve(['Sofia | 42.696552 | 23.32601',
    'Beijing | 39.913818 | 116.363625']
);

function fancySolve(tokens) {
    tokens
        .map(row => row.split(' | '))
        .map(([townName, latitude, longitude]) => ({
            town: townName,
            latitude: Number(latitude).toFixed(2),
            longitude: Number(longitude).toFixed(2),
        }))
        .forEach(el => console.log(el));
}

fancySolve(['Sofia | 42.696552 | 23.32601',
    'Beijing | 39.913818 | 116.363625']
);
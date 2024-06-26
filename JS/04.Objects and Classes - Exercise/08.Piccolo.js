function setSolve(input) {
    const parking = new Set();

    for (const row of input) {
        const [direction, carNumber] = row.split(', ');

        direction === 'IN'
            ? parking.add(carNumber)
            : parking.delete(carNumber)
    }

    if (parking.size < 1) {
        console.log("Parking Lot is Empty");
    } else {
        Array.from(parking.values())
            .sort((a, b) => a.localeCompare(b))
            .forEach(car => console.log(car));
    }
}

setSolve(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU']
);

setSolve(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'OUT, CA1234TA']
);
function cityInfo(data) {
    for (const city in data) {
        console.log(`${city} -> ${data[city]}`);
    }
}

// function cityInfo(data) {
//     let keys = Object.keys(data);
//     let values = Object.values(data);

//     for (let i = 0; i < keys.length; i++) {
//         console.log(`${keys[i]} -> ${values[i]}`);
//     }
// }

// function cityInfo(data) {
//     Object
//     .keys(data)
//     .forEach(propName => console.log(`${propName} -> ${data[propName]}`));
// }

cityInfo({
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: "Bulgaria",
    postCode: "1000"
}
);
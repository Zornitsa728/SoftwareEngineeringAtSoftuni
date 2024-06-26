function convertToObject(tokens) {
    let obj = JSON.parse(tokens);

    Object
   .keys(obj)
   .forEach(key => console.log(`${key}: ${obj[key]}`));
}

convertToObject('{"name": "George", "age": 40, "town": "Sofia"}');
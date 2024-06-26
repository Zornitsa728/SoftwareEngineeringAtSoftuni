function solve(input) {
    let dictionary = [];

    for (const row of input) {
        let word = JSON.parse(row);
        let entries = Object.entries(word);

        for (let [key, value] of entries) {
            let currWord = dictionary.find(dictionary => dictionary.Term === key);

            if (currWord) {
                currWord.Definition = value;
            } else {
                let obj = { Term: key, Definition: value };
                dictionary.push(obj);
            }
        }
    }

    dictionary
    .sort((a, b) => a.Term.localeCompare(b.Term));


    for (const word of dictionary) {
        console.log(`Term: ${word.Term} => Definition: ${word.Definition}`);
    }

}

solve([
    '{"Coffee":"A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub."}',
    '{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare."}',
    '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
    '{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',
    '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}'
]
);


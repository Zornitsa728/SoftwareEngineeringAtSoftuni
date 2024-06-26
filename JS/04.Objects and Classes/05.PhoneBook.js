function phoneBook(tokens) {

    let assocArr = {};

    for (const info of tokens) {
        let currPerson = info.split(' ');
        assocArr[currPerson[0]] = currPerson[1];
    }
    
    for (const person in assocArr) {
        console.log(`${person} -> ${assocArr[person]}`)
    }
}

phoneBook(['Tim 0834212554',
    'Peter 0877547887',
    'Bill 0896543112',
    'Tim 0876566344']
);

phoneBook(['George 0552554',
'Peter 087587',
'George 0453112',
'Bill 0845344']
);
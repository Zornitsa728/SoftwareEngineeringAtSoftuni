function addressBook(tokens) {
    let book = {};

    for (const info of tokens) {
        let currInfo = info.split(':');

        book[currInfo[0]] = currInfo[1];
    }

    //sort an object 
    let sortedArray = Object
    .entries(book)
    .sort((a,b) => a[0].localeCompare(b[0]));

    book = Object.fromEntries(sortedArray);

    for (const adress in book) {
        console.log(`${adress} -> ${book[adress]}`)
    }
}

addressBook(['Tim:Doe Crossing',
'Bill:Nelson Place',
'Peter:Carlyle Ave',
'Bill:Ornery Rd']
);
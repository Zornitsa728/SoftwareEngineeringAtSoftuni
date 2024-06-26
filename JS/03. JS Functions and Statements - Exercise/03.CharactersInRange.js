function charRange(a, b) {
    let char = a;
    let startIndex = char.charCodeAt(0);

    char = b;
    let endIndex = char.charCodeAt(0);
    
    if (startIndex > endIndex) {
        endIndex = startIndex;
        startIndex = char.charCodeAt(0);
    }

    function getCharsBetween(startIndex, endIndex) {
        let chars = [];
        
        for (let i = startIndex + 1; i < endIndex; i++) {
            chars.push(String.fromCharCode(i));
        }
        
        return chars;
    }
    
    let result = getCharsBetween(startIndex,endIndex);

    console.log(result.join(' '));
}

charRange('a', 'd');

charRange('#', ':');

charRange('C', '#');
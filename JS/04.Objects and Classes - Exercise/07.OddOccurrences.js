function solve(input) {
    let words = input.toLowerCase().split(' ');
    let result = [];

    for (const word of words) {
        let currWord = words.filter(currWord => currWord == word);
        if (currWord.length % 2 != 0 && !result.includes(word)) {
            result.push(word);
        }
    }

    console.log(result.join(' '));
}

solve('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');
solve('Cake IS SWEET is Soft CAKE sweet Food');
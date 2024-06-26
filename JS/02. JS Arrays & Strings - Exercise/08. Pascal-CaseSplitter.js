function SplittByUpperCase(text) {
    let words = text.split(/(?=[A-Z])/);

    console.log(words.join(', '));
}

SplittByUpperCase('SplitMeIfYouCanHaHaYouCantOrYouCan');
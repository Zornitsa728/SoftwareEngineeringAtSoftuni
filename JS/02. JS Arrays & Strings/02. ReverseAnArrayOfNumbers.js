function ReverseArray(num, array) {
    let newArray = array.slice(0, num);
    newArray.reverse();
    console.log(newArray.join(' '));
}

ReverseArray(3, [10, 20, 30, 40, 50]);
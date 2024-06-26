function solve() {
  const text = document.getElementById('text').value.toLowerCase();
  const namingConv = document.getElementById('naming-convention').value;
  const result = document.getElementById('result');

  // const convertToPascalCase = (text) =>
  // text
  // .split(' ')
  // .map(word => word.charaAt(0).toUpperCase() + word.slice(1))
  // .join('');

  // const convertor = {
  //   'Pascal Case': convertToPascalCase,
  //   'Camel Case': (text) => convertToPascalCase(text).charAt(0).toLowerCase() + convertToPascalCase(text).slice(1),
  // }

  let textArray = Array.from(text.split(' '));
  let resultArray = [];
  let isAnotherCase = false;

  if (namingConv == 'Camel Case') {
    let count = 0;
    resultArray.push(textArray[0]);

    for (let el of textArray) {
      if (count++ > 0) {
        let firstLetter = el[0].toUpperCase();
        resultArray.push(firstLetter + el.slice(1));
      }
    }
  } else if (namingConv == 'Pascal Case') {
    for (let el of textArray) {
      let firstLetter = el[0].toUpperCase();
      resultArray.push(firstLetter + el.slice(1));
    }
  } else {
    isAnotherCase = true;
  }

  if (isAnotherCase) {
    result.textContent = 'Error!';
  } else {
    result.textContent = resultArray.join('');
  }
}

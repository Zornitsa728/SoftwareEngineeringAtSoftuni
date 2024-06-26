function fruitPriceCalc(type, weight, price) {
    weight /= 1000;
    let money = weight * price;

    console.log(`I need $${money.toFixed(2)} to buy ${weight.toFixed(2)} kilograms ${type}.`);
}

fruitPriceCalc('orange', 1563, 2.35);
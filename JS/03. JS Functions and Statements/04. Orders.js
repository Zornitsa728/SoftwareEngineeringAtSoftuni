function ProductPrice(product) {
    let price = 0;

    if (product === 'coffee'){
        price = 1.5;
    } else if (product === 'water'){
        price = 1;
    } else if (product === 'coke'){
        price = 1.4;
    } else if (product === 'snacks'){
        price = 2;
    }

    return price;
}

function TotalPrice(product, quantity){
    let finalPrice = ProductPrice(product) * quantity;
    console.log(finalPrice.toFixed(2));
}

TotalPrice('water', 5);

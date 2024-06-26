function storeProvision(products, orderedProducts) {
    const allProducts = {};

    for (let i = 0; i < products.length; i += 2) {
        const product = products[i];
        const quantity = Number(products[i + 1]);

        allProducts[product] = quantity;
    }

    for (let i = 0; i < orderedProducts.length; i += 2) {
        const product = orderedProducts[i];
        const quantity = Number(orderedProducts[i + 1]);

        if (allProducts[product]) {
            allProducts[product] += quantity;
        } else {
            allProducts[product] = quantity;
        }
    }

    for (const currProduct in allProducts) {
        console.log(`${currProduct} -> ${allProducts[currProduct]}`);
    }
}

storeProvision([
    'Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'
],
    [
        'Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'
    ]
);
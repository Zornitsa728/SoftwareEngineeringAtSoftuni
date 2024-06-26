function priceForVacantion(count, type, day){
    let result = null;

    if (type === 'Students') {
        if (day === 'Friday') {
            result = count * 8.45;
        } else if (day === 'Saturday') {
            result = count * 9.80;
        } else if ( day === 'Sunday'){
            result = count * 10.46;
        }

        if(count >= 30){
            result -= result * 15/100;
        }
    } else if (type === 'Business') {
        if(count >= 100){
            count -= 10;
        }

        if (day === 'Friday') {
            result = count * 10.90;
        } else if (day === 'Saturday') {
            result = count * 15.60;
        } else if ( day === 'Sunday'){
            result = count * 16;
        }

    } else if (type === 'Regular') {
        if (day === 'Friday') {
            result = count * 15;
        } else if (day === 'Saturday') {
            result = count * 20;
        } else if ( day === 'Sunday'){
            result = count * 22.50;
        }

        if(count >= 10 && count <= 20){
            result -= result * 5/100;
        }
    }

    console.log(`Total price: ${result.toFixed(2)}`);
}

priceForVacantion(40, 'Regular', 'Saturday');
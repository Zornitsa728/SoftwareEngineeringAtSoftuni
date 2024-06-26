function solve(input) {
    const baristaCount = Number(input.shift());
    const team = {};

    for (let i = 0; i < baristaCount; i++) {
        const [name, shift, coffeeTypes] = input[i].split(' ');

        team[name] = {
            shift,
            coffeeTypes: coffeeTypes.split(','),
        }
    }

    let cmds = input.splice(0, baristaCount);

    let line = null;

    while ((line = input.shift()) != 'Closed') {
        const cmds = line.split(' / ');
        const currCmd = cmds.shift();

        if (currCmd === 'Prepare') {
            const barista = cmds.shift();
            const shift = cmds.shift();
            const coffeeType = cmds.shift();

            if (team[barista]) {
                if (team[barista].shift === shift && team[barista].coffeeTypes.includes(coffeeType)) {
                    console.log(`${barista} has prepared a ${coffeeType} for you!`);
                    continue;
                }
            }

            console.log(`${barista} is not available to prepare a ${coffeeType}.`);

        } else if (currCmd === 'Change Shift') {
            const barista = cmds.shift();
            const newShift = cmds.shift();

            team[barista].shift = newShift;

            console.log(`${barista} has updated his shift to: ${newShift}`);

        } else if (currCmd === 'Learn') {
            const barista = cmds.shift();
            const newCoffeeType = cmds.shift();

            if (team[barista].coffeeTypes.includes(newCoffeeType)) {
                console.log(`${barista} knows how to make ${newCoffeeType}.`);
            } else {
                team[barista].coffeeTypes.push(newCoffeeType);
                console.log(`${barista} has learned a new coffee type: ${newCoffeeType}.`);
            }
        }
    }

    for (const barista in team) {
        console.log(`Barista: ${barista}, Shift: ${team[barista].shift}, Drinks: ${team[barista].coffeeTypes.join(', ')}`);
    }
}

solve([
    '3',
    'Alice day Espresso,Cappuccino',
    'Bob night Latte,Mocha',
    'Carol day Americano,Mocha',
    'Prepare / Alice / day / Espresso',
    'Change Shift / Bob / night',
    'Learn / Carol / Latte',
    'Learn / Bob / Latte',
    'Prepare / Bob / night / Latte',
    'Closed']
);
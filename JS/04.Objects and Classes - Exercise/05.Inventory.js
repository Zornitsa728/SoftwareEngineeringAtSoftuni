function solve(input) {
    const heroesRegister = [];

    for (const row of input) {
        const [heroName, heroLevel, ...items] = row.split(' / ').filter(item => item !== '');
        const heroInfo = {
            name: heroName,
            level: Number(heroLevel),
            items,
        };

        heroesRegister.push(heroInfo);

    }

    heroesRegister
        .sort((a, b) => a.level - b.level)
        .forEach(hero => {
            console.log(`Hero: ${hero.name}`)
            console.log(`level => ${hero.level}`)
            console.log(`items => ${hero.items.join(', ')}`)
        });
}

solve([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
]
);
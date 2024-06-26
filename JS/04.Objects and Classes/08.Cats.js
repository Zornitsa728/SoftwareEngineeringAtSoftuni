function createCats(tokens) {
    let allCats = [];

    class Cat {
        constructor(name, age) {
            this.name = name;
            this.age = age;
        }

        meow() {
            console.log(`${this.name}, age ${this.age} says Meow`)
        }
    }

    for (const currCat of tokens) {
        let newCat = currCat.split(' ');
        allCats.push(new Cat(newCat[0], Number(newCat[1])));
    }

    allCats.forEach(cat => {
        cat.meow();
    });
}

createCats(['Mellow 2', 'Tom 5']);
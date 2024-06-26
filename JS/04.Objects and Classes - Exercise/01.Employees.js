// function solve(names) {
//     const employees = {};

//     for (const name of names) {
//         employees[name] = name.length
//     }

//     for (const employee in employees) {
//         console.log(`Name: ${employee} -- Personal Number: ${employees[employee]}`);
//     }
// }

function fancySolve(names) {
    const employees = [];

    for (const name of names) {
        const employee = {
            name,
            personalNumber: name.length,
        }

        employees.push(employee);
    }

    for (const employee of employees) {
        console.log(`Name: ${employee.name} -- Personal Number: ${employee.personalNumber}`);
    }
}

fancySolve([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
]
);
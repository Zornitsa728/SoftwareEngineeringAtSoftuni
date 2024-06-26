function personInfo(firstName, lastName, age) {
    let personInfo = {};
    // personInfo = {
    //     firstName: firstName,
    //     lastName: lastName,
    //     age: age,
    // };

    personInfo = {
        firstName,
        lastName,
        age,
    };

    return personInfo;
}

personInfo("Peter", 
"Pan",
"20"
);
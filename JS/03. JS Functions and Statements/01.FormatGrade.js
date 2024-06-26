function FormatGrade(grade) {
    let description = '';

    if (grade < 3) {
        return `Fail (2)`;
    } else if (grade < 3.5) {
        description = 'Poor';
    } else if (grade < 4.5) {
        description = 'Good';
    } else if (grade < 5.5) {
        description = 'Very good';
    } else {
        description = 'Excellent';
    }

    console.log(`${description} (${grade.toFixed(2)})`);
}

FormatGrade(3.33);
FormatGrade(4.50);
FormatGrade(2.99);  

// function solve(num) {
//     let result = new Array(10).fill('.');
//     let count = num / 10;

//     if (count === 10) {
//         console.log('100% Complete!');
//         result = result.fill('%');
//         console.log(`[${result.join('')}]`);
//     } else {
//         for (let i = 0; i < count; i++) {
//             result[i] = '%';
//         }
//         console.log(`${num}% [${result.join('')}]`);
//         console.log('Still loading...');
//     }
// }

function fancySolve(progress) {
    const renderProgressBar = progress => `[${'%'.repeat(progress / 10)}${'.'.repeat(10 - progress / 10)}]`;
    const renderProgress = progress => `${progress}% ${renderProgressBar(progress)}`;
    const isCompleted = progress != 100 ? 'Still loading...' : 'Complete!';

    console.log(renderProgress(progress));
    console.log(isCompleted);
}

fancySolve(30);
fancySolve(50);
fancySolve(100);
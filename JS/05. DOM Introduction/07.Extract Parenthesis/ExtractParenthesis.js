function extract(content) {
const contentElement = document.getElementById(content).textContent;

 const matches = contentElement.matchAll(/\(([^)]+)\)/g);

 let result = [];

for (const match of matches) {
        result.push(match[1]);
}

return result.join('; ')
}
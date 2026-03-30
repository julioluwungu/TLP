const arr = Array.from({ length: 12 }, () => Math.floor(Math.random() * 20) + 1);
const mySet = new Set(arr);

console.log(mySet);

let produto = 1

for (let c = 1; c <= 15; c++) {
    if (c % 2 !== 0) produto *= c
}

console.log(`O produto dos inteiros ímpares de 1 a 15 é: ${produto}`)
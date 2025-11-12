let soma = 0

for (let c = 1; c <= 500; c++) {
    if (c % 2 !== 0 && c % 3 === 0) {
        soma += c
    }
}

console.log(`A soma de todos os números ímpares múltiplos de três entre 1 e 500 é: ${soma}`)
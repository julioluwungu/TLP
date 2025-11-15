let soma = 0;

for (let num = 1; num <= 500; num++) {
    if (num % 2 !== 0 && num % 3 === 0) {
        soma += num
    }
}

console.log(`A soma dos números ímpares que são múltiplos de três de 1 até 500 é: ${soma}`)
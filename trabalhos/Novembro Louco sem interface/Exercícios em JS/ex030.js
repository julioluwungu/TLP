let soma = 0
console.log('Os números pares compreendidos entre 85 e 31 são:')

for (let num = 85; num >= 31; num--) {
    if (num % 2 === 0) {
        console.log(num)
        soma += num
    }
}

console.log(`E a sua soma deu: ${soma}`)
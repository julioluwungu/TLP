let multiplos5 = []
let fim = 10000

for (let num = 1; num <= fim; num++) {
    if (num % 5 === 0) multiplos5.push(num)
}

let percentual5 = (multiplos5.length * 100) / fim
console.log(`No intervalo de 1 à 10.000 foram encontrados ${multiplos5.length} múltiplos de 5.`)
console.log(`O percentual de 5 é de ${percentual5.toFixed(1)}%`)
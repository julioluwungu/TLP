let primeiroTermo = 3
let razao = 3
let termos = []
let termoAtual = primeiroTermo
let soma = 0

while (termoAtual <= 6561) {
    termos.push(termoAtual)
    soma += termoAtual
    termoAtual *= razao
}

console.log(`Termos da PG: ${termos.join(', ')}`)
console.log(`Soma dos termos: ${soma}`)
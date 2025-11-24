let populacaoA = 80000
let taxaCrescimentoA = 0.03

let populacaoB = 200000
let taxaCrescimentoB = 0.015

let anos = 0

while (populacaoA < populacaoB) {
    populacaoA += (populacaoA * taxaCrescimentoA)
    populacaoB += (populacaoB * taxaCrescimentoB)
    anos++
}

console.log(`Anos necessários para a população A ultrapassar a população B: ${anos}`)
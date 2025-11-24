let alturaChico = 1.50
let alturaZe = 1.10
let crescimentoChico = 0.02
let crescimentoZe = 0.03
let anos = 0

while (alturaZe <= alturaChico) {
    alturaChico += crescimentoChico
    alturaZe += crescimentoZe
    anos++
}

console.log(`Serão necessários ${anos} anos para que Zé seja maior que Chico.`)
prompt.close()
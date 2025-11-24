let graos = 0
let total = 0

for (let quadro = 1; quadro <= 64; quadro++) {
    if (quadro == 1) graos = 1
    else graos *= 2

    total += graos
}

console.log(`O Monge recebeu um total de ${total} grãos.`)
import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(Number(resposta)))
    })
}

async function principal() {
    let numero

    while (true) {
        numero = Number(await pegarResposta('Digite um número: '))

        if (!isNaN(numero)) break
        else console.log('Valor inválido! Por favor, digite um número válido.')
    }

    let triangular = false

    for (let x = 1; x < Math.cbrt(numero) + 1; x++) {
        let produto = x * (x + 1) * (x + 2)
        if (produto === numero) {
            triangular = true
            console.log(`O número ${numero} é um número triangular: ${x} x ${x + 1} x ${x + 2} = ${produto}`)
            break
        }
    }

    if (!triangular) {
        console.log(`O número ${numero} não é um número triangular.`)
    }

    prompt.close()
}

principal()
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
        numero = Number(await pegarResposta(`Digite um número positivo: `))

        if (!isNaN(numero) && numero > 0) break
        else console.log('Valor inválido! Por favor, digite um número válido.')
    }

    console.log(`Contagem regressiva pulando de 2 em 2 começando de ${numero}:`)
    for (let c = numero; c >= 0; c -= 2) console.log(c)

    prompt.close()
}

principal()
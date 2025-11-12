import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(Number(resposta)))
    })
}

function ehPrimo(numero) {
    if (numero <= 1) return false
    for (let c = 2; c <= Math.sqrt(numero); c++) {
        if (numero % c === 0) return false
    }
    return true
}

async function principal() {
    let somaPares = 0
    let somaPrimos = 0

    for (let c = 0; c < 10; c++) {
        let numero

        while (true) {
            numero = Number(await pegarResposta(`Digite o ${c+1} número: `))

            if (!isNaN(numero)) break
            else console.log('Valor inválido! Por favor, digite um número válido.')
        }

        if (numero % 2 === 0) {
            somaPares += numero
        }

        if (ehPrimo(numero)) {
            somaPrimos += numero
        }
    }

    console.log(`Soma dos números pares: ${somaPares}`)
    console.log(`Soma dos números primos: ${somaPrimos}`)

    prompt.close()
}

principal()
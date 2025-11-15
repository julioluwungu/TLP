import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numero1
    let numero2

    while (true) {
        numero1 = parseInt(await pegarResposta("Digite o primeiro número inteiro positivo: "))
        numero2 = parseInt(await pegarResposta("Digite o segundo número inteiro positivo: "))
        if (!isNaN(numero1) && !isNaN(numero2) && numero1 > 0 && numero2 > 0) {
            break
        }
        console.log("Entrada inválida! Por favor, digite números inteiros válidos.")
    }

    let quociente = 0
    let resto = numero1

    while (resto >= numero2) {
        resto -= numero2
        quociente++
    }

    console.log(`Quociente: ${quociente}`)
    console.log(`Resto: ${resto}`)

    prompt.close()
}

principal()
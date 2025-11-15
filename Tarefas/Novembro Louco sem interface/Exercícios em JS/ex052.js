import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numero

    while (true) {
        numero = parseFloat(await pegarResposta("Digite um número: "))
        if (!isNaN(numero)) {
            break
        }
        console.log("Valor inválido! Por favor, digite um número válido.")
    }

    let contagem = 0
    let resultado = numero

    while (resultado >= 1) {
        resultado /= 2
        contagem++
    }

    console.log(`O resultado da última divisão é: ${resultado}`)
    console.log(`Quantidade de divisões efetuadas: ${contagem}`)

    prompt.close()
}

principal()
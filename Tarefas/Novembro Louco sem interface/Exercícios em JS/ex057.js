import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numN

    while (true) {
        numN = parseInt(await pegarResposta("Informe um número inteiro N: "))
        if (!isNaN(numN) && numN >= 0) {
            break
        }
        console.log("Valor inválido! Por favor, digite um número inteiro não negativo.")
    }

    let maiorQuadrado = (Math.floor(numN ** 0.5)) ** 2

    console.log(`O maior quadrado menor ou igual a ${numN} é: ${maiorQuadrado}`)
    prompt.close()
}

principal()
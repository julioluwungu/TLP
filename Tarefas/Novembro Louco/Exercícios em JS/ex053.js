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
        numN = parseInt(await pegarResposta("Informe um valor inteiro e positivo para N: "))
        if (!isNaN(numN) && numN >= 0) {
            break
        }
        console.log("Valor inválido! Por favor, digite um número inteiro positivo.")
    }

    let numE = 1
    let fatorial = 1

    for (let c = 1; c <= numN; c++) {
        fatorial *= c
        numE += 1 / fatorial
    }

    console.log(`O valor de E é: ${numE.toFixed(6)}`)
    prompt.close()
}

principal()
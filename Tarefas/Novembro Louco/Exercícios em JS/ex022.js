import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numQ = []

    for (let i = 0; i < 20; i++) {
        while (true) {
            let num = parseFloat(await pegarResposta(`Digite o ${i + 1}º valor (positivo): `))
            if (!isNaN(num) && num > 0) {
                numQ.push(num)
                break
            } else {
                console.log('Valor inválido! Por favor, digite um número positivo.')
            }
        }
    }

    let maiorElemento = numQ[0]
    let posicao = 0

    for (let i = 1; i < numQ.length; i++) {
        if (numQ[i] > maiorElemento) {
            maiorElemento = numQ[i]
            posicao = i
        }
    }

    console.log(`O maior elemento é ${maiorElemento} e ocupa a posição ${posicao + 1} no vetor.`)

    prompt.close()
}

principal()
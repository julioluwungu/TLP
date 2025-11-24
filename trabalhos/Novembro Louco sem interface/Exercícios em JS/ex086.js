import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let frase = await pegarResposta('Digite uma frase: ')

    let fraseDuplicada = frase.split('').map(letra => {
        if (letra !== ' ') return letra.repeat(2)
        else return letra
    }).join('')

    console.log(`Frase gerada: ${fraseDuplicada}`)
    prompt.close()
}

principal()
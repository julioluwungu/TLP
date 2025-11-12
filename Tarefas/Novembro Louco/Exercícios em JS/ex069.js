import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let nome = await pegarResposta('Digite seu nome: ')

    let nomeInvertido = nome.split('').reverse().join('').toUpperCase()

    console.log(`Seu nome ao contrário é: ${nomeInvertido}`)
    prompt.close()
}

principal()
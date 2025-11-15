import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let nomeCompleto = await pegarResposta(`Digite o seu nome completo: `)
    prompt.close()

    let listaNomes = nomeCompleto.split(' ')

    let nomesAbbr = listaNomes.map(nome => {
        if (nome.length > 2) {
            return `${nome[0].toUpperCase()}.`
        }
        return nome
    })

    console.log(`Abreviação: ${nomesAbbr.join(' ')}`)
}

principal()
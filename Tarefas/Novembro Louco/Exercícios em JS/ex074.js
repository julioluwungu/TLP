import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let frase = await pegarResposta('Digite uma frase: ')

    let espacos = (frase.match(/ /g) || []).length

    console.log(`Número de espaços em branco: ${espacos}`)
    prompt.close()
}

principal()
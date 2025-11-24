import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let nomesInput = await pegarResposta(`Digite uma lista de nomes separados por vírgula: `)
    prompt.close()

    let listaNomes = nomesInput.split(',').map(nome => nome.trim())
    listaNomes.sort()

    console.log(`Lista de nomes em ordem alfabética: ${listaNomes.join(', ')}`)
}

principal()
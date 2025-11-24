import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

function substituirEspacos(frase) {
    return frase.replaceAll(' ', '#')
}

async function principal() {
    let frase = await pegarResposta('Digite uma frase: ')

    let fraseAlterada = substituirEspacos(frase)
    console.log(`Frase alterada: ${fraseAlterada}`)

    prompt.close()
}

principal()
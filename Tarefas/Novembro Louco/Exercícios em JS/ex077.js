import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

function contarPalavras(frase) {
    let palavras = frase.trim().split(/\s+/)
    
    return palavras.length === 1 && palavras[0] === "" ? 0 : palavras.length
}

async function principal() {
    let frase = await pegarResposta('Digite uma frase: ')

    let numeroDePalavras = contarPalavras(frase)
    console.log(`Número de palavras: ${numeroDePalavras}`)

    prompt.close()
}

principal()
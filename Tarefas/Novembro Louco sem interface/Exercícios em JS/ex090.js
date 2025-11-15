import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let frase = await pegarResposta('Digite uma frase: ')

    let fraseModificada = frase.split('').map(letra => {
        if ('aeiouAEIOU'.includes(letra)) return '!'
        else return letra
    }).join('').toUpperCase()
    
    console.log(`Frase transformada: ${fraseModificada}`)
    prompt.close()
}

principal()
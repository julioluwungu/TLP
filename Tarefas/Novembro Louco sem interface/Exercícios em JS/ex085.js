import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let frase = await pegarResposta('Digite uma frase: ')
    
    let fraseRepetida = frase.split(' ').map(palavra => `${palavra} ${palavra}`).join(' ')

    console.log(`Saída: ${fraseRepetida}`)
    prompt.close()
}

principal()
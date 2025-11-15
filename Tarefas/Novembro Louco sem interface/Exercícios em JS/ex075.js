import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    while (true) {
        let palavra = await pegarResposta('Digite uma palavra (ou uma palavra que comece com "f" para terminar): ')

        let primeiraLetra = palavra.charAt(0)
        let ultimaLetra = palavra.charAt(palavra.length - 1)
        console.log(`${palavra}: ${primeiraLetra}-${ultimaLetra}`)

        if (primeiraLetra.toLowerCase() === 'f') break
    }
    
    prompt.close()
}

principal()
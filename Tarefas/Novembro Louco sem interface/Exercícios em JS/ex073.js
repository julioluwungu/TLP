import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let nomeCompleto = await pegarResposta('Digite seu nome completo: ')
    
    let partes = nomeCompleto.trim().split(/\s+/)

    if (partes.length > 1) {
        let sobrenome = partes.at(-1)
        console.log(`Sobrenome: ${sobrenome}`)
    } else {
        console.log('Sobrenome não encontrado. Certifique-se de digitar um nome completo.')
    }
    
    prompt.close()
}

principal()
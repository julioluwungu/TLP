import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let texto = await pegarResposta('Digite uma frase ou uma palavra qualquer: ')
    
    let textoModificado = texto.replace(/[bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]/g, '&')

    console.log(`Consoantes substituídas por &: ${textoModificado}`)
    prompt.close()
}

principal()
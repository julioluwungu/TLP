import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let verbo

    while (true) {
        verbo = (await pegarResposta('Digite um verbo regular terminado em ER: ')).toUpperCase()

        if (verbo.endsWith('ER')) break
        else console.log('Por favor, insira um verbo regular que termine em "ER".')
    }

    let radical = (verbo.slice(0, -2)).toLowerCase()

    console.log(`Conjugação do verbo "${verbo}" no presente:`)
    console.log(`Eu ${radical}o`)
    console.log(`Tu ${radical}es`)
    console.log(`Ele ${radical}e`)
    console.log(`Ela ${radical}e`)
    console.log(`Nós ${radical}emos`)
    console.log(`Vós ${radical}eis`)
    console.log(`Eles ${radical}em`)
    console.log(`Elas ${radical}em`)
    
    prompt.close()
}

principal()
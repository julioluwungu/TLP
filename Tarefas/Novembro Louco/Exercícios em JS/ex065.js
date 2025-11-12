import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let texto = await pegarResposta('Digite uma frase ou uma palavra qualquer: ')
    let vetorTxt = texto.split(' ')
    let listaAsteriscos = vetorTxt.map(palavra => '*'.repeat(palavra.length))
    let textoAsteriscos = listaAsteriscos.join(' ')

    console.log(`Caracteres substituídos por asterisco: ${textoAsteriscos}`)
    prompt.close()
}

principal()
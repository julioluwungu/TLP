import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let texto = await pegarResposta('Digite um texto: ')
    let txt = texto

    let numeroCaracteres = txt.replace(/\s+/g, '').length
    let numeroPalavras = texto.trim().split(/\s+/).length

    console.log(`Número total de caracteres (sem espaços): ${numeroCaracteres}`)
    console.log(`Número total de palavras: ${numeroPalavras}`)
    prompt.close()
}

principal()
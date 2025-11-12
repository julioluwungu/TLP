import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let texto = await pegarResposta('Digite uma sequência de caracteres: ')
    
    let textoLimpo = texto.replace(/[\W_]/g, '').toLowerCase()
    let palindromo = textoLimpo === textoLimpo.split('').reverse().join('')

    console.log(`Frase: ${texto}`)
    console.log(`É um palíndromo? ${palindromo ? 'Sim' : 'Não'}`)
    prompt.close()
}

principal()
import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let conectores = ['e', 'do', 'da', 'dos', 'das', 'de', 'di', 'du']

    let nome = await pegarResposta('Digite o seu nome completo: ')
    let palavras = nome.split(' ')

    let iniciais = palavras.reduce((acc, palavra) => {
        if (!conectores.includes(palavra.toLowerCase())) {
            acc.push(palavra[0].toUpperCase())
        }
        return acc
    }, [])

    console.log(`As iniciais são: ${iniciais.join(', ')}`)
    prompt.close()
}

principal()
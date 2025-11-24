import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

function substituirUltimaOcorrencia(frase, palavraAntiga, palavraNova) {
    let ultimaOcorrencia = frase.lastIndexOf(palavraAntiga)

    if (ultimaOcorrencia === -1) {
        return frase
    }

    return frase.slice(0, ultimaOcorrencia) + palavraNova + frase.slice(ultimaOcorrencia + palavraAntiga.length)
}

async function principal() {
    let frase = await pegarResposta('Digite uma frase: ')
    let palavraAntiga = await pegarResposta('Digite a palavra antiga: ')
    let palavraNova = await pegarResposta('Digite a palavra nova: ')

    let resultado = substituirUltimaOcorrencia(frase, palavraAntiga, palavraNova)
    console.log(`Resultado: ${resultado}`)

    prompt.close()
}

principal()
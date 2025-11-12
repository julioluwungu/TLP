import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

class Frase {
    async principal() {
        let frase = await pegarResposta('Digite uma frase qualquer: ')
        let palavra

        while (true) {
            palavra = await pegarResposta('Digite uma palavra que exista na frase: ')
            if (frase.includes(palavra)) break
            else console.log('Digite uma palavra que exista na frase!')
        }
        
        let vetorFrase = frase.split(' ')
        let indice = vetorFrase.indexOf(palavra)

        console.log(`A palavra "${palavra}" encontra-se com o índice ${indice}`)
        prompt.close()
    }
}

let instanciaFrase = new Frase()
instanciaFrase.principal()
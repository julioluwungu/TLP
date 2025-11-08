import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let valorSorteado = Math.floor(Math.random() * 20) + 1
    let resposta
    do {
        resposta = Number(await pegarResposta('Tente adivinhar o número sorteado: '))
        if (resposta > valorSorteado) {
            console.log(`O valor ${resposta} é maior do que o valor sorteado`)
        } else if (resposta < valorSorteado) {
            console.log(`O valor ${resposta} é menor do que o valor sorteado.`)
        } else {
            console.log(`Parabéns você acertou! O valor sorteado era ${valorSorteado}`)
        }
    } while (resposta != valorSorteado)
    prompt.close()
}

principal()
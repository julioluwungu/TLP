import { createInterface } from "readline";

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    });
}

async function principal() {
    let pergunta = ''
    let valorSorteado
    let tempoSorteado = Math.floor(Math.random() * 10)

    setTimeout(() => {
        valorSorteado = Math.floor(Math.random() * 20)
        console.log(`Agora! Valor sorteado: ${valorSorteado}`)
        pergunta = 'Digite o valor que apareceu na tela: '
    }, tempoSorteado * 1000)

    let tempoInicial = new Date().getSeconds()
    let tempoFinal

    while (true) {
        if (!pergunta) {
            await new Promise(resolve => setTimeout(resolve, 100))
            continue
        }

        let num = parseInt(await pegarResposta(pergunta))
        if (!isNaN(num) && num === valorSorteado) {
            tempoFinal = new Date().getSeconds()
            break
        } else {
            console.log('Valor incorreto. Por favor, digite o valor correto!')
        }
    }
    prompt.close()

    let tempoFeito = tempoFinal - tempoInicial
    console.log(`Demorou ${tempoFeito} segundos para acertar.`)
}

principal()
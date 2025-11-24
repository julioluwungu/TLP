import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numero
    while (true) {
        numero = Number(await pegarResposta('Digite um número múltiplo de 10: '))
        if (numero % 10 == 0) break
        console.log('Valor Incorreto!')
    }
    prompt.close()

    let valorOriginal = numero
    let vetorQtd = []
    let notas = [100, 50, 20, 10]

    for (let nota of notas) {
        let qtd = Math.floor(numero / nota)
        vetorQtd.push(qtd)
        numero -= qtd * nota
    }

    console.log(`Com o valor ${valorOriginal} temos:`)

    for (let c in vetorQtd) console.log(`${vetorQtd[c]} nota(s) de ${notas[c]}`)
}

principal()
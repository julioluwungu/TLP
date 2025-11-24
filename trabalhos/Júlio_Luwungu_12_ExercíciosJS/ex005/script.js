import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

function parOuImpar(num) {
    if (num % 2 == 0) console.log(`${num} - PAR`)
    else console.log(`${num} - ÍMPAR`)
}

async function principal() {
    let inicio = Number(await pegarResposta('Digite o valor de início: '))
    let fim = Number(await pegarResposta('Digite o valor de fim: '))
    prompt.close()

    if (inicio < fim) {
        for (let c = inicio; c <= fim; c++) parOuImpar(c)
    } else {
        for (let c = inicio; c >= fim; c--) parOuImpar(c)
    }
}

principal()
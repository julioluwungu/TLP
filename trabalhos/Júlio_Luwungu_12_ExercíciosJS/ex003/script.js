import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal () {
    let vetor = []

    for (let c = 1; c <= 5; c++) {
        let res = Number(await pegarResposta(`Digite o ${c}º número: `))
        vetor.push(res)
    }
    prompt.close()

    let maior = vetor[0]
    let menor = vetor[0]

    for (let numero of vetor) {
        if (numero > maior) maior = numero
        else if (numero < menor) menor = numero
    }

    let crescente = [...vetor].sort((a, b) => a - b)
    let decrescente = [...vetor].sort((a, b) => b - a)

    console.log(`Ordem crescente: ${crescente}\nOrdem decrescente: ${decrescente}\nMaior valor: ${maior}\nMenor valor: ${menor}`)
}

principal()
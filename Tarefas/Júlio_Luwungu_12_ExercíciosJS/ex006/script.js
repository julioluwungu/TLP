import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let notas = []
    let soma = 0

    for (let c = 1; c <= 3; c++) {
        let nota = Number(await pegarResposta(`Digite a ${c}º nota: `))
        notas.push(nota)
        soma += nota
    }
    prompt.close()

    let media = soma / notas.length
    let classificacao = ''

    if (media < 5) classificacao = 'REPROVADO'
    else if (media < 7) classificacao = 'em RECUPERAÇÃO'
    else classificacao = 'APROVADO'

    console.log(`Com média ${media.toFixed(1)} o aluno está ${classificacao}!`)
}

principal()
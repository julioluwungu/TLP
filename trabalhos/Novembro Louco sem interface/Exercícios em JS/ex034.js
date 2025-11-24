import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let totalAlunos = 45
    let idades = []
    let alturas = []

    for (let i = 0; i < totalAlunos; i++) {
        let idade = parseInt(await pegarResposta(`Informe a idade do aluno ${i + 1}: `))
        let altura = parseFloat(await pegarResposta(`Informe a altura do aluno ${i + 1} em metros: `))

        if (altura < 1.70) {
            idades.push(idade)
        }

        if (idade > 20) {
            alturas.push(altura)
        }
    }

    let somaIdade = idades.reduce((ac, valor) => ac + valor)
    let somaAltura = alturas.reduce((ac, valor) => ac + valor)

    let idadeMedia = idades.length > 0 ? somaIdade / idades.length : 0
    let alturaMedia = alturas.length > 0 ? somaAltura / alturas.length : 0

    console.log(`A idade média dos alunos com menos de 1,70 m é: ${idadeMedia.toFixed(1)} anos`)
    console.log(`A altura média dos alunos com mais de 20 anos é: ${alturaMedia.toFixed(1)} metros`)

    prompt.close()
}

principal()
import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))

    })
}

async function principal() {
    let valores = []

    while (true) {
        let entrada = await pegarResposta('Digite um número (ou "sair" para encerrar): ')

        if (entrada.toLowerCase() === 'sair') {
            break
        }

        let numero = parseFloat(entrada)

        if (isNaN(numero)) {
            console.log("Valor inválido! Por favor, insira um número")
        } else {
            valores.push(numero)
        }

    }

    let soma = valores.reduce((ac, valor) => ac + valor)
    let media = valores.length > 0 ? soma / valores.length : 0
    let positivos = valores.filter(num => num > 0)
    let negativos = valores.filter(num => num < 0)

    let percentualPositivo = (positivos.length * 100) / valores.length
    let percentualNegativo = (negativos.length * 100) / valores.length

    console.log(`Média Aritmética: ${media.toFixed(1)}`)
    console.log(`Quantidade de Valores Positivos: ${positivos.length}`)
    console.log(`Quantidade de Valores Negativos: ${negativos.length}`)
    console.log(`Percentual de Valores Positivos: ${percentualPositivo.toFixed(1)}%`)
    console.log(`Percentual de Valores Negativos: ${percentualNegativo.toFixed(1)}%`)

    prompt.close()
}

principal()
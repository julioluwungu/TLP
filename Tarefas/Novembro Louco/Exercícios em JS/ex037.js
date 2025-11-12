import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numeros = []

    for (let c = 0; c < 10; c++) {
        while (true) {
            let numero = parseInt(await pegarResposta(`Digite o ${c + 1}º número inteiro: `))
            if (!isNaN(numero)) {
                numeros.push(numero)
                break
            }
            console.log("Valor inválido! Por favor, digite um valor inteiro válido.")
        }
    }

    let soma = numeros.reduce((ac, valor) => ac + valor)
    let media = soma / numeros.length
    let maior = Math.max(...numeros)
    let menor = Math.min(...numeros)

    console.log(`Média: ${media.toFixed(1)}`)
    console.log(`Maior número: ${maior}`)
    console.log(`Menor número: ${menor}`)

    prompt.close()
}

principal()
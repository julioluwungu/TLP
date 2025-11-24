import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numeros

    while (true) {
        let num = await pegarResposta(`Digite uma sequência de números: `)
        if (/^\d+$/.test(num)) {
            numeros = num
            break
        } else {
            console.log('Valor inválido! Por favor, digite um número válido!')
        }
    }
    prompt.close()

    let listaNum = Array.from(numeros, Number)
    let soma = listaNum.reduce((ac, valor) => ac + valor)

    console.log(`A soma dos números digitados é: ${soma}`)
}

principal()
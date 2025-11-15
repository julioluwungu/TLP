import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numeros = []
    let numero
    let c = 1

    while (true) {
        while (true) {
            numero = parseInt(await pegarResposta(`Digite o ${c}º número (9999 para encerrar): `))
            if (!isNaN(numero)) {
                break
            }
            console.log("Valor inválido! Por favor, digite um valor válido.")
        }
        if (numero !== 9999) numeros.push(numero)
        else break
        c++
    }

    let soma = 0
    let media = 0

    if (numeros.length > 0) {
        soma = numeros.reduce((ac, valor) => ac + valor)
        media = soma / numeros.length
    }


    console.log(`A soma dos números é de: ${soma}`)
    console.log(`A média dos números é de: ${media.toFixed(1)}`)

    prompt.close()
}

principal()
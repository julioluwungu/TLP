import { resolve } from "path"
import { createInterface } from "readline"

let prompt = createInterface ({input:process.stdin, output:process.stdout})
function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))

    })
}

async function principal() {
    let valores = []
    let c = 1
    while (true) {
        let num = parseInt(await pegarResposta(`Digite o ${c}º valor: `))
        if (!isNaN(num)) {
            c++
            if (num > 0) valores.push(num)
            else if (num < 0) break
        } else {
            console.log('Valor inválido! Por favor, digite um número válido!')
        }
    }
    prompt.close()

    let soma = valores.reduce((ac, valor) => ac + valor)
    let media = soma / valores.length
    console.log(`A média é de ${media.toFixed(1)}`)
}

principal()
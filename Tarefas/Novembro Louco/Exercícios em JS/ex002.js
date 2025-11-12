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
    for (let c = 0; c < 3; c++) {
        while (true) {
            let num = parseInt(await pegarResposta(`Digite o ${c+1}º valor inteiro: `))
            if (!isNaN(num)) {
                valores.push(num)
                break
            } else {
                console.log('Valor inválido! Por favor, digite um número válido!')
            }
        }
    }
    prompt.close()

    let soma = valores.reduce((ac, valor) => ac + valor)
    let media = soma / valores.length
    console.log(`A média é de ${media.toFixed(1)}`)
}

principal()
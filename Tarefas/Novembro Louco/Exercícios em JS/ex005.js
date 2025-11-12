import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let valores = []
    let strOperacoes = '+-*/'
    let operacao

    for (let c = 0; c < 3; c++) {
        if (c == 0) {
            while (true) {
                operacao = await pegarResposta(`Escolha uma operação (+, -, *, /): `)
                if (strOperacoes.includes(operacao)) {
                    break
                } else {
                    console.log('Operação inválida. Por favor, tente novamente!')
                }
            }
        } else {
            while (true) {
                let num = parseFloat(await pegarResposta(`Digite o ${c}º valor: `))
                if (!isNaN(num)) {
                    valores.push(num)
                    break
                } else {
                    console.log('Valor inválido! Por favor, digite um número válido!')
                }
            }
        }

    }
    prompt.close()
    
    let resultado

    switch (operacao) {
        case '+': resultado = valores[0] + valores[1]; break
        case '-': resultado = valores[0] - valores[1]; break
        case '*': resultado = valores[0] * valores[1]; break
        case '/': resultado = valores[0] / valores[1]; break
    }

    console.log(`Resultado: ${resultado}`)
}

principal()
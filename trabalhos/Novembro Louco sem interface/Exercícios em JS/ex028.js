import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let valores = []

    for (let c = 0; c < 50; c++) {
        while (true) {
            let num = parseInt(await pegarResposta(`Digite o ${c+1}º valor: `))
            if (!isNaN(num)) {
                valores.push(num)
                break
            } else {
                console.log('Valor inválido! Por favor, digite um número válido!')
            }
        }
    }
    let positivos = valores.filter(num => num > 0)
    let negativos = valores.filter(num => num < 0)
    let soma = positivos.reduce((ac, valor) => ac + valor)
    
    console.log(`A soma dos valores positivos digitados é de: ${soma}`)
    console.log(`A quantidade dos valores negativos digitados é de: ${negativos.length}`)
    
    prompt.close()
}

principal()
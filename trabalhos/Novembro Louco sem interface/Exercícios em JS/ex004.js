import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let valores = []

    for (let c = 0; c < 3; c++) {
        while (true) {
            let num = parseFloat(await pegarResposta(`Digite o ${c+1}º valor: `))
            if (!isNaN(num)) {
                valores.push(num)
                break
            } else {
                console.log('Valor inválido! Por favor, digite um número válido!')
            }
        }
    }
    prompt.close()

    let valoresOrdenados = valores.sort((a, b) => a - b)
    console.log(`Maior valor: ${valoresOrdenados.at(-1)}`)
    console.log(`Menor valor: ${valoresOrdenados[0]}`)
    console.log(`Valor intermédio: ${valoresOrdenados[1]}`)
}

principal()
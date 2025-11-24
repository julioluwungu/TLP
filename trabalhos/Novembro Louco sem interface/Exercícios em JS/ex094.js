import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(Number(resposta)))
    })
}

function calcularFatorial(numero) {
    if (numero <= 1) return 1
    return numero * calcularFatorial(numero - 1)
}

async function principal() {
    let numN

    while (true) {
        numN = parseInt(await pegarResposta('Digite quantos valores devem ser lidos: '))

        if (!isNaN(numN) && numN > 0) break
        else console.log('Valor inválido! Por favor, digite um número inteiro válido.')
    }

    let listaFatorial = []
    let listaValores = []
    
    for (let i = 0; i < numN; i++) {
        let valor

        while (true) {
            valor = await pegarResposta(`Digite o ${i + 1}º valor: `)
            if (!isNaN(valor) && valor > 0) break
            else console.log('Valor inválido! Por favor, digite um número inteiro válido.')
        }

        listaValores.push(valor)
        listaFatorial.push(calcularFatorial(valor))
    }

    console.log('-------------------')
    console.log('Valor\tFatorial')
    console.log('-------------------')
    for (let pos in listaFatorial) console.log(`${listaValores[pos]}\t${listaFatorial[pos]}`)

    prompt.close()
}

principal()
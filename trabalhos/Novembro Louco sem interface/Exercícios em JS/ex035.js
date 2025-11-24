import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numero = parseInt(await pegarResposta("Digite um número para ver sua tabela de multiplicação: "))
    
    console.log(`Tabela de multiplicação de ${numero}:`)
    for (let c = 1; c <= 13; c++) {
        let resultado = numero * c
        console.log(`${numero} x ${c} = ${resultado}`)
    }

    prompt.close()
}

principal()
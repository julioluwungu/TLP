import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numN

    while (true) {
        numN = parseInt(await pegarResposta("Informe um número inteiro N (N >= 2): "))
        if (!isNaN(numN) && numN >= 2) {
            break
        }
        console.log("Valor inválido! Por favor, digite um número inteiro maior ou igual a 2.")
    }

    let fibonacci = [0, 1]

    for (let c = 2; c < numN; c++) {
        let proximoTermo = fibonacci[c - 1] + fibonacci[c - 2]
        fibonacci.push(proximoTermo)
    }

    console.log(`Os ${numN} primeiros termos da sequência de Fibonacci são: ${fibonacci.join(", ")}`)
    
    prompt.close()
}

principal()
import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numero

    while (true) {
        numero = parseInt(await pegarResposta(`Digite um número para calcular o fatorial: `))
        if (!isNaN(numero)) {
            break
        }
        console.log("Valor inválido! Por favor, digite um valor inteiro válido.")
    }
    
    if (numero < 0) {
        console.log("Fatorial não é definido para números negativos.")
    } else {
        let fatorial = 1

        for (let c = 1; c <= numero; c++) {
            fatorial *= c
        }

        console.log(`O fatorial de ${numero} é: ${fatorial}`)
    }

    prompt.close()
}

principal()
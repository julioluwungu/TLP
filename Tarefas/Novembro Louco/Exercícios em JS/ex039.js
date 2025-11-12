import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let massa

    while (true) {
        massa = parseFloat(await pegarResposta("Informe a massa inicial em gramas: "))
        if (!isNaN(massa) && massa > 0) {
            break
        }
        console.log("Valor inválido! Por favor, digite um valor válido maior que zero.")
    }

    let tempoTotal = 0
    let tempoMeio = 50

    while (massa >= 0.05) {
        massa /= 2
        tempoTotal += tempoMeio
    }

    console.log(`O tempo necessário para que a massa seja menor que 0,05 gramas é: ${tempoTotal} segundos`)
    prompt.close()
}

principal()
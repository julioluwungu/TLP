import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numero1
    let numero2

    while (true) {
        numero1 = parseInt(await pegarResposta("Digite o primeiro número inteiro: "))
        numero2 = parseInt(await pegarResposta("Digite o segundo número inteiro: "))
        if (!isNaN(numero1) && !isNaN(numero2)) {
            break
        }
        console.log("Entrada inválida! Por favor, digite números inteiros válidos.")
    }

    let resultado = 0

    for (let i = 0; i < Math.abs(numero2); i++) {
        resultado += numero1
    }

    if (numero2 < 0) {
        resultado = -resultado
    }

    console.log(`O resultado da multiplicação de ${numero1} por ${numero2} é: ${resultado}`)
    prompt.close()
}

principal()
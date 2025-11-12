import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))

    })
}

function ehPrimo(num) {
    if (num < 2) {
        return { primo: false, divisao: 0 }
    }
    let qtdDivisoes = 0

    for (let i = 2; i <= Math.sqrt(num); i++) {
        qtdDivisoes++
        if (num % i === 0) {
            return { primo: false, divisao: qtdDivisoes }
        }
    }
    return { primo: true, divisao: qtdDivisoes }
}

async function principal() {
    let numN
    while (true) {
        numN = parseInt(await pegarResposta('Digite um número inteiro N: '))
        if (!isNaN(numN)) {
            break
        } else {
            console.log('Valor inválido! Por favor, digite um número válido!')
        }
    }
    let totalDivisoes = 0
    let numerosPrimos = []

    for (let i = 1; i <= numN; i++) {
        let resultado = ehPrimo(i)
        totalDivisoes += resultado.divisao
        if (resultado.primo) {
            numerosPrimos.push(i)
        }
    }

    console.log(`Números primos entre 1 e ${numN}: ${numerosPrimos.join(", ")}`)
    console.log(`Total de divisões executadas: ${totalDivisoes}`)
}

principal()
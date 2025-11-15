import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(Number(resposta)))
    })
}

function somarSemSoma(a, b) {
    while (b !== 0) {
        let carry = a & b
        a = a ^ b
        b = carry << 1 
    }
    return a
}

async function principal() {
    let num1 = await pegarResposta('Digite o primeiro número: ')
    let num2 = await pegarResposta('Digite o segundo número: ')

    let soma = somarSemSoma(num1, num2)
    console.log(`A soma de ${num1} e ${num2} é: ${soma}`)
    
    let tipo = soma % 2 === 0 ? 'par' : 'ímpar'
    console.log(`A soma é ${tipo}.`)

    prompt.close()
}

principal()
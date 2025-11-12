import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numeros = []
    let c = 1

    while (true) {
        let numero = parseInt(await pegarResposta(`Digite o ${c}º número (9999 para encerrar): `))
        
        if (numero === 9999) break
        else if (!isNaN(numero)) {
            numeros.push(numero)
            c++
        } 
        else console.log("Valor inválido! Por favor, digite um número válido.")
    }

    let pares = numeros.filter(num => num % 2 === 0)
    let impares = numeros.filter(num => num % 2 !== 0)

    console.log(`Quantidade de números pares: ${pares.length}`)
    console.log(`Quantidade de números ímpares: ${impares.length}`)

    prompt.close()
}

principal()
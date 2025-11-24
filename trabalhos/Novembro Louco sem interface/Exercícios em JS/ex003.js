import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let letras = ["X", "Y", "Z"]
    let valores = []

    for (let c = 0; c < 3; c++) {
        while (true) {
            let num = parseInt(await pegarResposta(`Digite o valor inteiro de ${letras[c]}: `))
            if (!isNaN(num) && num > 0) {
                valores.push(num)
                break
            } else {
                console.log('Valor inválido! Por favor, digite um número válido!')
            }
        }
    }

    prompt.close()

    if (
        valores[0] < valores[1] + valores[2] &&
        valores[1] < valores[0] + valores[2] &&
        valores[2] < valores[0] + valores[1]
    ) {
        if (valores[0] === valores[1] && valores[0] === valores[2]) {
            console.log('Triângulo Equilátero!')
        } else if (valores[0] === valores[1] || valores[0] === valores[2] || valores[1] === valores[2]) {
            console.log('Triângulo Isósceles!')
        } else {
            console.log('Triângulo Escaleno!')
        }
    } else {
        console.log('Não é possível formar um triângulo com os valores fornecidos!')
    }
}

principal()

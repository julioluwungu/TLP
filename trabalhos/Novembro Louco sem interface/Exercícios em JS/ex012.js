import { createInterface } from "readline"

let prompt = createInterface ({input:process.stdin, output:process.stdout})
function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))

    })
}

async function principal() {
    let valores = []
    let outroValor
    for (let c = 0; c < 10; c++) {
        while (true) {
            let num = Number(await pegarResposta(`Digite o ${c+1}º valor inteiro: `))
            if (!isNaN(num)) {
                valores.push(num)
                break
            } else {
                console.log('Valor inválido! Por favor, digite um número válido!')
            }
        }
    }

    while (true) {
        let num = Number(await pegarResposta(`Digite um outro valor: `))
        if (!isNaN(num)) {
            outroValor = num
            break
        } else {
            console.log('Valor inválido! Por favor, digite um número válido!')
        }
    }
    prompt.close()

    let inferiores = valores.filter(num => num < outroValor)
    console.log(`Dentre os valores digitados anteriormente, ${inferiores.length} são inferiores à ${outroValor}`)
    console.log(`Eles são: ${inferiores.join(', ')}`)
}

principal()
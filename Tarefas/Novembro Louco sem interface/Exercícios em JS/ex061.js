import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numAndares
    let totalPessoas = 0

    while (true) {
        numAndares = parseInt(await pegarResposta("Informe o número de andares do prédio: "))
        if (!isNaN(numAndares) && numAndares > 0) {
            break
        }
        console.log("Valor inválido! Por favor, digite um número válido de andares.")
    }

    for (let andar = 1; andar <= numAndares; andar++) {
        console.log(`\nAndar ${andar}:`)
        let entraram = parseInt(await pegarResposta(`Número de pessoas que entraram no elevador no ${andar}º andar: `))
        let sairam = parseInt(await pegarResposta(`Número de pessoas que saíram do elevador no ${andar}º andar: `))

        totalPessoas += entraram - sairam

        if (totalPessoas > 15) {
            let excesso = totalPessoas - 15
            console.log(`Excesso de passageiros! Deve sair ${excesso} pessoas.`)
            totalPessoas -= excesso
        }

        if (totalPessoas < 0) {
            totalPessoas = 0
        }
    }

    console.log(`\nNúmero de pessoas que irão descer no último andar: ${totalPessoas}`)
    prompt.close()
}

principal()
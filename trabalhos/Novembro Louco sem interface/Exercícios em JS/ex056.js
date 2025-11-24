import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let totalSalario = 0
    let quantidade = 0
    let maiorIdade = -1
    let menorIdade = 1000000
    let mulheresComSalarioBaixo = 0

    while (true) {
        let idade = parseInt(await pegarResposta("Informe a idade (negativa para encerrar): "))
        
        if (idade < 0) break

        let sexo = await pegarResposta("Informe o sexo (M/F): ").toUpperCase()
        let salario = parseFloat(await pegarResposta("Informe o salário: "))

        totalSalario += salario
        quantidade++

        if (idade > maiorIdade) {
            maiorIdade = idade
        }
        if (idade < menorIdade) {
            menorIdade = idade
        }

        if (sexo === 'F' && salario <= 100) {
            mulheresComSalarioBaixo++
        }
    }

    let mediaSalario = quantidade > 0 ? totalSalario / quantidade : 0

    console.log(`Média de salário do grupo: R$${mediaSalario.toFixed(2)}`)
    console.log(`Maior idade do grupo: ${maiorIdade}`)
    console.log(`Menor idade do grupo: ${menorIdade}`)
    console.log(`Quantidade de mulheres com salário até R$100,00: ${mulheresComSalarioBaixo}`)

    prompt.close()
}

principal()
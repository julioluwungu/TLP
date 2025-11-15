import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let funcionarios = []

    while (true) {
        let nome = await pegarResposta("Digite o nome do funcionário (ou 'fim' para encerrar): ")

        if (nome.toLowerCase() === 'fim') break

        let salario = parseFloat(await pegarResposta(`Digite o salário de ${nome}: `))

        if (!isNaN(salario)) funcionarios.push({ nome, salario })
        else console.log("Salário inválido! Por favor, insira um número.")
        
    }

    if (funcionarios.length > 0) {
        let totalSalarios = funcionarios.reduce((ac, funcionario) => ac + funcionario.salario, 0)
        let salarioMaisAlto = Math.max(...funcionarios.map(funcionario => funcionario.salario))
        let salarioMaisBaixo = Math.min(...funcionarios.map(funcionario => funcionario.salario))
        let mediaSalarios = totalSalarios / funcionarios.length

        console.log(`Média de salários: ${mediaSalarios.toFixed(1)}`)
        console.log(`Salário mais alto: ${salarioMaisAlto.toFixed(1)}`)
        console.log(`Salário mais baixo: ${salarioMaisBaixo.toFixed(1)}`)
    } else {
        console.log("Nenhum funcionário foi registrado.")
    }

    prompt.close()
}

principal()
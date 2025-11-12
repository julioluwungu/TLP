import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let quantidadeFuncionarios = parseInt(await pegarResposta("Informe a quantidade de funcionários: ")) 
    let salarios = []
    
    for (let c = 0; c < quantidadeFuncionarios; c++) {
        let nome = await pegarResposta(`Digite o nome do ${c+1}º funcionário: `)
        let salario = parseFloat(await pegarResposta(`Informe o salário de ${nome}: `))
        
        salarios.push(salario)
    }

    let somaSalarios = salarios.reduce((ac, valor) => ac + valor)
    let mediaSalarios = somaSalarios / salarios.length
    let salarioMaisAlto = Math.max(...salarios)
    let salarioMaisBaixo = Math.min(...salarios)

    console.log(`Média dos salários: R$ ${mediaSalarios.toFixed(1)}`)
    console.log(`Salário mais alto: R$ ${salarioMaisAlto.toFixed(1)}`)
    console.log(`Salário mais baixo: R$ ${salarioMaisBaixo.toFixed(1)}`)

    prompt.close()
}

principal()
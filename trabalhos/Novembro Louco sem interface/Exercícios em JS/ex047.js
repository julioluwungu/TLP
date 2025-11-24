import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let alunos = []
    let numAlunos

    while (true) {
        numAlunos = parseInt(await pegarResposta("Digite o número de alunos: "))
        if (!isNaN(numAlunos) && numAlunos > 0) {
            break
        }
        console.log("Entrada inválida! Por favor, digite um número válido de alunos.")
    }

    console.log("Digite o número de vezes que cada aluno utilizou o restaurante:")
    
    while (alunos.length < numAlunos) {
        let uso = parseInt(await pegarResposta(`Aluno ${alunos.length + 1}: `))
        
        if (!isNaN(uso) && uso >= 0) {
            alunos.push(uso)
        } else {
            console.log("Número inválido! Por favor, digite um valor válido.")
        }
    }

    let menosQue10 = (alunos.filter(aluno => aluno < 10)).length
    let entre10e15 = (alunos.filter(aluno => aluno >= 10 && aluno <= 15)).length
    let acimaDe15 = (alunos.filter(aluno => aluno > 15)).length

    let totalAlunos = alunos.length
    let percentualMenosQue10 = ((menosQue10 * 100) / totalAlunos).toFixed(1)
    let percentualEntre10e15 = ((entre10e15 * 100) / totalAlunos).toFixed(1)
    let percentualAcimaDe15 = ((acimaDe15 * 100) / totalAlunos).toFixed(1)

    console.log(`a) Percentual de alunos que utilizaram menos que 10 vezes: ${percentualMenosQue10}%`)
    console.log(`b) Percentual de alunos que utilizaram entre 10 e 15 vezes: ${percentualEntre10e15}%`)
    console.log(`c) Percentual de alunos que utilizaram mais de 15 vezes: ${percentualAcimaDe15}%`)

    prompt.close()
}

principal()
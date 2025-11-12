import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let totalAprovados = 0
    let totalReprovados = 0
    let totalAlunos = 0
    let c = 1

    while (true) {
        let matricula = parseInt(await pegarResposta(`Informe a matrícula do ${c}º aluno (9999 para encerrar): `))
        
        if (matricula === 9999) break

        let nota1 = parseFloat(await pegarResposta("Informe a 1ª nota: "))
        let nota2 = parseFloat(await pegarResposta("Informe a 2ª nota: "))
        let nota3 = parseFloat(await pegarResposta("Informe a 3ª nota: "))

        let mediaFinal = ((2 * nota1) + (3 * nota2) + (4 * nota3)) / 9
        totalAlunos++

        if (mediaFinal >= 5) {
            console.log(`Matrícula: ${matricula}, Média Final: ${mediaFinal.toFixed(2)} - APROVADO`)
            totalAprovados++
        } else {
            console.log(`Matrícula: ${matricula}, Média Final: ${mediaFinal.toFixed(2)} - REPROVADO`)
            totalReprovados++
        }
        c++
    }

    console.log(`Total de alunos: ${totalAlunos}`)
    console.log(`Total de aprovados: ${totalAprovados}`)
    console.log(`Total de reprovados: ${totalReprovados}`)

    prompt.close()
}

principal()
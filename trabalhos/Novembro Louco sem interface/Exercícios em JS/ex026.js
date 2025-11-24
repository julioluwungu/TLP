import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let listagem = []
    let salarioM = []
    let salarioF = []

    while (true) {
        let codigo = parseInt(await pegarResposta('Digite o código (ou 999 para sair): '))
        if (codigo === 999) break

        let sexo
        while (true) {
            sexo = (await pegarResposta('Qual o sexo? [M/F]: ')).trim().toUpperCase()
            if (['M', 'F'].includes(sexo)) break
            else console.log(`Sexo inválido. Por favor, tente novamente!`)
        }

        let horas = parseInt(await pegarResposta('Digite o número de horas/aulas dadas: '))

        let salBruto = horas * 30
        let desconto = sexo === 'M' ? 0.10 : 0.05
        let salLiquido = salBruto * (1 - desconto)

        if (sexo === 'M') {
            salarioM.push(salLiquido)
        } else {
            salarioF.push(salLiquido)
        }

        listagem.push({ codigo, sexo, salario_bruto: salBruto, salario_liquido: salLiquido })
    }

    let somaSalM = salarioM.reduce((ac, valor) => ac + valor, 0)
    let somaSalF = salarioF.reduce((ac, valor) => ac + valor, 0)

    let mediaSalM = salarioM.length > 0 ? somaSalM / salarioM.length : 0
    let mediaSalF = salarioF.length > 0 ? somaSalF / salarioF.length : 0

    console.log('Emitindo listagem:')
    listagem.forEach(pessoa => console.log(`Código: ${pessoa.codigo}. Sexo: ${pessoa.sexo}. Salário bruto: R$ ${pessoa.salario_bruto.toFixed(1)}. Salário líquido: R$ ${pessoa.salario_liquido.toFixed(1)}.`))
    console.log(`Média dos salários líquidos do sexo masculino: R$ ${mediaSalM.toFixed(1)}`)
    console.log(`Média dos salários líquidos do sexo feminino: R$ ${mediaSalF.toFixed(1)}`)

    prompt.close()
}

principal()
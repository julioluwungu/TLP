import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let maiorIdade = -1
    let qtdMulheres18_35 = 0
    let qtdVerdeLouros = 0

    while (true) {
        let idade = parseInt(await pegarResposta("Informe a idade (ou -1 para encerrar): "))
        
        if (idade === -1) break

        let sexo = await pegarResposta("Informe o sexo (M/F): ").toUpperCase()
        let corOlhos = parent(await pegarResposta("Informe a cor dos olhos ([1] azuis, [2] verdes ou [3] castanhos): "))
        let corCabelos = parseInt(await pegarResposta("Informe a cor dos cabelos ([1] loiro, [2] castanho ou [3] preto): "))

        if (idade > maiorIdade) {
            maiorIdade = idade
        }

        if (sexo === 'F' && idade >= 18 && idade <= 35) {
            qtdMulheres18_35++
        }

        if (corOlhos === 2 && corCabelos === 1) {
            qtdVerdeLouros++
        }
    }

    console.log(`A maior idade dos habitantes é: ${maiorIdade}`)
    console.log(`Quantidade de mulheres entre 18 e 35 anos: ${qtdMulheres18_35}`)
    console.log(`Quantidade de indivíduos com olhos verdes e cabelos louros: ${qtdVerdeLouros}`)

    prompt.close()
}

principal()
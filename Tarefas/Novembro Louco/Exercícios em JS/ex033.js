import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function casoUm() {
    for (let c = 0; c < 10; c++) {
        let numA = parseFloat(await pegarResposta("Informe o valor de A: "))
        let numB = parseFloat(await pegarResposta("Informe o valor de B: "))
        
        if (numB === 0) {
            console.log("Divisão por zero não é permitida, tente novamente.")
            c--
            continue
        }

        let modulo = numA % numB
        console.log(`O resultado do módulo é: ${modulo}`)
    }
}

async function casoTres() {
    for (let i = 0; i < 10; i++) {
        for (let j = 0; j < 10; j++) {
            let numA = parseFloat(await pegarResposta("Informe o valor de A: "))
            let numB = parseFloat(await pegarResposta("Informe o valor de B: "))
            
            if (numB === 0) {
                console.log("Divisão por zero não é permitida, tente novamente.")
                j--
                continue
            }

            let modulo = numA % numB
            console.log(`O resto da divisão será de: ${modulo}`)
        }
    }
}

async function casoQuatro() {
    let numN = parseInt(await pegarResposta("Informe quantas vezes deseja executar: "))
    
    for (let c = 0; c < numN; c++) {
        let numA = parseFloat(await pegarResposta("Informe o valor de A: "))
        let numB = parseFloat(await pegarResposta("Informe o valor de B: "))
        
        if (numB === 0) {
            console.log("Divisão por zero não é permitida, tente novamente.")
            c--
            continue
        }

        let modulo = numA % numB
        console.log(`O resto da divisão será de: ${modulo}`)
    }
}

async function principal() {
    let variacao = parseInt(await pegarResposta('Deseja qual variação do código? (1, 2, 3 ou 4): '))

    switch (variacao) {
        case 1:
            await casoUm()
            break
        case 2:
            console.log('Nenhum código disponível para esta opção.')
            break
        case 3:
            await casoTres()
            break
        case 4:
            await casoQuatro()
            break
        default:
            console.log('Opção inválida! Por favor, tente novamente.')
    }

    prompt.close()
}

principal()
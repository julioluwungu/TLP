import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let diaria = 50
    let totalGanhoHotel = 0
    
    while (true) {
        let nome = await pegarResposta("Informe o nome do cliente (ou 'sair' para encerrar): ")
        if (nome.toLowerCase() === 'sair') {
            break
        }
        
        let numDiarias = parseInt(await pegarResposta("Informe o número de diárias: "))
        if (isNaN(numDiarias) || numDiarias <= 0) {
            console.log("Número de diárias inválido!")
            continue
        }

        let taxaServico
        if (numDiarias < 15) {
            taxaServico = 4
        } else if (numDiarias === 15) {
            taxaServico = 3.6
        } else {
            taxaServico = 3
        }

        let totalConta = (diaria + taxaServico) * numDiarias
        totalGanhoHotel += totalConta

        console.log(`\nNome do cliente: ${nome}`)
        console.log(`Total da conta: R$ ${totalConta.toFixed(2)}`)
    }

    console.log(`\nTotal ganho pelo hotel: R$ ${totalGanhoHotel.toFixed(2)}`)
    prompt.close()
}

principal()
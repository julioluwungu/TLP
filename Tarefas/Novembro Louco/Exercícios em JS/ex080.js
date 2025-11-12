import { createInterface } from 'readline'

let prompt = createInterface({
    input: process.stdin,
    output: process.stdout
})

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

function desenharTriangulo(tamanho) {
    for (let c = 1; c <= tamanho; c++) {
        console.log(' '.repeat(tamanho - c) + '%'.repeat(2 * c -1))
    }
}

function desenharLosango(tamanho) {
    for (let c = 1; c <= tamanho; c++) {
        console.log(' '.repeat(tamanho - c) + '%'.repeat(2 * c - 1))
    }

    for (let c = tamanho - 1; c >= 1; c--) {
        console.log(' '.repeat(tamanho - c) + '%'.repeat(2 * c - 1))
    }
}

async function principal() {
    let figura = (await pegarResposta("Escolha a figura (triângulo ou losango): ")).toLowerCase()
    let tamanho = parseInt(await pegarResposta("Digite o tamanho (número de linhas): "), 10)

    if (figura === 'triângulo') {
        desenharTriangulo(tamanho)
    } else if (figura === 'losango') {
        desenharLosango(tamanho)
    } else {
        console.log("Opção inválida. Escolha 'triângulo' ou 'losango'.")
    }

    prompt.close()
}

principal()
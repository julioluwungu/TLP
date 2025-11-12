import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarNome(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let nomes = []

    for (let i = 0; i < 10; i++) {
        let nome = await pegarNome(`Digite o nome da pessoa ${i + 1}: `)
        nomes.push(nome)
    }

    let verificarNome = await pegarNome("Digite um nome para verificar: ")

    if (nomes.includes(verificarNome)) {
        console.log("ACHEI")
    } else {
        console.log("NÃO ACHEI")
    }

    prompt.close()
}

principal()
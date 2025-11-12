import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => {
            resolve(parseInt(resposta))
        })
    })
}

async function principal() {
    let numero = await pegarResposta("Montar a tabuada de: ")
    let inicio = await pegarResposta("Começar por: ")
    let fim = await pegarResposta("Terminar em: ")
    prompt.close()

    if (fim < inicio) {
        console.log("O valor final não pode ser menor que o valor inicial. Tente novamente.")
        prompt.close()
        return
    } else {
        console.log(`Vou montar a tabuada de ${numero} começando em ${inicio} e terminando em ${fim}:`)

        for (let i = inicio; i <= fim; i++) {
            console.log(`${numero} X ${i} = ${numero * i}`)
        }
    }
}

principal()
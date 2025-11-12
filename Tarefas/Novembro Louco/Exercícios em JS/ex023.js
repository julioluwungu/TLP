import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))

    })
}

async function principal() {
    let base

    while (true) {
        base = Number(await pegarResposta("Digite a base do triângulo (entre 5 e 15): "))
        if (!isNaN(base) && base >= 5 && base <= 15) {
            break
        } else {
            console.log("A base deve ser entre 5 e 15. Tente novamente.")
        }
    }

    for (let c = 1; c <= base; c += 2) {
        let espaco = Math.floor((base - c) / 2)
        console.log(' '.repeat(espaco) + '#'.repeat(c))
    }

    prompt.close()
}

principal()
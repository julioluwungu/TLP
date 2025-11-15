import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let n, a1, r

    while (true) {
        n = parseInt(await pegarResposta("Informe o número de termos (n): "))
        a1 = parseFloat(await pegarResposta("Informe o primeiro termo (a1): "))
        r = parseFloat(await pegarResposta("Informe a razão (r): "))

        if (!isNaN(n) && !isNaN(a1) && !isNaN(r)) break
        else console.log('Valor inválido! Por favor, tente novamente!')
    }

    let termos = []
    let soma = 0

    for (let c = 0; c < n; c++) {
        let termo = a1 + c * r
        termos.push(termo)
        soma += termo
    }

    console.log("Os termos da PA são:", termos.join(", "))
    console.log("A soma dos termos é:", soma)

    prompt.close()
}

principal()
import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResultado (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    });
}

async function principal() {
    let resultado = await pegarResultado('Digite um array: ')
    prompt.close()

    let vetor = Array.from(resultado)
    vetor = vetor.filter(num => !isNaN(Number(num))).map(num => Number(num))
    let valoresUnicos = [... new Set(vetor)]
    let lista = []

    valoresUnicos.forEach(valor => {
        let dict = {}
        let qtd = vetor.filter(num => num == valor)
        dict.numero = valor
        dict.vezes = qtd.length
        lista.push(dict)
    })

    lista.sort((a,b) => b.vezes - a.vezes)
    lista = lista.slice(0, 3)

    console.log(lista)
}

principal()
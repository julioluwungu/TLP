import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function retornarFrase (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => {resolve(resposta); prompt.close()})
    })
}

let frase = await retornarFrase("Digite uma frase: ")

let numCaracteres = frase.replaceAll(' ', '').length
let numPalavras = (frase.split(" ")).length
console.log(`Frase: ${frase}\nNúmero de caracteres: ${numCaracteres}\nNúmero de Palavras: ${numPalavras}\nFrase em Maiúsculas: ${frase.toUpperCase()}\nFrase em Minúsculas: ${frase.toLowerCase()}`)
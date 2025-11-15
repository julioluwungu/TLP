import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))

    })
}

async function principal() {
    let texto = (await pegarResposta("Digite uma string: ")).trim().toLowerCase()
    prompt.close()

    let listaTxt = Array.from(texto)

    let digitos = listaTxt.filter(elemento => {
        let numero = Number(elemento)
        if (!isNaN(numero)) return elemento
    })
    let palindromo = texto === texto.split("").reverse().join("")
    const vogais = listaTxt.filter(elemento => 'aeiou'.includes(elemento))

    console.log(`a) Número de caracteres: ${texto.length}`)
    console.log(`b) String em maiúsculo: ${texto.toUpperCase()}`)
    console.log(`c) Número de vogais: ${vogais.length}`)
    console.log(`d) A string começa com "UNI": ${texto.toUpperCase().startsWith("UNI")}`)
    console.log(`e) A string termina com "RIO": ${texto.toUpperCase().endsWith("RIO")}`)
    console.log(`f) Número de dígitos: ${digitos.length}`)
    console.log(`g) A string é um palíndromo: ${palindromo}`)
    
}

principal()
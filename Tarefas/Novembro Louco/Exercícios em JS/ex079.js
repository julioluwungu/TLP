import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

function palindromasMutuas(str1, str2) {
    let str2Reversa = str2.split('').reverse().join('')
    return str1 === str2Reversa
}

async function principal() {
    let string1 = await pegarResposta('Digite a primeira string: ')
    let string2 = await pegarResposta('Digite a segunda string: ')

    let resultado = palindromasMutuas(string1, string2)
    
    if (resultado) console.log(`As strings "${string1}" e "${string2}" são palíndromas mútuas.`)
    else console.log(`As strings "${string1}" e "${string2}" não são palíndromas mútuas.`)

    prompt.close()
}

principal()
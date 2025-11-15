import { resolve } from "path"
import { createInterface } from "readline"

let prompt = createInterface ({input:process.stdin, output:process.stdout})
function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))

    })
}

async function principal() {
    let palavras = []
    for (let c = 0; c < 2; c++) {
        let palavra = await pegarResposta(`Digite a ${c+1}ª palavra: `)
        palavras.push(palavra)
    }
    prompt.close()

    if (palavras[0] === palavras[1]) {
        console.log('As palavras digitadas são iguais.')
    } else {
        if (palavras[0].length > palavras[1].length) console.log(`A palavra "${palavras[0]}" tem maior comprimento em relação à palavra "${palavras[1]}"`)
        else if (palavras[1].length > palavras[0].length) console.log(`A palavra "${palavras[1]}" tem maior comprimento em relação à palavra "${palavras[0]}"`)
        else console.log(`A palavra "${palavras[0]}" e a palavra "${palavras[1]}" têm o mesmo comprimento.`)
        
        if (palavras[0].includes(palavras[1])) console.log(`A palavra "${palavras[1]}" é uma substring da palavra "${palavras[0]}".`)
    }
}

principal()
import { resolve } from "path"
import { createInterface } from "readline"

let prompt = createInterface ({input:process.stdin, output:process.stdout})
function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))

    })
}

async function principal() {
    let tempo
    while (true) {
        tempo = Number(await pegarResposta('Digite um tempo em segundos: '))
        if (!isNaN(tempo) && tempo >= 0) break
        console.log('Valor inválido! Por favor, digite um número válido!')
    }
    prompt.close()

    let horas = Math.floor(tempo / 3600)
    let minutos = Math.floor((tempo - (horas * 3600)) / 60)
    let segundos = Math.floor((tempo - (horas * 3600)) - (minutos * 60))

    console.log(`${tempo} segundos equivale a:`)
    console.log(`${horas.toString().padStart(2, '0')}:${minutos.toString().padStart(2, '0')}:${segundos.toString().padStart(2, '0')}`)

}

principal()
import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResultado (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    });
}

async function principal() {
    let cont = 1
    let resposta
    let lista = []
    do {
        let nome = await pegarResultado(`Digite o nome do ${cont}º jogador: `)
        let pontos = Number(await pegarResultado(`Digite os pontos do ${cont}º jogador: `))
        resposta = (await pegarResultado('Deseja continuar? Sim ou não? ')).replaceAll(' ', '')
        lista.push({nome: `${nome}`, pontos: `${pontos}`})
        cont++
    } while (resposta.toLowerCase() == 'sim')
    prompt.close()

    lista.sort((a,b) => b.pontos - a.pontos)

    lista.forEach((elemento, i) => console.log(`${i+1}º lugar: ${elemento.nome} com ${elemento.pontos}`))
}

principal()
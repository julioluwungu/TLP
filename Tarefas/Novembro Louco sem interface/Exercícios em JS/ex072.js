import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let numero

    while (true) {
        numero = parseInt(await pegarResposta('Digite um número entre 20 e 99: '))
        if (numero < 20 || numero > 99 || isNaN(numero)) {
            console.log('Número inválido. Por favor, digite um número entre 20 e 99.')
        } else break
    }

    let unidades = ['', 'um', 'dois', 'três', 'quatro', 'cinco', 'seis', 'sete', 'oito', 'nove']
    let dezenas = ['', 'dez', 'vinte', 'trinta', 'quarenta', 'cinquenta', 'sessenta', 'setenta', 'oitenta', 'noventa']
    let extenso = ''

    if (numero < 30) {
        extenso = dezenas[2] + (numero === 20 ? '' : ' e ' + unidades[numero % 10])
    } else {
        extenso = dezenas[Math.floor(numero / 10)] +
            (numero % 10 !== 0 ? ' e ' + unidades[numero % 10] : '')
    }

    console.log(`O número ${numero} por extenso é: ${extenso}`)
    prompt.close()
}

principal()
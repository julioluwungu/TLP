import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let data = await pegarResposta('Digite sua data de nascimento (dd/mm/aaaa): ')

    let [dia, mes, ano] = data.split('/')

    let meses = ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"]

    let mesExtenso = meses[parseInt(mes) - 1]

    if (mesExtenso) {
        console.log(`Você nasceu em ${dia} de ${mesExtenso} de ${ano}`)
    } else {
        console.log('Mês inválido. Certifique-se de digitar no formato dd/mm/aaaa.')
    }
    
    prompt.close()
}

principal()
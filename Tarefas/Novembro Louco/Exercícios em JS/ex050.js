import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let hoteis = []

    while (true) {
        let nome = await pegarResposta("Digite o nome do hotel: ")
        let distancia = parseFloat(await pegarResposta("Digite a distância do hotel ao centro da cidade (em km): "))
        let visitantes = parseInt(await pegarResposta("Digite o número médio de visitantes no último feriado: "))
        let acesso = parseInt(await pegarResposta("Digite o tipo de acesso ao hotel (0 - não asfaltado, 1 - asfaltado): "))

        hoteis.push({ nome, distancia, visitantes, acesso })

        let sair = await pegarResposta("Deseja adicionar mais um hotel? (s/n): ")
        if (sair.toLowerCase() === 's') break
    }

    let hoteisDistantes = (hoteis.filter(hotel => hotel.distancia > 15)).length
    console.log(`Número de hotéis que distam mais de 15 km do centro: ${hoteisDistantes}`)

    let hotelesNaoAsfaltados = hoteis.filter(hotel => hotel.acesso === 0)
    let mediaVisitantes

    if (hotelesNaoAsfaltados.length > 0) {
        let somaVisitantes = hotelesNaoAsfaltados.reduce((ac, hotel) => ac + hotel.visitantes)
        mediaVisitantes = somaVisitantes / hotelesNaoAsfaltados.length
    }
    console.log(`Quantidade média de visitantes nos hotéis com acesso não asfaltado: ${mediaVisitantes.toFixed(1)}`)

    console.log("Hotéis asfaltados com menos de 1.000 visitantes:")
    hoteis.forEach(hotel => {
        if (hotel.acesso === 1 && hotel.visitantes < 1000) {
            console.log(`${hotel.nome}, Distância: ${hotel.distancia} km`)
        }
    })

    prompt.close()
}

principal()
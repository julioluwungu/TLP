import { createInterface } from "readline"

let prompt = createInterface({ input: process.stdin, output: process.stdout })

function pegarResposta(pergunta) {
    return new Promise(resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let nome1 = await pegarResposta("Digite o nome da primeira pessoa: ")
    let altura1 = parseFloat(await pegarResposta(`Digite a altura de ${nome1} (em metros): `))
    let peso1 = parseFloat(await pegarResposta(`Digite o peso de ${nome1} (em kg): `))

    let nome2 = await pegarResposta("Digite o nome da segunda pessoa: ")
    let altura2 = parseFloat(await pegarResposta(`Digite a altura de ${nome2} (em metros): `))
    let peso2 = parseFloat(await pegarResposta(`Digite o peso de ${nome2} (em kg): `))

    let maisPesado = peso1 >= peso2 ? { nome: nome1, peso: peso1 } : { nome: nome2, peso: peso2 }
    let maisAlto = altura1 >= altura2 ? { nome: nome1, altura: altura1 } : { nome: nome2, altura: altura2 }

    console.log(`A pessoa mais pesada é ${maisPesado.nome} com ${maisPesado.peso} kg.`)
    console.log(`A pessoa mais alta é ${maisAlto.nome} com ${maisAlto.altura} m.`)

    prompt.close()
}

principal()
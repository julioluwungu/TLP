import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function principal() {
    let nome = await pegarResposta("Qual é o seu nome? ")
    let peso = Number(await pegarResposta("Qual é o seu peso em Kg? "))
    let altura = Number(await pegarResposta("Qual é a sua altura em metros? "))
    prompt.close()

    let imc = peso / (altura ** 2)
    let classificacao = ""

    if (imc < 18.5) {
        classificacao = 'Abaixo do peso!'
    } else if (imc < 25) {
        classificacao = 'Peso normal!'
    } else if (imc < 30) {
        classificacao = 'Sobrepeso'
    } else {
        classificacao = 'Obesidade'
    }
    console.log(`Olá ${nome}! O seu IMC é ${imc.toFixed(2)} e está classificado como: ${classificacao}`)
}

principal()
    
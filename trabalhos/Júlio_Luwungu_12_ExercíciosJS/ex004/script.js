import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

function verificarEmail(email) {
    if (email.includes('@') && email.includes('.')) console.log(`O email ${email} é válido!`)
    else console.log(`O email ${email} é inválido!`)
}

async function principal() {
    let email = await pegarResposta('Digite um email: ')
    prompt.close()
    
    email = email.replaceAll(' ', '')
    verificarEmail(email)
}

principal()
import { createInterface } from "readline"

const prompt = createInterface ({input: process.stdin, output: process.stdout})

function pegarResposta (pergunta) {
    return new Promise (resolve => {
        prompt.question(pergunta, resposta => resolve(resposta))
    })
}

async function criarCadastro() {
    return {
        nome: await pegarResposta('Digite o seu nome: '),
        idade: await pegarResposta('Digite a sua idade: '),
        cidade: await pegarResposta('Digite a sua cidade: ')
    }
}

async function principal() {
    let listaCadastro = []
    let resposta
    do {
        let cadastro = await criarCadastro()
        listaCadastro.push(cadastro)
        resposta = (await pegarResposta('Deseja cadastrar uma outra pessoa? Sim ou não? ')).replaceAll(' ','')
    } while (resposta.toLowerCase() === 'sim')
    prompt.close()

    console.log('Pessoas cadastradas:')
    for (let pessoa of listaCadastro) {
        console.log(`Nome: ${pessoa.nome}, Idade: ${pessoa.idade}, Cidade: ${pessoa.cidade}`)
    }
}

principal()
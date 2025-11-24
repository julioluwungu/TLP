// const somar = (a, b) => {
//     return a + b
// }

// const subtrair = (a, b) => {
//     return a - b
// }

// const multiplicar = (a, b) => {
//     return a * b
// }

// const dividir = (a, b) => {
//     return a / b
// }

// const parOuImpar = (num) => {
//     return num % 2 == 0? `O número ${num} é PAR.`: `O número ${num} é ímpar.`
// }

// export default {somar, subtrair, multiplicar, dividir, parOuImpar}

export default function formatar (obj) {
    console.log(obj.nome[0] == obj.nome[0].toUpperCase()? 'Já está em maiúsculo': obj.nome[0].toUpperCase() + obj.nome.slice(1))

    console.log(obj.email.toUpperCase())
}
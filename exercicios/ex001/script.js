let adicionar = document.querySelector('input[type="button"]')
let resetar = document.querySelector('input[type="reset"]')
adicionar.addEventListener('click', verificar)
resetar.addEventListener('click', limpar)

var vetor = []

function verificar() {
    let res = document.querySelector('div#res')
    let numero = document.querySelector('input#numero')
    let valor = Number(numero.value)
    vetor.push(valor)

    negativo = [... new Set(vetor.filter(n => n < 0))]

    for (let elemento of negativo) {
        filtro = vetor.filter(x => x == elemento)
        if (filtro.length == 3) {
            numero.disabled = true
        }
    }

    let primos = 0
    let neutros = 0
    let soma = 0

    for (let elemento of vetor) {
        if (ehPrimo(elemento)) {
            primos += 1
        }
        if (elemento == 0) {
            neutros += 1
        }
        if (elemento < 0) {
            soma += elemento
        }
    }

    res.innerHTML = `Vetor: ${vetor}<br>Conjunto negativo: ${negativo}<br>Quantidade dos primos: ${primos}<br>Quintuplo dos neutros: ${neutros*5}<br>Soma dos negativos: ${soma}`

    if (!numero.disabled) numero.focus()
}

function limpar() {
    let numero = document.querySelector('input#numero')
    let res = document.querySelector('div#res')
    res.innerHTML = ''
    vetor = []
    numero.disable = false
    numero.value = ''
    numero.focus()
}

function ehPrimo(num) {
    if (num < 2) return false
    for (let c = 2; c <= Math.sqrt(num); c++) {
        if (num % c == 0) return false
    }
    return true
}
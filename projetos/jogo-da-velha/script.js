let caixas = document.querySelectorAll('div.casa')
let controlador = 1
let jogoEncerrado = false

caixas.forEach(caixa => {
    caixa.addEventListener('click', () => {
        if (jogoEncerrado) return

        if (caixa.textContent !== '') {
            alert('Esse lugar já está preenchido!')
            return
        }

        let valor = controlador % 2 === 0 ? 'X' : 'O'
        caixa.textContent = valor
        controlador++

        if (ganhou()) {
            alert(`O jogador ${valor} ganhou!`)
            jogoEncerrado = true
            desativarTabuleiro()
        }
    })
})


function ganhou() {
    let matriz = []
    let auxiliar = []

    caixas.forEach(caixa => {
        auxiliar.push(caixa.textContent)
        if (auxiliar.length === 3) {
            matriz.push([...auxiliar])
            auxiliar.length = 0
        }
    })

    for (let l = 0; l < 3; l++) {
        if (matriz[l][0] !== '' && matriz[l][0] === matriz[l][1] && matriz[l][1] === matriz[l][2]) return true
    }

    for (let c = 0; c < 3; c++) {
        if (matriz[0][c] !== '' && matriz[0][c] === matriz[1][c] && matriz[1][c] === matriz[2][c]) return true
    }

    if (matriz[0][0] !== '' && matriz[0][0] === matriz[1][1] && matriz[1][1] === matriz[2][2]) return true

    if (matriz[0][2] !== '' && matriz[0][2] === matriz[1][1] && matriz[1][1] === matriz[2][0]) return true

    return false
}

function desativarTabuleiro() {
    caixas.forEach(caixa => caixa.replaceWith(caixa.cloneNode(true)))
}
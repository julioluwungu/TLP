let input = document.querySelector('input#texto')
let res = document.querySelector('div#res')

function verificar() {
    let texto = (input.value).toLowerCase()
    let vetor = texto.replaceAll(' ', '').split("")

    let letrasUnicas = [... new Set(vetor)]

    res.innerHTML = `<span class="centro">Número das letras repetidas</span>`
    for (letra of letrasUnicas) {
        let qtdLetras = vetor.filter(x => x == letra)
        if (qtdLetras.length == 1) {
            res.innerHTML += `<br>A letra "${letra.toUpperCase()}" apareceu ${qtdLetras.length} vez!`
        } else {
            res.innerHTML += `<br>A letra "${letra.toUpperCase()}" apareceu ${qtdLetras.length} vezes!`
        }
    }
}
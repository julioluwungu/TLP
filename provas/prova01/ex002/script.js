let input = document.querySelector('input#numero')
let res = document.querySelector('div#res')

function rodar() {
    let numero = input.value
    let vetor = numero.split("")
    res.innerHTML = 'Resultado:'

    for (numero of vetor) {
        if (numero == '5') {
            let span = document.createElement('span')
            span.textContent = numero
            span.classList.add('girar')
            res.appendChild(span)
        } else {
            res.innerHTML += numero
        }
    }
}
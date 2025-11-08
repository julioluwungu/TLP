function verificar() {
    let input = document.querySelector('input#numero')
    let texto = input.value
    let teste = document.querySelector('div#teste')
    let vetor_txt = texto.split("")
    
    teste.innerHTML = ''

    for (elemento of vetor_txt) {
        if (elemento == '5') {
            let span = document.createElement('span')
            span.textContent = elemento
            span.classList.add('rodar')
            teste.appendChild(span)
        } else {
            teste.innerHTML += elemento
        }
    }
}


function clicou() {
    let firstName = document.querySelector('input#primeiro-nome').value
    const lastName = document.querySelector('input#ultimo-nome').value
    const email = document.querySelector('input#email').value
    const password = document.querySelector('input#senha')

    // if (!firstName || !lastName || !email || !password) {
    //     alert('Submeta todos os campos.')
    // }

    // if (firstName[0] !== firstName[0].toUpperCase()) {
    //     alert('O primeiro caracter precisa ser maiúsculo!')
    // }

    // if (password.value.length >= 8) {
    //     password.style.border = '2px solid green'
    //     alert('Senha correta!')
    // } else {
    //     password.style.border = '2px solid red'
    //     alert('Senha incorreta!')
    // }
}

const btn = document.querySelector('input[type=button]')
btn.addEventListener('click', clicou)

function alterar() {
    let firstName = document.querySelector('input#primeiro-nome')
    for (var c = 0; c <= firstName.value.length; c++) {
        if (c % 2 == 0) {
            firstName[c].innerText = firstName[c].toUpperCase()
        } else {
            firstName[c].innerText = firstName[c].toLowerCase()
        }
    }
}
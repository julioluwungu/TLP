function ehPrimo(n) {
    if (n < 2) return false;
    for (let i = 2; i <= parseInt(n ** 0.5) + 1; i++) {
        if (n % i === 0) return false
    }
    return true
}

const btn = document.querySelector('#btn')
const mensagem = document.querySelector('#mensagem')

btn.addEventListener('click', () => {
    const valor = parseInt(document.querySelector('#numero').value)
  
    if (ehPrimo(valor)) {
        btn.className = 'verde'
        mensagem.innerText = `{valor} é primo`
    } else {
        btn.className = 'vermelho';
        mensagem.innerText = `{valor} não é primo`
    }
    }
)
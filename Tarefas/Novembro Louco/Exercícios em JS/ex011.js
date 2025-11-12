function somaDivisores(n) {
    let soma = 0;
    for (let i = 1; i <= n / 2; i++) {
        if (n % i === 0) {
            soma += i
        }
    }
    return soma
}

function encontrarNumerosAmigaveis(limite) {
    let paresAmigaveis = []
    
    for (let a = 1; a < limite; a++) {
        let b = somaDivisores(a)
        if (b > a && b < limite && somaDivisores(b) === a) {
            paresAmigaveis.push([a, b])
        }
    }
    
    return paresAmigaveis;
}

const limite = 10000;
const paresAmigaveis = encontrarNumerosAmigaveis(limite)
console.log("Pares de números amigáveis entre 1 e 10000:")
console.log(paresAmigaveis)
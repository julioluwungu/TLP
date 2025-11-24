let fibonacci = [0, 1]

for (let c = 2; c < 15; c++) {
    let proximoTermo = fibonacci[c - 1] + fibonacci[c - 2]
    fibonacci.push(proximoTermo)
}

console.log('Os 15 primeiros termos da sequência de Fibonacci são:')
fibonacci.forEach(termo => console.log(termo))
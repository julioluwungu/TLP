let valores = []

for (let num = 1000; num <= 9999; num++) {
    let strnum = num.toString()
    let parte1 = Number(strnum[0] + strnum[1])
    let parte2 = Number(strnum[2] + strnum[3])
    let resultado = (parte1 + parte2) ** 2
    if (resultado == num) valores.push(num)
}

console.log('Os números que seguem a regra são: ')

valores.forEach(num => console.log(num))
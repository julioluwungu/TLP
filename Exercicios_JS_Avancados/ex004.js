function reduzirObjeto(obj, chavePai = '', resultado = {}) {
    for (let chave in obj) {
        const novaChave = chavePai ? `${chavePai}.${chave}` : chave

        if (typeof obj[chave] === 'object' && obj[chave] !== null) {
            reduzirObjeto(obj[chave], novaChave, resultado)
        } else {
            resultado[novaChave] = obj[chave]
        }
    }
    return resultado
}

const dict = { user: { name: 'Ana', age: 20 } }
const saida = reduzirObjeto(dict)
console.log(saida)
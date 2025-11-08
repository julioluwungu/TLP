function clonarObj(obj) {
    return JSON.parse(JSON.stringify(obj))
}

const obj = { name: 'Ana', endereco: { cidade: 'Luanda' } }
const clone = clonarObj(obj)

clone.endereco.cidade = 'Lisboa'

console.log('Objeto original:', obj)
console.log('Cópia clonada:', clone)
let lista = [
    [1, 2],
    [3, 4],
    [5, [6, 7, [8, [9, 10]]]]
]

// function desfazer (array) {
//     return aux = array.flatMap(num => Array.isArray(num)? desfazer(num): num * 2)
// }

// const desfazer = (array) => array.flatMap(num => Array.isArray(num)? desfazer(num): num * 2)
// let resultado = desfazer(lista)
// console.log(resultado)

function desfazer (array) {
    let resultado = array.flatMap(num => Array.isArray(num)? desfazer(num): num)
    return resultado
}

console.log(desfazer(lista))

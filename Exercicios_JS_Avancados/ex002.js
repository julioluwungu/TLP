let vetor = [1,[2,[3,[4]]]]

let reduzir = (array) => array.flatMap(num => Array.isArray(num)? reduzir(num): num)

console.log(reduzir(vetor))
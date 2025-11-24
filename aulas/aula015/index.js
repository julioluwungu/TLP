function principal() {
    let dados = []

    for (let c = 0; c < 10; c++) {
        let nome = prompt(`Digite o nome da ${c+1} pessoa: `)
        let sexo
        while (true) {
            sexo = prompt('Digite o seu sexo [M/F]: ')
            if (['M', 'F'].includes(sexo.toUpperCase())) break
            else console.log('Sexo incorreto. Digite "M" ou "F"')
        }
        dados.push({nome, sexo})
    }
}
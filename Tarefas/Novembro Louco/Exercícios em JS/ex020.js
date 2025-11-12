for (let i = 1; i <= 10; i++) {
    let sequencia = `${i}, `
    for (let j = 1; j <= 10; j++) {
        sequencia += j
        if (j < 10) {
            sequencia += ' '
        }
    }
    console.log(sequencia)
}
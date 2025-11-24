function atualizarHora() {
    let agora = new Date()
    let horas = String(agora.getHours()).padStart(2, '0')
    let minutos = String(agora.getMinutes()).padStart(2, '0')
    let segundos = String(agora.getSeconds()).padStart(2, '0')

    let horaFormatada = `${horas}:${minutos}:${segundos}`
    console.log(horaFormatada)
}

setInterval(atualizarHora, 1000)
setInterval(setDate, 1000)

const hour = document.querySelector('[date-hour-hand]')
const min = document.querySelector('[date-minute-hand]')
const sec = document.querySelector('[date-second-hand]')

function setDate() {
    const currentDate = new Date()
    const seconds = currentDate.getSeconds() / 60
    const minutes = (seconds + currentDate.getMinutes()) / 60
    const hours = (minutes + currentDate.getHours()) / 12
    setRotation(sec, seconds)
    setRotation(min, minutes)
    setRotation(hour, hours)
}

function setRotation(element, rotationRadio) {
    element.style.setProperty('--rotation', rotationRadio * 360)
}

setDate()
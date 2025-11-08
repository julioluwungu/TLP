async function executePromises(promises) {
    for (const promise of promises) {
        await promise()
    }
}

const f1 = () => new Promise(resolve => setTimeout(() => {
    console.log('Primeira')
    resolve()
}, 1000))

const f2 = () => new Promise(resolve => setTimeout(() => {
    console.log('Segunda')
    resolve()
}, 500))

executePromises([f1, f2])
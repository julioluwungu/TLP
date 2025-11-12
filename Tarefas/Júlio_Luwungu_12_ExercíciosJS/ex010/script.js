document.getElementById('login').addEventListener('submit', function(event) {
    event.preventDefault();

    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;

    if (email && password) {
        localStorage.setItem('userEmail', email);
        document.getElementById('res').textContent = 'Login realizado com sucesso!';
        
        setTimeout(() => {
            window.location.href = 'bemvindo.html';
        }, 1000);
    } else {
        document.getElementById('res').textContent = 'Preencha todos os campos!';
    }
});
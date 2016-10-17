let btn = document.getElementById('btn');
let body = document.body;
btn.addEventListener('click', ev => {
    var popup = new Promise((res, rej) => {
        btn.disabled = true;
        let div = document.createElement('div');

        div.className += ' popup';
        div.innerHTML = 'redirecting to telerik academy';

        body.appendChild(div);

        setTimeout(res, 5000)
    })

    popup.then(() => {
        window.location = 'http://www.telerikacademy.com';
    })
})
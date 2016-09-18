let nav = document.getElementById('nav'),
    container = document.getElementById('container');

nav.addEventListener('click', ev => {
    if (ev.target instanceof HTMLAnchorElement) {
        let name = ev.target.dataset.name;
        getPartial(`./partials/${name}.html`).then(data => {
            container.innerHTML = data;
            return getPartial(`./scripts/${name}.js`);
        }).then(data => eval(data));
    }
});

function getPartial(url) {
    return new Promise((res, rej) => {
        let request = new XMLHttpRequest();
        request.open('GET', url, true);
        request.onreadystatechange = () => {
            if (request.readyState == 4) {
                res(request.responseText)
            }
        };
        request.send(null);
    })
}
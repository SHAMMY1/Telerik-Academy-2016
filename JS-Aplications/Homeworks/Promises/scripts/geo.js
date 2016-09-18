let button = document.getElementById('btn'),
    img = document.getElementById('img');

button.addEventListener('click', onButtonClick);


function onButtonClick(ev) {
    function getLocation() { 
        return new Promise(res => {
        navigator.geolocation.getCurrentPosition(data => res(data.coords))
    })};

    function renderMap(coords){
        return new Promise(res => {
            img.src = `https://maps.googleapis.com/maps/api/staticmap?center=${coords.latitude},${coords.longitude}&zoom=18&size=600x600`;
        })
    }

    getLocation().then(coordinates => {
        return renderMap(coordinates);
    })
}

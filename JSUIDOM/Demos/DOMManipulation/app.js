document.documentElement.style.background = 'black';
let div = document.getElementById('wrapper'),
select1 = document.getElementById('select1');
select2 = document.getElementById('select2');
select3 = document.getElementById('select3');
select4 = document.getElementById('select4');
value = document.getElementById('value');
select1.min = 25;
select1.max = 480;
select2.min = 0;
select2.max = 255;
select3.min = 0;
select3.max = 255;
select4.min = 0;
select4.max = 255;
select1.value = select1.min;
select2.value = select2.min;
select3.value = select3.min;
select4.value = select4.min;
div.style.color = 'white';
div.classList.add('bacground-black');
select1.addEventListener('input', ev => {
div.style.height = select1.value +'px';
})

select2.addEventListener('input', ev => {
   value.innerText =  `R:${select2.value}   G:${select3.value}   B:${select4.value}` ;
div.style.background = '#' + ('00' + parseInt(select2.value).toString(16)).slice(-2) +('00' + parseInt(select3.value).toString(16)).slice(-2) + ('00' + parseInt(select4.value).toString(16)).slice(-2);
})

select3.addEventListener('input', ev => {
   value.innerText =  `R:${select2.value}   G:${select3.value}   B:${select4.value}` ;
    
div.style.background = '#' + ('00' + parseInt(select2.value).toString(16)).slice(-2) +('00' + parseInt(select3.value).toString(16)).slice(-2) + ('00' + parseInt(select4.value).toString(16)).slice(-2);
})
select4.addEventListener('input', ev => {
    value.innerText =  `R:${select2.value}   G:${select3.value}   B:${select4.value}` ;
    
div.style.background = '#' + ('00' + parseInt(select2.value).toString(16)).slice(-2) +('00' + parseInt(select3.value).toString(16)).slice(-2) + ('00' + parseInt(select4.value).toString(16)).slice(-2);
})
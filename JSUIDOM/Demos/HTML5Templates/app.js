var promise =new Promise((res, rej) => {
    $.getJSON('http://api.openweathermap.org/data/2.5/forecast?units=metric&q=Sofia&appid=cc7ee3c0f42152e53ac8cd034e33b9cc').done(json => res(json))
});
var test;
var source = $('#template').html();
Handlebars.registerHelper('ifModule', (con, options)=>{

var date = new Date(con);
var houre = date.getHours();
var isDay = true;

if (houre < 6 || houre >= 18) {
    isDay = false
}

    if(isDay) return options.fn(this);

    return options.inverse(this);
})
var template = Handlebars.compile(source);
promise.then(json => {
    $('#wrapper').html(template(json));
    test = json;
});
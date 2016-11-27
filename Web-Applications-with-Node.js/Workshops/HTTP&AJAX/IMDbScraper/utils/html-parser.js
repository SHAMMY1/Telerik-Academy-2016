const window = require("jsdom").jsdom().defaultView;
const $ = require("jquery")(window);

module.exports.parseSimpleMovies = (selector, html) => {
    $("body").html(html);

    let items = [];

    $(selector).each((i, value) => {

        let $value = $(value);

        items.push({
            title: $value.html(),
            url: "http://www.imdb.com" + $value.attr("href")
        });
    });

   return  Promise.resolve(items);
}
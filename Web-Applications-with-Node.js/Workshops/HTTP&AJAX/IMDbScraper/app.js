"use strict"

class Query {
    constructor() {
        this._items = [];
    }

    enque(item) {
        this._items.push(item);
    }

    deque() {
        return this._items.shift();
    }
    peek() {
        return this._items[0];
    }

    get length() {
        return this._items.length;
    }
}

const genres = ["fantasy", "horror", "comedy", "action"];
const urls = new Query();
let count = 3;
genres.forEach((genre, index) => {
    for (let i = 1; i <= count; i += 1) {
        let listMoviesUrl = `http://www.imdb.com/search/title?genres=${genre}&title_type=feature&0sort=moviemeter,asc&page=${i+1}&view=simple&ref_=adv_nxt`;

        urls.enque(listMoviesUrl);
    }
});
const requester = require("./utils/http-requester");
const htmlPearser = require("./utils/html-parser");

getMoviesFromUrl(urls);

function getMoviesFromUrl(urls) {
    requester.get(urls.deque()).then(result => {
        let selector = ".col-title span[title] a",
            next = htmlPearser.parseSimpleMovies(selector, result.body);

        return next;
    }).then(movies => {
        console.dir(movies, { colors: true });
        if(urls.peek()){
        getMoviesFromUrl(urls);
        }
    }).catch(err => {
        console.dir(err, { colors: true });
    })
}
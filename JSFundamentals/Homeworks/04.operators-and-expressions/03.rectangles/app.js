function solve(params) {
    var width = parseFloat(params[0]);
    var height = parseFloat(params[1]);

    var area = width * height;
    var perimeter = width * 2 + height * 2;

    return area.toFixed(2) + ' ' + perimeter.toFixed(2);
}

console.log(solve([2.5 , 3]));


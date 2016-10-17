function solve(params) {
    var first = parseFloat(params[0]);
    var second = parseFloat(params[1]);
    var third = parseFloat(params[2]);

    if (first < second) {
        var temp = first;
        first = second;
        second = temp;

    }
    if (second < third) {
        var temp = second;
        second = third;
        third = temp;
        if (first < second) {
            var temp = first;
            first = second;
            second = temp;
        }
    }

    return first + ' ' + second + ' ' + third;
}

console.log(solve([0, -2.5, 5]));

function solve(params) {
    var first = parseFloat(params[0]);
    var second = parseFloat(params[1]);
    var third = parseFloat(params[2]);

    if (first > second) {
        if (first > third) {
            return first;
        }
    } else {
        if (second > third) {
            return second;
        }
    }
    return third;
}
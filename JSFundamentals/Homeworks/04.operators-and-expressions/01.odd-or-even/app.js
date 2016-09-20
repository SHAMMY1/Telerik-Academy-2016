function solve(params) {
    var number = params[0];

    var isEven = number% 2 === 0;

    if (isEven) {
        return "even " + number;
    }

    return "odd " + number;
}

console.log(solve([2]));
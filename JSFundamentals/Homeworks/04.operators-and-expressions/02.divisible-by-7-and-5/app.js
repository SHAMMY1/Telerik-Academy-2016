function solve(params) {
    var number = parseInt(params[0])

    if (number % 7 === 0 && number % 5 ===0) {
        return "true " + number;
    }

    return "false " + number;
}

console.log(solve(["10"]));
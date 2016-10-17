function solve(params) {
    var number = params[0];

    var thirdDigit = (Math.flo( number / 100)) % 10;

    var isSeven = thirdDigit === 7;

    if (isSeven) {
        return 'true';
    }

    return 'false ' + thirdDigit;
}

console.log(solve([5]));

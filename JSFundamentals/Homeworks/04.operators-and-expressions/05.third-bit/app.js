function solve(params) {
    var number = params[0];

    var thirdBit = ((1 << 3) & number) >> 3;

    console.log(thirdBit);
}

solve([13413131231])
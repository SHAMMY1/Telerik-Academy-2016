function solve(params) {
    var firstNumber = parseFloat(params[0]);
    var secondNumber = parseFloat(params[1]);
    var thirdNumber = parseFloat(params[2]);

    if (firstNumber === 0 || secondNumber === 0 || thirdNumber === 0) {
       return  '0';
    }

    if (firstNumber > 0) {
        if (secondNumber > 0) {
            if (thirdNumber > 0) {
                return '+';
            }
            return '-';
        }
        else {
            if (thirdNumber < 0) {
                return '+';
            }
        }
        return '-'
    }
    else {
        if (secondNumber > 0) {
            if (thirdNumber < 0) {
                return '+';
            }
            return '-'
        }else {
            if (thirdNumber > 0) {
                return '+'
            }
        }

        return '-';
    }
}

console.log(solve([0, -2,5, 4]));

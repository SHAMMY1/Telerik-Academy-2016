function solve(params) {
    var firstNumber = parseFloat(params[0]);
    var secondNumber = parseFloat(params[1]);

    if (firstNumber > secondNumber) {
        var oldFIrstValue = firstNumber;
        firstNumber = secondNumber;
        secondNumber = oldFIrstValue;
    }

    return firstNumber + ' ' + secondNumber;
}
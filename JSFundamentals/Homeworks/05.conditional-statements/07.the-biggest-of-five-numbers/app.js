function solve(params) {
    var numA = +params[0];
    var numB = +params[1];
    var numC = +params[2];
    var numD = +params[3];
    var numE = +params[4];

    var bigger = numA;

    if (bigger < numB) {
        bigger = numB;
    }
    if (bigger < numC) {
        bigger = numC;
    }
    if (bigger < numD) {
        bigger = numD;
    }
    if (bigger < numE) {
        bigger = numE;
    }

    return bigger;
}
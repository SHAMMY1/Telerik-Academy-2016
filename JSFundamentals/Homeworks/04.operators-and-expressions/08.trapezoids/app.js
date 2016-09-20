function solve(params) {
    var trapezoid = {
        a: parseFloat(params[0]),
        b: parseFloat(params[1]),
        h: parseFloat(params[2])
    }

    var area = ((trapezoid.a + trapezoid.b) / 2) * trapezoid.h;

    return area.toFixed(7);
}
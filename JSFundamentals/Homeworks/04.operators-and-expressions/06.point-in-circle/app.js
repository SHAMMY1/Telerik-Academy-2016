function solve(params) {
    var point = {
        x : params[0],
        y: params[1]
    }

    var distanceToCenter = Math.sqrt(point.x * point.x + point.y * point.y);

    if (distanceToCenter > 2) {
        return 'no ' + distanceToCenter.toFixed(2);
    }

    return 'yes ' + distanceToCenter.toFixed(2);
}

console.log(solve([-2, 0]));

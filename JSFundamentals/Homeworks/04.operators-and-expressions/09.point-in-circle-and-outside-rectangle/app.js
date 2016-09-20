function solve(params) {
    var point = {
        x: +params[0],
        y: +params[1]
    }

    var circle = {
        x: 1,
        y: 1,
        radius: 1.5
    }

    var rect = {
        top: 1,
        left: -1,
        width: 6,
        height: 2
    }

    var result = '';

    var distanceToCircleCenter = Math.sqrt( Math.pow(2, point.x - circle.x) + Math.pow(2 , point.y - circle.y));

    if(distanceToCircleCenter > circle.radius) {
        result += 'outside ';
    }else {
        result += 'inside ';
    }

    result += 'circle ';

    if((point.x < rect.left) || 
       (point.x > (rect.left + rect.width)) || 
       (point.y < rect.top) || 
       (point.y > (rect.top - rect.height))) {

           result += 'outside ';
    }else {
        result += 'inside ';
    }

    result += 'rectangle';
    return result;
}

console.log(solve([2.5, 2]));

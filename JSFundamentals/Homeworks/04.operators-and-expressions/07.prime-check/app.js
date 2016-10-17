function solve(params) {
    var number = parseInt(params[0]);

    if (number <= 0) {
        return false;
    }

    for(let i = 2; i < number; i+=1){
        if (number % i === 0) {
            return false;
        }
    }

    return true;
}
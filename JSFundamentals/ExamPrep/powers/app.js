function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        result = 0;
    while (nk[1] > 0){
        var newS = [];
        
        for (var index = 0; index < s.length; index++) {
            var currentNumber;
             var nextIndex = index + 1;
             var beforeIndex = index - 1;

             if (nextIndex >= s.length) {
                 nextIndex = 0;
             }

             if (beforeIndex < 0) {
                 beforeIndex = s.length - 1;
             }
            if (s[index] == 0) {
               var currentResult = s[beforeIndex] - s[nextIndex];
               if (currentResult < 0) {
                   currentResult *= -1;
               }

               currentNumber = currentResult;
            } else if (s[index] == 1) {
                currentNumber = s[beforeIndex] + s[nextIndex];
            } else if(s[index] % 2 == 0) {
                var max = s[beforeIndex];
                if (max < s[nextIndex]) {
                    max = s[nextIndex];
                }

                currentNumber = max;
            }else {
                var min = s[beforeIndex];
                if (min > s[nextIndex]) {
                    min = s[nextIndex];
                }

                currentNumber = min;
            }
            newS[index] = currentNumber;
        }
        s = newS;
        nk[1]--;
    }

    for (var index = 0; index < s.length; index++) {
        var element = s[index];
        result += element;
    }
    console.log(result);
}

solve(["5 1", "9 0 2 4 1"])
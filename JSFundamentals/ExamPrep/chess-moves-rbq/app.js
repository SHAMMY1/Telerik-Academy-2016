function solve(params) {
    var r = +params[0];

    var board = params.slice(2, 2 + r);
    var comands = params.slice(3 + r);

    function parseMove(move) {
        var cells = move.split(' ');
        var result = {
            from: {
                row: r - (+cells[0][1]),
                col: cells[0].charCodeAt(0) - 97
            },
            to: {
                row: r - (+cells[1][1]),
                col: cells[1].charCodeAt(0) - 97
            }
        };
        return result;
    }

    function canMoveRook(move) {
        if ((move.from.row !== move.to.row) && (move.from.col !== move.to.col)) {
            return false;
        }



        var deltaRow = move.from.row > move.to.row ? -1 : (move.from.row === move.to.row ? 0 : 1);
        var deltaCol = move.from.col > move.to.col ? -1 : (move.from.col === move.to.col ? 0 : 1);

        if (deltaRow === 0 && deltaCol === 0) {
            return false;
        }

        while ((move.from.row !== move.to.row) || (move.from.col !== move.to.col)) {
            move.from.row += deltaRow;
            move.from.col += deltaCol;

            if (board[move.from.row][move.from.col] !== '-') {
                return false;
            }
        }

        return true;
    }

    function canMoveBishop(move) {
        if (Math.abs(move.from.row - move.to.row) != Math.abs(move.from.col - move.to.col)) {
            return false;
        }

        var deltaRow = move.from.row > move.to.row ? -1 : 1;
        var deltaCol = move.from.col > move.to.col ? -1 : 1;

        if (deltaRow === 0 && deltaCol === 0) {
            return false;
        }

        while ((move.from.row !== move.to.row) || (move.from.col !== move.to.col)) {
            move.from.row += deltaRow;
            move.from.col += deltaCol;

            if (board[move.from.row][move.from.col] !== '-') {
                return false;
            }

        }
        return true;
    }
    function canMoveQueen(move) {
        var canB = canMoveBishop(move);
        var canR = canMoveRook(move);
        return canB || canR;
    }

    var checkMove = {
        'B': canMoveBishop,
        'Q': canMoveQueen,
        'R': canMoveRook
    }

    for (var i = 0; i < comands.length; i += 1) {
        var move = parseMove(comands[i]);

        var piece = board[move.from.row][move.from.col];

        if (piece === 'B' || piece ==='Q' || piece === 'R') {
            if (checkMove[piece](move)) {
                console.log('yes');

            } else {
                console.log('no');
            }
        } else {
            console.log('no');
        }

    }
}



var test1 = [
    '3',
    '4',
    '--R-',
    'B--B',
    'Q--Q',
    '12',
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 b3',
    'd2 c1',
    'b1 b2',
    'c3 b1',
    'a2 a3',
    'd1 d3'

];

var test2 = [
    '5',
    '5',
    'Q---Q',
    '-----',
    '-B---',
    '--R--',
    'Q---Q',
    '10',
    'a1 a1',
    'a1 d4',
    'e1 b4',
    'a5 d2',
    'e5 b2',
    'b3 d5',
    'b3 a2',
    'b3 d1',
    'b3 a4',
    'c2 c5'
];

var test3 = [
    '9',
    '9',
    '--------B',
    '--Q------',
    '------Q--',
    '-R------R',
    '---------',
    '-----Q--R',
    '---------',
    '---B-----',
    '-B-------',
    '10',
    'i9 h8',
    'i9 g7',
    'g7 g1',
    'd2 e3',
    'i4 a4',
    'i6 i1',
    'i6 i5',
    'f4 d6',
    'c8 i2',
    'r6 b1'
];


console.log(solve(test3));
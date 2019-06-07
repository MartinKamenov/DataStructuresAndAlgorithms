// Given an double array we should find the smallest path to the bottom-right end
// starting from the top-left cell
// If array includes the symbol 'x' then this is not a path program can take

const directionCollectibles = [
    {
        rowCollectable: -1,
        colCollectable: 0
    },
    {
        rowCollectable: 0,
        colCollectable: -1
    },
    {
        rowCollectable: 1,
        colCollectable: 0
    },
    {
        rowCollectable: 0,
        colCollectable: 1
    }
];

const arraySearch = (arr) => {
    return findClosesPath(arr, 0, 0, 0, -1, {});
};

const findClosesPath = (arr, row, col, moves, previousCells) => {
    if(row < 0 || row >= arr.length || col < 0 || col >= arr[row].length || arr[row][col] === 'x') {
        return Number.MAX_SAFE_INTEGER;
    }

    if(row === arr.length - 1 && col === arr[row].length - 1) {
        return moves;
    }

    let minimalMoves = Number.MAX_SAFE_INTEGER;
    for(let i = 0; i < 4; i++) {
        const newRow = row + directionCollectibles[i].rowCollectable;
        const newCol = col + directionCollectibles[i].colCollectable;

        if(previousCells[newRow + newCol + '']) {
            continue;
        }

        const newCells = Object.assign({}, previousCells);
        newCells[newRow + newCol + ''] = true;
        const foundMoves = findClosesPath(arr, newRow, newCol, moves + 1, newCells);
        if(foundMoves < minimalMoves) {
            minimalMoves = foundMoves;
        }
    }

    return minimalMoves;
};

module.exports = arraySearch;
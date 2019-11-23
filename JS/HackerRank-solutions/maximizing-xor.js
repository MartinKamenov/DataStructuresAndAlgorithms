const maximizeXor = (l, r) => {
    let maximalXor = 0;
    for(let i = l; i <= r; i++) {
        for(let j = l; j <= i; j++) {
            const currentResult = i ^ j;
            if(currentResult > maximalXor) {
                maximalXor = currentResult;
            }
        }
    }

    return maximalXor;
}

console.log(maximizeXor(10, 15))
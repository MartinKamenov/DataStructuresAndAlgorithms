const getMoneySpent = (keyboards, drives, b) => {
    keyboards = keyboards.sort((a, b) => b - a);
    drives = drives.sort((a, b) => b - a);

    let max = -1;
    for(let i = 0; i < keyboards.length; i++) {
        const found = drives.find((d) => (d + keyboards[i] <= b));
        if(found && (found + keyboards[i] > max)) {
            max = found + keyboards[i];
        }
    }

    return max;
}

console.log(getMoneySpent([3, 1], [5, 2, 8], 10));
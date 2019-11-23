const lonelyInteger = (a) => {
    const result = a.reduce((prev, current) => {
        const indexOfPrevious = prev.lastArr.indexOf(current);
        if(indexOfPrevious === -1) {
            prev.found.push(current);
        } else {
            prev.found.splice(prev.found.indexOf(current), 1);
        }
        prev.lastArr.push(current);

        return prev;
    },  { found: [], lastArr: [] });

    return result.found[0];
}

console.log(lonelyInteger([0, 0, 1, 2, 1]));
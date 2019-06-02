Array.prototype.mergeSort = function() {
    const arr = this;
    if(arr.length <= 1) {
        return arr;
    }
    const left = arr.slice(0, arr.length / 2);
    const right = arr.slice(arr.length / 2, arr.length);

    const sortedLeft = left.mergeSort();
    const sortedRight = right.mergeSort();

    const mergedArray = [];

    let leftIndex = 0;
    let rightIndex = 0;
    for(let i = 0; i < arr.length; i++) {
        if(rightIndex >= sortedRight.length) {
            mergedArray.push(sortedLeft[leftIndex++]);
        } else if(leftIndex >= sortedLeft.length) {
            mergedArray.push(sortedRight[rightIndex++]);
        } else if(leftIndex < sortedLeft.length && sortedLeft[leftIndex] <= sortedRight[rightIndex]) {
            mergedArray.push(sortedLeft[leftIndex++]);
        } else {
            mergedArray.push(sortedRight[rightIndex++]);
        }
    }

    return mergedArray;
};

Array.prototype.quickSort = function() {
    const arr = this;
    if(arr.length <= 1) {
        return arr;
    }

    const pivot = arr[0];
    const left = [];
    const right = [];

    for(let i = 1; i < arr.length; i++) {
        if(arr[i] < pivot) {
            left.push(arr[i]);
        } else {
            right.push(arr[i]);
        }
    }

    const sortedLeft = left.quickSort();
    const sortedRight = right.quickSort();

    sortedLeft.push(pivot);
    const finalArray = sortedLeft.concat(sortedRight);
    return finalArray;
};

console.log([10, 9, 8, 1, 12, 13, -10, -1].quickSort());
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

Array.prototype.bubbleSort = function() {
    const copyOfArr = this.slice(0, this.length);
    for(let i = copyOfArr.length - 1; i >= 0; i--) {
        for(let j = 0; j < i; j++) {
            if(copyOfArr[j] > copyOfArr[j + 1]) {
                const swap = copyOfArr[j];
                copyOfArr[j] = copyOfArr[j + 1];
                copyOfArr[j + 1] = swap;
            }
        }
    }

    return copyOfArr;
};

const countingSort = function(arr) {
    let min = Number.MAX_SAFE_INTEGER;
    let max = Number.MIN_SAFE_INTEGER;

    for(let i = 0; i < arr.length; i++) {
        if(arr[i] > max) {
            max = arr[i];
        }

        if(arr[i] < min) {
            min = arr[i];
        }
    }

    const memoArr = [];
    for(let i = min; i < max + 1; i++) {
        memoArr[i - min] = 0;
    }

    for(let i = 0; i < arr.length; i++) {
        memoArr[arr[i] - min]++;
    }

    let memoObjects = [];
    memoArr.forEach((el, i) => memoObjects.push(
        {
            found: el,
            number: i + min
        }
    ));

    memoObjects = memoObjects.filter((el) => el.found !== 0).sort((a, b) => {
        if(a.found === b.found) {
            return a.number - b.number;
        }
        else {
            return a.found - b.found;
        }
    });
    const finalArr = [];
    for(let i = 0; i < memoObjects.length; i++) {
        const el = memoObjects[i];
        for(let j = 0; j < el.found; j++) {
            finalArr.push(el.number);
        }
    }

    console.log(finalArr.join('\n'));

    // const sortedArr = [];

    // for(let i = 0; i < memoArr.length; i++) {
    //     for(let j = 0; j < memoArr[i]; j++) {
    //         sortedArr.push(i + min);
    //     }
    // }

    // return sortedArr;
};

const sorted = countingSort([4, 5, 6, 5, 4, 3, -5, -5, -100]);
console.log(sorted.join('\n'));
// 3, 6, 4, 4, 5, 5

Array.prototype.selectionSort = function() {
    const arr = this.slice(0, this.length);
    
    for(let i = 0; i < arr.length; i++) {
        let min = Number.MAX_SAFE_INTEGER;
        let minIndex = 0;
        for(let j = i; j < arr.length; j++) {
            if(arr[j] < min) {
                min = arr[j];
                minIndex = j;
            }
        }

        const swap = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = swap;
    }

    return arr;
};
// Q: How do you find the missing number in a given integer array of 1 to 100?
// A: Using counting sort...

const findMissingNumber = (arr) => {
    const countArray = [];
    
    arr.forEach((element) => {
        if(countArray[element] || countArray[element] === 0) {
            countArray[element]++;
        } else {
            countArray[element] = 1;
        }
    });

    const missingNumber = [...Array(100).keys()].slice(1, 100).find((i) => !countArray[i]);
    
    return missingNumber;
};

//console.log(findMissingNumber(numbers));
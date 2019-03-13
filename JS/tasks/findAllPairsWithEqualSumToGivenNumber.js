// Q: How do you find all pairs of an integer array whose sum is equal to a given number?
// A: 

const findPairs = (arr, num) => {
    const pairs = [];
    for(let i = 0; i < arr.length; i++) {
        for(let j = i + 1; j < arr.length; j++) {
            if(arr[i] + arr[j] === num) {
                pairs.push([arr[i], arr[j]]);
            }
        }
    }

    return pairs;
};

console.log(findPairs([2, 6, 3, 9, 11], 9));
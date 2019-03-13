// Q: How do you find the largest and smallest number in an unsorted integer array?
// A: Simply using two variables for biggest and smallest number and forEach the array.

const biggestAndSmallest = (arr) => {
    if(!arr.length) {
        return 'Array is empty';
    }

    let biggest = arr[0];
    let smallest = arr[0];

    arr.forEach(el => {
        if(el > biggest) {
            biggest = el;
        } else if(el < smallest) {
            smallest = el;
        }
    });

    return {
        biggest,
        smallest
    }
};

console.log(biggestAndSmallest([1, 50, -15, 1544, 45, 22, 22, 17, 33]));
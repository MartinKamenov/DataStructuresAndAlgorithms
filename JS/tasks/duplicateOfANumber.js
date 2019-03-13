// Q: How do you find the duplicate number on a given integer array?
// A: Again quick sort may be best using caching. Also if we are surching for first duplicate we
// won't need to go through all elements.

const duplicateOfANumber = (arr) => {
    const cachingObject = {};
    let duplicate = 0;
    arr.some((element) => {
        if(cachingObject[element]) {
            duplicate = element;
            return true;
        }

        cachingObject[element] = 1;
        return false;
    });
    
    return duplicate;
}

console.log(duplicateOfANumber([0, 8, 4, 4, 15, 8]));
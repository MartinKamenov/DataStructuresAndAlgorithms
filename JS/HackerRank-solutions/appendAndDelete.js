const build = (str, desired, steps, step, curr) => {
    if(curr) {
        return true;
    }
    if(step === steps) {
        return curr || str === desired;
    }

    if((steps - step) >= str.length + desired.length) {
        return true;
    }

    if(str === desired) {
        if((steps - step) % 2 === 0) {
            return true;
        } else {
            return false;
        }
    }

    let i = 0; 
    for(;i < desired.length; i++) {
        if(!str[i]) {
            return build(str, desired.substring(0, desired.length - 1), steps, step + 1, curr);
        } else if(str[i] !== desired[i]) {
            return build(str, desired.substring(0, desired.length - 1), steps, step + 1, curr);
        }
    }

    if(str[i]) {
        return build(str, desired + str[i], steps, step + 1, curr);
    }
}

const appendAndDelete = (s, t, k) => {
    return build(s, t, k, 0, false) ? 'Yes' : 'No';
};

console.log(appendAndDelete('abcdef', 'fedcba', 15));
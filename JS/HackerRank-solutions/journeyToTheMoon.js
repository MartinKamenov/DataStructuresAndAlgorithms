const journeyToMoon = (n, astronaut) => {
    let combinations = 0;
    astronaut = astronaut.reduce((acc, curr) => {
        if(!acc[curr[0]]) {
            acc[curr[0]] = [curr[1]];
        } else {
            acc[curr[0]].push(curr[1]);
        }

        if(!acc[curr[1]]) {
            acc[curr[1]] = [curr[0]];
        } else {
            acc[curr[1]].push(curr[0]);
        }
        return acc;
    }, {});

    const visited = {};
    let result = [];
    let finalResult = [];

    const dfs = (num) => {
        visited[num] = true;
        result.push(num);

        if(astronaut[num]) {
            astronaut[num].forEach((n) => visited[n] || dfs(n));
        }
    }

    for(let i = 0; i < n; i++) {
        if(visited[i]) {
            continue;
        }

        result = [];
        dfs(i);
        combinations += result.length;
        finalResult.push(result);
    }
    
    const res = finalResult.reduce((acc, curr, i) => {
        combinations -= curr.length;
        acc += combinations * curr.length;

        return acc;
    }, 0);
    return res;
};

console.log(journeyToMoon(100000,
    [
        [1, 2],
        [3, 4],
    ]
));

/*
4

0, 1
0, 3,
1, 2
3, 1,
2, 3
*/
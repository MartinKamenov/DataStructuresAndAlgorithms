const roadsAndLibraries = (n, c_lib, c_road, cities) => {
    const visited = {};
    let result = [];

    cities = cities.reduce((acc, road) => {
        if(!acc[road[0]]) {
            acc[road[0]] = [road[1]];
        } else {
            acc[[road[0]]].push(road[1]);
        }

        if(!acc[road[1]]) {
            acc[road[1]] = [road[0]];
        } else {
            acc[[road[1]]].push(road[0]);
        }

        return acc;
    }, {});

    const dfs = (city) => {
        visited[city] = true;
        result.push(city);

        if(cities[city] && cities[city].length) {
            cities[city].forEach((c) => visited[c] || dfs(c));
        }
    }

    let sum = 0;
    for(let curr = 1; curr <= n; curr++) {
        if(visited[curr]) {
            continue;
        }

        result = [];
        dfs(curr);

        if(result.length > 1) {
            sum += Math.min((c_road * (result.length - 1)) + c_lib, c_lib * result.length);
        } else {
            sum += c_lib;
        }
    }

    return sum;
};

console.log(roadsAndLibraries(
    9, 1, 1, [
        [1, 2],
        [1, 3],
    ]
));
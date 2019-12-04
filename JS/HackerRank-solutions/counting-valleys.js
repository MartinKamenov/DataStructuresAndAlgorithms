const countingValleys = (n, s) => {
    const steps = s.split('');
    const result = steps.reduce((prev, current) => {
        const newStep = current === 'U' ? 1 : -1;
        prev.seaLevel += newStep;
        if(prev.seaLevel === 0 && newStep === 1) {
            prev.numberOfValeys++;
        }

        return prev;
    }, { seaLevel: 0, numberOfValeys: 0 });

    return result.numberOfValeys;
}

console.log(countingValleys(8, 'UDDDUDUU'));
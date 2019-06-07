const arraySearch = require('../graphs/arraySearch');
const assert = require('chai').assert;
let startTime;

beforeEach(function(done) {
    // Setup
    startTime = new Date();
    done();
});

afterEach(function(done) {
    const endTime = new Date();
    console.log(endTime - startTime + ' miliseconds');
    done();
});

describe('Array search task', function () {
    it('should return 4 when route consists of four moves', function () {
        // Arrange
        const arr = [
            ['0', '0', 'x'],
            ['0', 'x', '0'],
            ['0', '0', '0']
        ];
        // Act
        const result = arraySearch(arr);
        // Assert
        assert.equal(result, 4);
    });
    it('should return 6 when route consists of six moves', function () {
        // Arrange
        const arr = [
            ['0', '0', 'x'],
            ['0', '0', '0'],
            ['x', 'x', '0'],
            ['x', 'x', '0'],
            ['x', 'x', '0']
        ];
        // Act
        const result = arraySearch(arr);
        // Assert
        assert.equal(result, 6);
    });
    it('should return 9 when route consists of nine moves', function () {
        // Arrange
        const arr = [
            ['0', '0', 'x'],
            ['x', '0', '0'],
            ['0', '0', '0'],
            ['0', 'x', 'x'],
            ['0', '0', 'x'],
            ['x', '0', '0']
        ];
        // Act
        const result = arraySearch(arr);
        // Assert
        assert.equal(result, 9);
    });
});
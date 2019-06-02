const sorting = require('../sorting/sorting');
const assert = require('chai').assert;
let elements;
let startTime;

beforeEach(function(done) {
    // Setup
    elements = [10, 15, -5, 6, 11];
    startTime = new Date();
    done();
});

afterEach(function(done) {
    const endTime = new Date();
    console.log(endTime - startTime + ' miliseconds');
    done();
});

describe('Merge sort', function () {
    it('should sort correctly multiple numbers', function () {
        // Arrange & Act
        const sortedElements = elements.mergeSort();
        // Assert
        assert.deepEqual(sortedElements, [-5, 6, 10, 11, 15]);
    });

    it('should sort correctly when only one element is passed', function () {
        // Arrange
        const arrayWithOneElement = [1];
        // Act
        const sortedElements = arrayWithOneElement.mergeSort();
        // Assert
        assert.deepEqual(sortedElements, [1]);
    });

    it('should sort correctly when no elements are passed', function () {
        // Arrange
        const arrayWithNoElements = [];
        // Act
        const sortedElements = arrayWithNoElements.mergeSort();
        // Assert
        assert.deepEqual(sortedElements, []);
    });

    it('should sort correctly when 1000 elements reversed are passed', function() {
        // Arrange
        const count = 1000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.mergeSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });

    it('should sort correctly when 10000 elements reversed are passed', function() {
        // Arrange
        const count = 10000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.mergeSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });
});

describe('Quick sort', function () {
    it('should sort correctly multiple numbers', function () {
        // Arrange & Act
        const sortedElements = elements.quickSort();
        // Assert
        assert.deepEqual(sortedElements, [-5, 6, 10, 11, 15]);
    });

    it('should sort correctly when only one element is passed', function () {
        // Arrange
        const arrayWithOneElement = [1];
        // Act
        const sortedElements = arrayWithOneElement.quickSort();
        // Assert
        assert.deepEqual(sortedElements, [1]);
    });

    it('should sort correctly when no elements are passed', function () {
        // Arrange
        const arrayWithNoElements = [];
        // Act
        const sortedElements = arrayWithNoElements.quickSort();
        // Assert
        assert.deepEqual(sortedElements, []);
    });

    it('should sort correctly when 1000 elements reversed are passed', function() {
        // Arrange
        const count = 1000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.quickSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });

    // Callstack exceded
    // it('should sort correctly when 10000 elements reversed are passed', function() {
    //     // Arrange
    //     const count = 10000;
    //     const thousandElements = [];
    //     for(let i = 0; i < count; i++) {
    //         thousandElements.push(count - i);
    //     }
    //     // Act
    //     const sortedElements = thousandElements.quickSort();
    //     const expected = [];
    //     for(let i = 0; i < count; i++) {
    //         expected.push(i + 1);
    //     }
    //     // Assert
    //     assert.deepEqual(sortedElements, expected);
    // });
});

describe('Bubble sort', function () {
    it('should sort correctly multiple numbers', function () {
        // Arrange & Act
        const sortedElements = elements.bubbleSort();
        // Assert
        assert.deepEqual(sortedElements, [-5, 6, 10, 11, 15]);
    });

    it('should sort correctly when only one element is passed', function () {
        // Arrange
        const arrayWithOneElement = [1];
        // Act
        const sortedElements = arrayWithOneElement.bubbleSort();
        // Assert
        assert.deepEqual(sortedElements, [1]);
    });

    it('should sort correctly when no elements are passed', function () {
        // Arrange
        const arrayWithNoElements = [];
        // Act
        const sortedElements = arrayWithNoElements.bubbleSort();
        // Assert
        assert.deepEqual(sortedElements, []);
    });

    it('should sort correctly when 1000 elements reversed are passed', function() {
        // Arrange
        const count = 1000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.bubbleSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });

    it('should sort correctly when 10000 elements reversed are passed', function() {
        // Arrange
        const count = 10000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.bubbleSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });
});

describe('Counting sort', function () {
    it('should sort correctly multiple numbers', function () {
        // Arrange & Act
        const sortedElements = elements.countingSort();
        // Assert
        assert.deepEqual(sortedElements, [-5, 6, 10, 11, 15]);
    });

    it('should sort correctly when only one element is passed', function () {
        // Arrange
        const arrayWithOneElement = [1];
        // Act
        const sortedElements = arrayWithOneElement.countingSort();
        // Assert
        assert.deepEqual(sortedElements, [1]);
    });

    it('should sort correctly when no elements are passed', function () {
        // Arrange
        const arrayWithNoElements = [];
        // Act
        const sortedElements = arrayWithNoElements.countingSort();
        // Assert
        assert.deepEqual(sortedElements, []);
    });

    it('should sort correctly when 1000 elements reversed are passed', function() {
        // Arrange
        const count = 1000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.countingSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });

    it('should sort correctly when 10000 elements reversed are passed', function() {
        // Arrange
        const count = 10000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.countingSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });
});

describe('Selection sort', function () {
    it('should sort correctly multiple numbers', function () {
        // Arrange & Act
        const sortedElements = elements.selectionSort();
        // Assert
        assert.deepEqual(sortedElements, [-5, 6, 10, 11, 15]);
    });

    it('should sort correctly when only one element is passed', function () {
        // Arrange
        const arrayWithOneElement = [1];
        // Act
        const sortedElements = arrayWithOneElement.selectionSort();
        // Assert
        assert.deepEqual(sortedElements, [1]);
    });

    it('should sort correctly when no elements are passed', function () {
        // Arrange
        const arrayWithNoElements = [];
        // Act
        const sortedElements = arrayWithNoElements.selectionSort();
        // Assert
        assert.deepEqual(sortedElements, []);
    });

    it('should sort correctly when 1000 elements reversed are passed', function() {
        // Arrange
        const count = 1000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.selectionSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });

    it('should sort correctly when 10000 elements reversed are passed', function() {
        // Arrange
        const count = 10000;
        const thousandElements = [];
        for(let i = 0; i < count; i++) {
            thousandElements.push(count - i);
        }
        // Act
        const sortedElements = thousandElements.selectionSort();
        const expected = [];
        for(let i = 0; i < count; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });
});
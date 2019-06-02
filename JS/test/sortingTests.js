const sorting = require('../sorting/sorting');
const assert = require('chai').assert;
let elements;

beforeEach(function(done) {
    // Setup
    elements = [10, 15, -5, 6, 11];
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

    it('should sort correctly when 1000 elements are passed', function() {
        // Arrange
        const thousandElements = [];
        for(let i = 0; i < 1000; i++) {
            thousandElements.push(1000 - i);
        }
        // Act
        const sortedElements = thousandElements.mergeSort();
        const expected = [];
        for(let i = 0; i < 1000; i++) {
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

    it('should sort correctly when 1000 elements are passed', function() {
        // Arrange
        const thousandElements = [];
        for(let i = 0; i < 1000; i++) {
            thousandElements.push(1000 - i);
        }
        // Act
        const sortedElements = thousandElements.quickSort();
        const expected = [];
        for(let i = 0; i < 1000; i++) {
            expected.push(i + 1);
        }
        // Assert
        assert.deepEqual(sortedElements, expected);
    });
});
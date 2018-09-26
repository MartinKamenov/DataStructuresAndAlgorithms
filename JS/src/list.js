class List {
    constructor() {
        this.buffer = [];
        this._size = 0;
    }

    add(element) {
        return this.buffer.push(element);
    }

    insert(index, element) {
        if (index < 0 || index > this.buffer.length) {
            return;
        }

        this.dataStore.splice(index + 1, 0, element);
        _size++;
    }

    contains(element) {
        const hasBeenFound = this.buffer.includes(function(el) {
            return el === element;
        });

        return hasBeenFound;
    }
    find(element) {
        const foundIndex = this.buffer.findIndex(function(el) {
            return el === element;
        });

        return foundIndex;
    }
    length() {
        return this._size;
    }
}

module.exports = List;
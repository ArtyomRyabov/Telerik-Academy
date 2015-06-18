function sum(nums) {
    if (nums.length === 0) {
        return null;
    }

    if (nums === undefined) {
        throw new Error('Array not passed!');
    }

    if (nums.some(function(num) {
            return isNaN(num);
        })) {
        throw new Error('Only numbers allowed!');
    }

    return nums.reduce(function(sum, num) {
        return sum += (+num);
    }, 0);
}

module.exports = sum;

/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

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

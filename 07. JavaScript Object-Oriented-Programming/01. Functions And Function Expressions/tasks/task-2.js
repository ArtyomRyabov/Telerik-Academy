/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(start, end) {
	var i,
	    j,
	    len,
	    isPrime,
	    maxDivisor,
	    output = [];

	if (arguments.length < 2) {
		throw new Error('Range is not correct!');
	}

	if (isNaN(start) || isNaN(end)) {
		throw new Error('Range must contain numbers!');
	}

	start = +start;
	end = +end;

    for (i = start; i <= end; i += 1) {
        if (i < 2) {
            continue;
        }

        isPrime = true;
	    maxDivisor = Math.sqrt(i);

        for (j = 2; j <= maxDivisor; j += 1) {
        	if (!(i % j)) {
        		isPrime = false;
        		break;
        	}
        }

        if (isPrime) {
        	output.push(i);
        }
    }

    return output;
}

module.exports = findPrimes;

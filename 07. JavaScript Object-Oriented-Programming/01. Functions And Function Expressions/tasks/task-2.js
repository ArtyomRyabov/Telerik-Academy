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

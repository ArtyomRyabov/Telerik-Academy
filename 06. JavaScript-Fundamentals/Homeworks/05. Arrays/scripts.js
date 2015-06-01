// Problem 1. Increase array members
document.getElementById('button-p1').addEventListener('click', increaseArrayMembers);

function increaseArrayMembers() {
    var inputArray = [],
        outputArray = [],
        output = '',
        length = 20,
        i;

    for (i = 0; i < length; i += 1) {
        inputArray[i] = Math.floor((Math.random() * 100) + 1);
        outputArray[i] = inputArray[i] * 5;
        output += 'Integer [' + (i + 1) + '] = ' + inputArray[i] + ' goes to: ' + outputArray[i] + '\n';
    }

    document.getElementById('result-p1').value = output;
    console.log('-----Problem 1. Increase array members-----');
    console.log(output);
}

// Problem 2. Lexicographically comparison
document.getElementById('button-p2').addEventListener('click', arraysComparison);

function arraysComparison() {
    var firstArrayInput = document.getElementById('firstArray-p2').value,
        secondArrayInput = document.getElementById('secondArray-p2').value,
        i,
        length,
        firstArray,
        secondArray,
        output;

    if ((firstArrayInput !== '') && (secondArrayInput !== '')) {
        firstArray = firstArrayInput.split(', ');
        secondArray = secondArrayInput.split(', ');
        length = Math.min(firstArray.length, secondArray.length);

        for (i = 0; i < length; i += 1) {
            if ((firstArray[i].length === 1) && (secondArray[i].length === 1)) {
                if (firstArray[i] < secondArray[i]) {
                    output = 'Array 1 < (before) Array 2';
                    document.getElementById('result-p2').value = output;
                    return;
                }
                if (firstArray[i] > secondArray[i]) {
                    output = 'Array 2 < (before) Array 1';
                    document.getElementById('result-p2').value = output;
                    return;
                } 
            } else {
                output = 'Invalid input!';
                document.getElementById('result-p2').value = output;
            }

            if (firstArray.length < secondArray.length) {
                output = 'Array 1 < (before) Array 2';
            } else if (firstArray.length > secondArray.length) {
                output = 'Array 2 < (before) Array 1';
            } else {
                output = 'Array 1 = Array 2';
            }
        }
    } else {
        output = 'Invalid input!';
    }
    document.getElementById('result-p2').value = output;
}

// Problem 3. Maximal sequence 
document.getElementById('button-p3').addEventListener('click', equalElementsMaxSequence);

function equalElementsMaxSequence() {
    var input = document.getElementById('input-p3').value,
        array = [],
        maxNumbers = [],
        number,
        counter = 1,
        maxCounter = 0,
        i,
        length,
        output = '';

    if (input !== '') {
        array = input.split(', ');
        length = array.length - 1;

        for (i = 0; i < length; i += 1) {
            if (!isNaN(array[i]) && (array[i] !== '') && (array[i] !== null) && 
            	!isNaN(array[i + 1]) && (array[i + 1] !== '') && (array[i + 1] !== null)) {

                array[i] = +array[i];
                array[i + 1] = +array[i + 1];

                if (array[i + 1] === array[i]) {
                    counter += 1;

                    if (counter === maxCounter) {
                        maxNumbers.push(array[i + 1]);
                    }

                    if (counter > maxCounter) {
                        maxCounter = counter;
                        maxNumbers = [];
                        maxNumbers.push(array[i + 1]);
                    }
                } else {
                    counter = 1;
                }
            } else {
                document.getElementById('output-p3').value = 'Invalid input!';
                return;
            }
        }

        for (number in maxNumbers) {
            for (i = 1; i <= maxCounter; i += 1) {
                if (i < maxCounter) {
                    output += maxNumbers[number] + ', ';
                } else {
                    output += maxNumbers[number];
                }
            }
            output += "\n";
        }
    } else {
        output = 'Invalid input!';
    }
    document.getElementById('output-p3').value = output;
}

// Problem 4. Maximal increasing sequence
document.getElementById('button-p4').addEventListener('click', maxIncreasingSequence);

function maxIncreasingSequence() {
    var input = document.getElementById('input-p4').value,
        array = [],
        temp = [],
        maxSequence = [],
        sequence,
        output = '',
        counter = 0,
        maxCounter = 0,
        length,
        i;

    if (input !== '') {
        array = input.split(', ');
        length = array.length - 1;

        for (i = 0; i < length; i += 1) {
            if (!isNaN(array[i]) && (array[i] !== '') && (array[i] !== null) && 
            	!isNaN(array[i + 1]) && (array[i + 1] !== '') && (array[i + 1] !== null)) {

                array[i] = +array[i];
                array[i + 1] = +array[i + 1];

                if (i === 0) {
                    temp.push(array[i]);
                    counter += 1;
                }

                if (array[i + 1] > array[i]) {
                    temp.push(array[i + 1]);
                    counter += 1;
                } else {
                    if (counter > maxCounter) {
                        maxCounter = counter;
                        maxSequence = [];
                        maxSequence.push(temp);
                        temp = [];
                        temp.push(array[i + 1]);
                        counter = 1;
                    } else if (counter === maxCounter) {
                        maxSequence.push(temp);
                        temp = [];
                        temp.push(array[i + 1]);
                        counter = 1;
                    } else {
                        temp = [];
                        temp.push(array[i + 1]);
                        counter = 1;
                    }
                }
            } else {
                document.getElementById('output-p4').value = 'Invalid input!';
                return;
            }
        }

        if (counter > maxCounter) {
            maxSequence = [];
            maxSequence.push(temp);
        }

        if (counter === maxCounter) {
            maxSequence.push(temp);
        }

        for (sequence in maxSequence) {
            output += maxSequence[sequence].join(' ') + '\n';
        }
    } else {
        output = 'Invalid input!';
    }
    document.getElementById('output-p4').value = output;
}

// Problem 5. Selection sort
document.getElementById('button-p5').addEventListener('click', sortIncreasing);

function sortIncreasing() {
    var input = document.getElementById('input-p5').value,
    array,
    temp,
    i,
    j,
    length,
    output;

    if (input !== '') {
        array = input.split(', ');
        length = array.length;

        for (i = 0; i < length - 1; i += 1) {
        	for (j = i + 1; j < length; j += 1) {
        		if (!isNaN(array[i]) && (array[i] !== '') && (array[i] !== null) && 
        			!isNaN(array[j]) && (array[j] !== '') && (array[j] !== null)) {

        			array[i] = +array[i];
                    array[j] = +array[j];

        			if (array[i] > array[j]) {
        			    temp = array[j];
        			    array[j] = array[i];
        			    array[i] = temp;
        		    }
        		} else {
        			document.getElementById('output-p5').value = 'Invalid input!';
                    return;
        		}
        	}
        }
        output = array.join(', ');
    } else {
        output = 'Invalid input!';
    }
    document.getElementById('output-p5').value = output;
}

// Problem 6. Most frequent number
document.getElementById('button-p6').addEventListener('click', mostFrequentNumber);

function mostFrequentNumber() {
    var input = document.getElementById('input-p6').value,
    array = [],
    mostFrequent = [],
    output = '',
    counter = 0,
    maxCounter = 0,
    i,
    j,
    length,
    number;

    if (input !== '') {
        array = input.split(', ');
        length = array.length;

        for (i = 0; i < length; i += 1) {
        	for (j = i; j < length; j += 1) {
        		if (!isNaN(array[i]) && (array[i] !== '') && (array[i] !== null) && 
        			!isNaN(array[j]) && (array[j] !== '') && (array[j] !== null)) {

        			array[i] = +array[i];
                    array[j] = +array[j];

        			if (array[j] === array[i]) {
        				counter += 1;
        		    }
        		} else {
        			document.getElementById('output-p6').value = 'Invalid input!';
                    return;
        		}
        	}

        	if (counter === maxCounter) {
                mostFrequent.push(array[i]);
            }

            if (counter > maxCounter) {
                maxCounter = counter;
                mostFrequent = [];
                mostFrequent.push(array[i]);
            }

            counter = 0;
        }
        for (number in mostFrequent) {
        	output += mostFrequent[number] + ' (' + maxCounter + ' times)\n';
        }
    } else {
        output = 'Invalid input!';
    }
    document.getElementById('output-p6').value = output;
}

// Problem 7. Binary search
document.getElementById('button-p7').addEventListener('click', findIndexOfGivenElement);

function findIndexOfGivenElement() {
    var input = document.getElementById('input-p7').value,
        element = document.getElementById('element-p7').value,
        output = '',
        i,
        length,
        array;

    if ((input !== '') && !isNaN(element) && (element !== '') && (element !== null)) {
        array = input.split(', ');
        length = array.length;
        element |= 0;

        for (i = 0; i < length; i += 1) {
        	if (!isNaN(array[i]) && (array[i] !== '') && (array[i] !== null)) {
        	    array[i] |= 0;
        	} else {
        		document.getElementById('output-p7').value = 'Invalid input!';
                return;
        	}
        }

        array.sort(orderBy);
        output = 'Sorted array:\n' + array + '\nElement ' + element + ' has index: [' + binarySearch(array, element) + ']';
    } else {
        output = 'Invalid input!';
    }
    document.getElementById('output-p7').value = output;
}

function orderBy(a, b) {
    return a - b;
}

function binarySearch(arr, number) {
    var start = 0,
        end = arr.length - 1,
        middle;

    while (start <= end) {
        middle = Math.round((start + end) / 2);

        if (arr[middle] === number) {
            return middle;
        } else if (arr[middle] > number) {
            end = middle - 1;
        } else {
            start = middle + 1;
        }
    }
    return 'Invalid element!';
}
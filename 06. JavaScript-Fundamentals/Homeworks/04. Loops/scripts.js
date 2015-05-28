// Problem 1. Numbers
document.getElementById('button-p1').addEventListener('click', printNumbersFrom1ToN);

function printNumbersFrom1ToN(){
    var input = document.getElementById('input-p1').value,
        output,
        i;

    if (!isNaN(input) && (input !== '') && (input % 1 === 0)) {
        input -= 0;
        output = 1;

        if (input >= 1) {
            for (i = 2; i <= input; i+=1) {
                output += ', ' + i;
            }
        } else {
            for (i = 0; i >= input; i-=1) {
                output += ', ' + i;
            }
        }
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p1').value = output;
}

// Problem 2. Numbers not divisible
document.getElementById('button-p2').addEventListener('click', printNumbersFrom1ToNExtended);

function printNumbersFrom1ToNExtended(){
    var input = document.getElementById('input-p2').value,
        output,
        i;

    if (!isNaN(input) && (input !== '') && (input % 1 === 0)) {
        input -= 0;
        output = 1;

        if (input >= 1) {
            for (i = 2; i <= input; i+=1) {
                if (i % 21 === 0) {
                    continue;
                }
                output += ', ' + i;
            }
        } else {
            for (i = 0; i >= input; i-=1) {
                if (i % 21 === 0) {
                    continue;
                }
                output += ', ' + i;
            }
        }
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p2').value = output;
}

// Problem 3. Min/Max of sequence
document.getElementById('button-p3').addEventListener('click', findMaxAndMinNumbers);

function findMaxAndMinNumbers(){
    var input = document.getElementById('input-p3').value,
        array,
        min = Number.MAX_VALUE,
        max = Number.MIN_VALUE,
        i,
        output;

    if (input !== '') {
        array = input.split(' ');

        for (i = 0; i < array.length; i+=1) {

            if (isNaN(array[i])) {
                output = 'Invalid input!';
                document.getElementById('output-p3').value = output;
                return;
            }

            if (array[i] !== '') {
                if (+array[i] <= min) {
                    min = +array[i];
                }

                if (+array[i] >= max) {
                    max = +array[i];
                }
            }
        }
        output = 'Max number: ' + max + '\nMin number: ' + min;
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p3').value = output;
}


// Problem 4. Lexicographically smallest
document.getElementById('button-p4').addEventListener('click', findSmallestAndLargestProperty);

function findSmallestAndLargestProperty() {
    var array = [document, window, navigator],
        arrayStr = ['Document', 'Window', 'Navigator'],
        i,
        arrayLength = array.length,
        property,
        smallestProp = 'z',
        largestProp = 'A',
        output = '';

    for (i = 0; i < arrayLength; i+=1) {
        for (property in array[i]) {
            if (property > largestProp) {
                largestProp = property;
            }
            if (property < smallestProp) {
                smallestProp = property;
            }
        }
        output += arrayStr[i] + ': Largest property -> ' + largestProp + '\n' + arrayStr[i] + ': Smallest property -> ' + smallestProp + '\n';
        smallestProp = 'z';
        largestProp = 'A';
    }

    document.getElementById('output-p4').value = output;
}
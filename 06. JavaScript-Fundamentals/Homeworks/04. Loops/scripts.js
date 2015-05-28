// Problem 1. Numbers
document.getElementById('button-p1').addEventListener('click', printNumbersFrom1ToN);

function printNumbersFrom1ToN(){
    var input = document.getElementById('input-p1').value,
        output;

    if (!isNaN(input) && (input !== '') && (input % 1 === 0) && (input >= 1)) {
        input -= 0;
        output = 1;

        for (var i = 2; i <= input; i+=1) {
            output += ', ' + i;
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
        output;

    if (!isNaN(input) && (input !== '') && (input % 1 === 0) && (input >= 1)) {
        input -= 0;
        output = 1;

        for (var i = 2; i <= input; i+=1) {
            if (i % 21 === 0) {
                continue;
            }
            output += ', ' + i;
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
    var property,
        smallestProp = 'z',
        largestProp = 'A',
        output;

    for (property in document) {
        if (property > largestProp) {
            largestProp = property;
        }
        if (property < smallestProp) {
            smallestProp = property;
        }
    }

    output = 'Document: Largest property -> ' + largestProp + '\nDocument: Smallest property -> ' + smallestProp + '\n';
    smallestProp = 'z';
    largestProp = 'A';

    for (property in window) {
        if (property > largestProp) {
            largestProp = property;
        }
        if (property < smallestProp) {
            smallestProp = property;
        }
    }

    output += 'Window: Largest property -> ' + largestProp + '\nWindow: Smallest property -> ' + smallestProp + '\n';
    smallestProp = 'z';
    largestProp = 'A';

    for (property in navigator) {
        if (property > largestProp) {
            largestProp = property;
        }
        if (property < smallestProp) {
            smallestProp = property;
        }
    }

    output += 'Navigator: Largest property -> ' + largestProp + '\nNavigator: Smallest property -> ' + smallestProp;
    document.getElementById('output-p4').value = output;
}
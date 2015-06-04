// Problem 1. English digit
document.getElementById('button-p1').addEventListener('click', problem1);

function problem1() {
    var inputP1 = document.getElementById('input-p1').value;
    document.getElementById('output-p1').value = lastDigitAsWord(inputP1);
}

function lastDigitAsWord(input) {
    var output = '';

    if ((input !== '') && (input != null) && !(input % 1) && !isNaN(input)) {
        switch (input % 10) {
            case 0:
                output = 'zero';
                break;
            case 1:
                output = 'one';
                break;
            case 2:
                output = 'two';
                break;
            case 3:
                output = 'three';
                break;
            case 4:
                output = 'four';
                break;
            case 5:
                output = 'five';
                break;
            case 6:
                output = 'six';
                break;
            case 7:
                output = 'seven';
                break;
            case 8:
                output = 'eight';
                break;
            case 9:
                output = 'nine';
                break;
            default:
                output = 'Invalid input!';
                break;
        }
    } else {
        output = 'Invalid input!';
    }
    return output;
}

// Problem 2. Reverse number
document.getElementById('button-p2').addEventListener('click', problem2);

function problem2() {
    var inputP2 = document.getElementById('input-p2').value;
    document.getElementById('output-p2').value = reverseDigitsInNumber(inputP2);
}

function reverseDigitsInNumber(input) {
    var i,
        len,
        start = 0,
        output = '';

    if ((input !== '') && (input != null) && !isNaN(input)) {
        input = (+input).toString();    // removing unnecessary leading zeroes (if such exist) from string
        if (input < 0) {
            output += '-';
            start = 1;
        }
        for (len = input.length, i = len - 1; i >= start; i -= 1) {
            output += input[i];
        }
        output = +output;       // removing unnecessary zeroes following the decimal coma
    } else {
        output = 'Invalid input!';
    }
    return output;
}

// Problem 3. Occurrences of word
document.getElementById('button-p3').addEventListener('click', problem3);

function problem3() {
    var text = document.getElementById('input-p3').value,
        sensitive = document.getElementById('case-sensitive').checked,
        word = document.getElementById('input-word-p3').value;

    document.getElementById('output-p3').value = findWordInText(text, word, sensitive);
}

function findWordInText(text, word, sensitive) {
    var output;

    if ((text !== '') && (text != null) && (word !== '') && (word != null) ) {

        function findWordInTextCaseSensitive() {
            var reg = new RegExp('\\b' + word + '\\b','g');
            output = text.replace(reg, '@@@');
        }

        function findWordInTextCaseInsensitive() {
            var reg = new RegExp('\\b' + word + '\\b','gi');
            output = text.replace(reg, '@@@');
        }

        if (sensitive) {
            findWordInTextCaseSensitive();
        } else {
            findWordInTextCaseInsensitive();
        }

    } else if ((text === '') || (text == null)){
        output = 'Invalid text!';
    } else {
        output = 'Invalid word!';
    }
    return output;
}

// Problem 4. Number of elements
document.getElementById('button-p4').addEventListener('click', countDivElements);

function countDivElements() {
    document.getElementById('output-p4').value = document.getElementsByTagName('div').length;
}

// Problem 5. Appearance count
document.getElementById('button-p5').addEventListener('click', problem5);

function problem5() {
    var inputNumbers = document.getElementById('input-p5').value,
        searchedNumber = document.getElementById('input-number-p5').value;
    document.getElementById('output-p5').value = countANumberAppearancesInArray(inputNumbers, searchedNumber);
}

function countANumberAppearancesInArray(numbers, searched) {
    var i,
        len,
        counter = 0,
        array = [],
        output = '';

    if ((numbers !== '') && (searched !== '') && (searched != null) && !isNaN(searched)) {
        array = numbers.split(', ');
        searched |= 0;

        for (i = 0, len = array.length; i < len; i += 1) {
            if (!isNaN(array[i]) && (array[i] !== '') && (array[i] !== null)) {
                array[i] |= 0;

                if (array[i] === searched) {
                    counter += 1;
                }
            } else {
                return 'Invalid array!';
            }
        }
        output = 'Number ' + searched + ' appears ' + counter + ' time(s)';
    } else if (numbers === '') {
        output = 'Invalid array!';
    } else {
        output = 'Invalid number!';
    }
    return output;
}

function testCountANumberAppearancesInArray() {
    var numbers = '1, 2, 3, 4, 5, 2, 3, 4, 5, 3, 4, 5, 4, 5, 5';

    console.log('- Problem 5 /function countANumberAppearancesInArray()/ Test -');
    console.log('numbers = 1, 2, 3, 4, 5, 2, 3, 4, 5, 3, 4, 5, 4, 5, 5');
    console.log('Result:');
    console.log(countANumberAppearancesInArray(numbers, 1));
    console.log(countANumberAppearancesInArray(numbers, 2));
    console.log(countANumberAppearancesInArray(numbers, 3));
    console.log(countANumberAppearancesInArray(numbers, 4));
    console.log(countANumberAppearancesInArray(numbers, 5));
}

testCountANumberAppearancesInArray();

// Problem 6. Larger than neighbours
document.getElementById('button-p6').addEventListener('click', problem6);

function problem6() {
    var inputNumbers = document.getElementById('input-p6').value,
        index = document.getElementById('input-index-p6').value;
    document.getElementById('output-p6').value = isBiggerThanNeighbours(inputNumbers, index);
}

function isBiggerThanNeighbours(numbers, index) {
    var len,
        array = [],
        output = '',
        validArray = isValidArray(numbers),
        validInteger = isValidInteger(index);

    if (validArray && (index >= 0) && validInteger) {
        array = numbers.split(', ');
        len = array.length;
        index |= 0;

        if (index >= 0 && index < len) {
            if (index > 0 && index < len - 1) {
                if(isLargerThanNeighbours(array, index)) {
                    output = 'Larger than its neighbours';
                } else {
                    output = 'NOT larger than its neighbours';
                }
            } else {
                output = 'The element has only one neighbour!';
            }
        } else {
            output = 'Index is out of range!';
        }

    } else if (!validArray) {
        output = 'Invalid array!';
    } else {
        output = 'Invalid index!';
    }
    return output;
}

function isValidInteger(input) {
    if ((input !== '') && (input != null) && !isNaN(input) && !(input % 1)) {
        return true;
    } else {
        return false;
    }
}

function isValidArray(input) {
    var i,
        len,
        arr;

    if (input !== '') {
        arr = input.split(', ');

        for (i = 0, len = arr.length; i < len; i += 1){
            if (!isValidInteger(arr[i])) {
                return false;
            }
        }
        return true;
    } else {
        return false;
    }
}

function isLargerThanNeighbours(array, index) {
    if (+(array[index]) > +(array[index - 1]) && +(array[index]) > +(array[index + 1])) {
        return true;
    } else {
        return false;
    }
}

// Problem 7. First larger than neighbours
document.getElementById('button-p7').addEventListener('click', problem7);

function problem7() {
    var inputNumbers = document.getElementById('input-p7').value;
    document.getElementById('output-p7').value = firstBiggerThanNeighbours(inputNumbers);
}

function firstBiggerThanNeighbours(numbers) {
    var i,
        len,
        array = [],
        output = -1,
        validArray = isValidArray(numbers);

    if (validArray) {
        array = numbers.split(', ');

        for (i = 1, len = array.length; i < len - 1; i += 1) {
            if (isLargerThanNeighbours(array, i)) {
                output = i;
                break;
            }
        }
    } else {
        output = 'Invalid array!';
    }
    return output;
}
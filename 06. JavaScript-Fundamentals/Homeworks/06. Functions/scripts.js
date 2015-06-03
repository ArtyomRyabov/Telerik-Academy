// Problem 1. English digit
document.getElementById('button-p1').addEventListener('click', lastDigitAsWord);

function lastDigitAsWord() {
    var output = '',
        input = document.getElementById('input-p1').value;

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
    document.getElementById('output-p1').value = output;
}

// Problem 2. Reverse number
document.getElementById('button-p2').addEventListener('click', reverseDigitsInNumber);

function reverseDigitsInNumber() {
    var i,
        len,
        start = 0,
        output = '',
        input = document.getElementById('input-p2').value;

    if ((input !== '') && (input != null) && !isNaN(input)) {
        input = (+input).toString()     // removing leading zeroes from string, if such exist
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
    document.getElementById('output-p2').value = output;
}
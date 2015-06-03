function getInput(str) {
    return document.getElementById(str).value;
}

function isValidInput(input) {
    return ((input !== '') && (input != null)) ? true : false;
}

function sendOutput(id, out) {
    document.getElementById(id).value = out;
}

// Problem 1. English digit
document.getElementById('button-p1').addEventListener('click', lastDigitAsWord);

function lastDigitAsWord() {
    var output = '',
        input = getInput('input-p1'),
        isInput = isValidInput(input);

    if (isInput && !(input % 1) && !isNaN(input)) {
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
    sendOutput('output-p1', output);
}
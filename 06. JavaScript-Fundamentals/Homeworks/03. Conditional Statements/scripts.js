// Problem 1. Exchange if greater
function exchangeIfGreater() {
    var doubleA = document.getElementById('doubleA').value,
        doubleB = document.getElementById('doubleB').value,
        temporary,
        result;

    if (!isNaN(doubleA) && !isNaN(doubleB) && (doubleA !== '') && (doubleB !== '')) {
        if ((doubleA -= 0) > (doubleB -= 0)) {
            temporary = doubleA;
            doubleA = doubleB;
            doubleB = temporary;
        }

        result = doubleA + ' ' + doubleB;

    } else {
        result = 'Enter two NUMBERS!';
    }

    document.getElementById('output-p1').value = result;
}

// Problem 2. Multiplication Sign
function plusMinusOrZero() {
    var a = document.getElementById('a-p2').value,
        b = document.getElementById('b-p2').value,
        c = document.getElementById('c-p2').value,
        array = [a, b, c],
        len = array.length,
        minusCounter = 0,
        result = '+';

    if (!isNaN(a) && !isNaN(b) && !isNaN(c) && (a !== '') && (b !== '') && (c !== '')) {
        for (var i = 0; i < len; i += 1) {
            if ((array[i] -= 0) === 0) {
                result = Math.abs(array[i]);
                document.getElementById('output-p2').value = result;
                return;
            }

            if (array[i] < 0) {
                minusCounter += 1;
            }
        }

        if (minusCounter % 2 !== 0) {
            result = '-';
        }

    } else {
        result = 'Enter three NUMBERS!';
    }

    document.getElementById('output-p2').value = result;
}

// Problem 3. The biggest of Three
function theBiggestOfThree() {
    var a = document.getElementById('a-p3').value,
        b = document.getElementById('b-p3').value,
        c = document.getElementById('c-p3').value,
        output;

    if (!isNaN(a) && !isNaN(b) && !isNaN(c) && (a !== '') && (b !== '') && (c !== '')) {

        a -= 0;
        b -= 0;
        c -= 0;

        if (a > b) {
            if (a > c) {
                output = a;
            } else if (a === c) {
                output = a + ' (a = c)';
            } else {
                output = c;
            }
        } else if (a === b) {
            if (a > c) {
                output = a + ' (a = b)';
            } else if (a === c) {
                output = a + ' (a = b = c)';
            } else {
                output = c;
            }
        } else {
            if (b > c) {
                output = b;
            } else if (b === c) {
                output = b + ' (b = c)';
            } else {
                output = c;
            }
        }

    } else {
        output = 'Enter three NUMBERS!';
    }

    document.getElementById('output-p3').value = output;
}

// Problem 4. Sort 3 numbers
function sortDescendingOrder() {
    var a = document.getElementById('a-p4').value,
        b = document.getElementById('b-p4').value,
        c = document.getElementById('c-p4').value,
        output;

    if (!isNaN(a) && !isNaN(b) && !isNaN(c) && (a !== '') && (b !== '') && (c !== '')) {

        a -= 0;
        b -= 0;
        c -= 0;

        if (a >= b) {
            if (b >= c) {
                output = a + ' / ' + b + ' / ' + c;
            } else {
                if (c >= a) {
                    output = c + ' / ' + a + ' / ' + b;
                } else {
                    output = a + ' / ' + c + ' / ' + b;
                }
            }
        } else {
            if (b >= c) {
                if (c >= a) {
                    output = b + ' / ' + c + ' / ' + a;
                } else {
                    output = b + ' / ' + a + ' / ' + c;
                }
            } else {
                output = c + ' / ' + b + ' / ' + a;
            }
        }

    } else {
        output = 'Enter three NUMBERS!';
    }

    document.getElementById('output-p4').value = output;
}

// Problem 5. Digit as word
function digitAsWord() {
    var input = document.getElementById('input-p5').value,
        output;

    switch (input) {
        case '0':
            output = 'zero';
            break;
        case '1':
            output = 'one';
            break;
        case '2':
            output = 'two';
            break;
        case '3':
            output = 'three';
            break;
        case '4':
            output = 'four';
            break;
        case '5':
            output = 'five';
            break;
        case '6':
            output = 'six';
            break;
        case '7':
            output = 'seven';
            break;
        case '8':
            output = 'eight';
            break;
        case '9':
            output = 'nine';
            break;
        default:
            output = 'not a digit / invalid input';
            break;
    }

    document.getElementById('output-p5').value = output;
}

// Problem 6. Quadratic equation
function quadraticEquationRealRoots() {
    var a = document.getElementById('a-p6').value,
        b = document.getElementById('b-p6').value,
        c = document.getElementById('c-p6').value,
        discriminant,
        oneRoot,
        root1,
        root2,
        output;

    if (!isNaN(a) && !isNaN(b) && !isNaN(c) && (a !== '') && (b !== '') && (c !== '')) {

        a -= 0;
        b -= 0;
        c -= 0;
        discriminant = (b * b) - (4 * a * c);

        if (discriminant < 0) {
            output = 'no real roots';
        } else if (discriminant > 0) {
            root1 = (-b - Math.sqrt(discriminant)) / (2 * a);
            root2 = (-b + Math.sqrt(discriminant)) / (2 * a);
            output = 'x1 = ' + root1 + '; x2 = ' + root2;
        } else {
            oneRoot = -b / (2 * a);
            output = 'x1 = x2 = ' + oneRoot;
        }

    } else {
        output = 'Enter three NUMBERS!';
    }

    document.getElementById('output-p6').value = output;
}

// Problem 7. The biggest of five numbers
function theBiggestOfFive() {
    var a = document.getElementById('a-p7').value,
        b = document.getElementById('b-p7').value,
        c = document.getElementById('c-p7').value,
        d = document.getElementById('d-p7').value,
        e = document.getElementById('e-p7').value,
        output;

    if (!isNaN(a) && !isNaN(b) && !isNaN(c) && !isNaN(d) && !isNaN(e) &&
       (a !== '') && (b !== '') && (c !== '') && (d !== '') && (e !== '')) {

        a -= 0;
        b -= 0;
        c -= 0;
        d -= 0;
        e -= 0;

        if (a >= b) {
            if (a >= c) {
                if (a >= d) {
                    if (a >= e) {
                        output = a;
                    }
                }
            }
        }

        if (b >= a) {
            if (b >= c) {
                if (b >= d) {
                    if (b >= e) {
                        output = b;
                    }
                }
            }
        }

        if (c >= a) {
            if (c >= b) {
                if (c >= d) {
                    if (c >= e) {
                        output = c;
                    }
                }
            }
        }

        if (d >= a) {
            if (d >= b) {
                if (d >= c) {
                    if (d >= e) {
                        output = d;
                    }
                }
            }
        }

        if (e >= a) {
            if (e >= b) {
                if (e >= c) {
                    if (e >= d) {
                        output = e;
                    }
                }
            }
        }

    } else {
        output = 'Enter five NUMBERS!';
    }

    document.getElementById('output-p7').value = output;
}

// Problem 8. Number as words
function numbersAsWords() {
    var input = document.getElementById('input-p8').value,
        hundreds,
        tenths,
        units,
        output = '';

    if (!isNaN(input) && (input !== '') && ((input -= 0) % 1 === 0)) {
        input -= 0;

        if (input < 0 || input > 999) {
            output = "Number is out of range!";
        } else if (input === 0) {
            output = 'Zero';
        } else {
            hundreds = Math.floor(input / 100);
            tenths = Math.floor((input % 100) / 10);
            units = input % 10;

            if (hundreds > 0 && hundreds <= 9) {
                switch (hundreds) {
                    case 1:
                        output = 'One hundred ';
                        break;
                    case 2:
                        output = 'Two hundred ';
                        break;
                    case 3:
                        output = 'Three hundred ';
                        break;
                    case 4:
                        output = 'Four hundred ';
                        break;
                    case 5:
                        output = 'Five hundred ';
                        break;
                    case 6:
                        output = 'Six hundred ';
                        break;
                    case 7:
                        output = 'Seven hundred ';
                        break;
                    case 8:
                        output = 'Eight hundred ';
                        break;
                    case 9:
                        output = 'Nine hundred ';
                        break;
                }

                if (tenths === 0 && units === 0) {
                    document.getElementById('output-p8').value = output;
                    return;
                } else {
                    output += 'and ';
                }
            }

            if (tenths > 1) {
                switch (tenths) {
                    case 2:
                        output += 'twenty ';
                        break;
                    case 3:
                        output += 'thirty ';
                        break;
                    case 4:
                        output += 'fourty ';
                        break;
                    case 5:
                        output += 'fifty ';
                        break;
                    case 6:
                        output += 'sixty ';
                        break;
                    case 7:
                        output += 'seventy ';
                        break;
                    case 8:
                        output += 'eighty ';
                        break;
                    case 9:
                        output += 'ninety ';
                        break;
                }
            }

            if (tenths === 1) {
                switch (units) {
                    case 0:
                        output += 'ten';
                        break;
                    case 1:
                        output += 'eleven';
                        break;
                    case 2:
                        output += 'twelve';
                        break;
                    case 3:
                        output += 'thirteen';
                        break;
                    case 4:
                        output += 'fourteen';
                        break;
                    case 5:
                        output += 'fifteen';
                        break;
                    case 6:
                        output += 'sixteen';
                        break;
                    case 7:
                        output += 'seventeen';
                        break;
                    case 8:
                        output += 'eighteen';
                        break;
                    case 9:
                        output += 'nineteen';
                        break;
                }
            } else {
                switch (units) {
                    case 1:
                        output += 'one';
                        break;
                    case 2:
                        output += 'two';
                        break;
                    case 3:
                        output += 'three';
                        break;
                    case 4:
                        output += 'four';
                        break;
                    case 5:
                        output += 'five';
                        break;
                    case 6:
                        output += 'six';
                        break;
                    case 7:
                        output += 'seven';
                        break;
                    case 8:
                        output += 'eight';
                        break;
                    case 9:
                        output += 'nine';
                        break;
                }
            }
        }

    } else {
        output = 'Enter an integer number!';
    }

    output = output.charAt(0).toUpperCase() + output.slice(1);
    document.getElementById('output-p8').value = output;
}
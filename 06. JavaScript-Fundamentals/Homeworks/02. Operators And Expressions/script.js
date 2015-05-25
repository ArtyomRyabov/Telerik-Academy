// Problem 1. Odd or Even
function oddOrEven() {
    var number = document.getElementById('input-p1').value,
        output;

    if (isNaN(number) || number === '') {
        output = 'Your input is not a number';
    } else if (number % 1 !== 0) {
        output = 'Your number is not an integer';
    } else {
        output = number % 2 === 0 ? 'Even' : 'Odd';
    }

    document.getElementById('output-p1').value = output;
}

// Problem 2. Divisible by 7 and 5
function divisibleBy7And5() {
    var number = document.getElementById('input-p2').value,
        output;

    if (isNaN(number) || number === '') {
        output = 'Your input is not a number';
    } else if (number % 1 !== 0) {
        output = 'Your number is not an integer';
    } else {
        output = (number % 5 === 0) && (number % 7 === 0) ? 'True' : 'False';
    }

    document.getElementById('output-p2').value = output;
}

// Problem 3. Rectangle area
function rectangleArea() {
    var width = document.getElementById('rectangle-width').value,
        height = document.getElementById('rectangle-height').value,
        output;

    if (isNaN(width) || isNaN(height) || width === '' || height === '') {
        document.getElementById('output-p3').value = 'Invalid input';
    } else if (width > 0 && height > 0) {
        output = width * height;
        document.getElementById('output-p3').value = Math.round(output * 100) / 100;
    } else {
        document.getElementById('output-p3').value = 'Negative number is not allowed';
    }
}

// Problem 4. Third digit
function isThirdDigit7() {
    var number = document.getElementById('input-p4').value,
        output;

    if (isNaN(number) || number === '') {
        output = 'Your input is not a number';
    } else if (number % 1 !== 0) {
        output = 'Your number is not an integer';
    } else if (number.length < 3) {
        output = 'Less than 3 digits';
    } else {
        output = Math.floor(Math.abs(number / 100)) % 10 === 7;
    }

    document.getElementById('output-p4').value = output;
}

// Problem 5. Third bit
function findThirdBit() {
    var number = document.getElementById('input-p5').value,
        output;

    if (isNaN(number) || number === '') {
        output = 'Your input is not a number';
    } else if (number % 1 !== 0) {
        output = 'Your number is not an integer';
    } else {
        output = (number >> 3) & 1;
    }

    document.getElementById('output-p5').value = output;
}

// Problem 6. Point in Circle
function pointInsideCircle() {
    var x = document.getElementById('x-p6').value,
        y = document.getElementById('y-p6').value,
        radius = 5,
        output;

    if (isNaN(x) || isNaN(y) || x === '' || y === '') {
        document.getElementById('output-p6').value = 'Invalid input';
        return;
    } else {
        output = (x * x) + (y * y) <= radius * radius;
    }

    document.getElementById('output-p6').value = output;
}

// Problem 7. Is prime
function isPrimeInteger() {
    var number = document.getElementById('input-p7').value,
        output = true;

    if ((!isNaN(number)) && (number !== '') && (number % 1 === 0) && (number >= 0) && (number <= 100)) {
        if (number < 2) {
            output = false;
        } else {
            for (var i = 2; i <= Math.sqrt(number) ; i += 1) {
                if (number % i === 0 && i !== number) {
                    output = false;
                    break;
                }
            }
        }
    } else if (isNaN(number) || (number === '')) {
        output = 'Your input is not a number';
    } else if (number % 1 !== 0) {
        output = 'Your number is not an integer';
    } else {
        output = 'Number out of range';
    }

    document.getElementById('output-p7').value = output;
}

// Problem 8. Trapezoid area
function trapezoidArea() {
    var sideA = document.getElementById('trapezoid-sideA').value,
        sideB = document.getElementById('trapezoid-sideB').value,
        height = document.getElementById('trapezoid-height').value,
        output;

    if ((!isNaN(sideA)) && (!isNaN(sideB)) && (!isNaN(height)) && (sideA !== '') && (sideB !== '') &&
        (height !== '') && (sideA > 0) && (sideB > 0) && (height > 0)) {
        output = ((sideA * 1 + sideB * 1) / 2) * height;
        document.getElementById('output-p8').value = Math.round(output * 100) / 100;
    } else if (isNaN(sideA) || isNaN(sideB) || isNaN(height) || sideA === '' || sideB === '' || height === '') {
        document.getElementById('output-p8').value = 'Invalid input';
    } else {
        document.getElementById('output-p8').value = 'Negative number is not allowed';
    }
}

// Problem 9. Point in Circle and outside Rectangle
function pointInCircleOutRectangle() {
    var x = document.getElementById('x-p9').value,
        y = document.getElementById('y-p9').value,
        centerX = 1,
        centerY = 1,
        radius = 3,
        top = 1,
        left = -1,
        bottom = -1,
        right = 5,
        insideK,
        outsideR,
        result;

    if (isNaN(x) || isNaN(y) || x === '' || y === '') {
        document.getElementById('output-p9').value = 'Invalid input';
        return;
    } else {
        insideK = ((x - centerX) * (x - centerX)) + ((y - centerY) * (y - centerY)) <= radius * radius;
    }

    outsideR = (x < left || x > right || y > top || y < bottom);

    if (insideK && outsideR) {
        result = 'yes';
    } else {
        result = 'no';
    }

    document.getElementById('output-p9').value = result;
}
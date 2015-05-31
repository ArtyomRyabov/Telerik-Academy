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
                } else if (firstArray[i] > secondArray[i]) {
                    output = 'Array 2 < (before) Array 1';
                    document.getElementById('result-p2').value = output;
                    return;
                } else {
                    continue;
                }
            } else {
                output = 'Invalid input!';
                document.getElementById('result-p2').value = output;
                return;
            }
        }

        if (firstArray.length < secondArray.length) {
            output = 'Array 1 < (before) Array 2';
        } else if (firstArray.length > secondArray.length) {
            output = 'Array 2 < (before) Array 1';
        } else {
            output = 'Array 1 = Array 2';
        }

    } else {
        output = 'Invalid input!';
    }

    document.getElementById('result-p2').value = output;
}

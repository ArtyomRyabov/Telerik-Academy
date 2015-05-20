// Problem 1. JavaScript literals
var arrayLiterals = ['one', 'two', 'three'];
var boolLiteralTrue = true;
var boolLiteralFalse = false;
var integerLiteral = 123;
var floatingPointLiteral = 1.23;
var octalNumericLiteral = 0777;
var hexadecimalNumericLiteral = 0xFF;
var objectLiterals = { name: 'Ivan', age: 30 };
var stringLiteral = 'string literal';
var nullLiteral = null;
var undefinedLiteral;
var functionLiteral = function (x, y) { return (x + y); };

document.getElementById('problem-one').innerHTML =
    "var arrayLiterals = ['one', 'two', 'three'];" + "<br>" +
    "var boolLiteralTrue = true;" + "<br>" +
    "var boolLiteralFalse = false;" + "<br>" +
    "var integerLiteral = 123;" + "<br>" +
    "var floatingPointLiteral = 1.23;" + "<br>" +
    "var octalNumericLiteral = 0777;" + "<br>" +
    "var hexadecimalNumericLiteral = 0xFF;" + "<br>" +
    "var objectLiterals = { name: 'Ivan', age: 30 };" + "<br>" +
    "var stringLiteral = 'string literal';" + "<br>" +
    "var nullLiteral = null;" + "<br>" +
    "var undefinedLiteral;" + "<br>" +
    "var functionLiteral = function (x, y) { return (x + y); };";

// 2. Quoted text
var quotedText = "'How you doin'?', Joey said.";

document.getElementById('problem-two').innerHTML =
    "var quotedText = \"'How you doin'?', Joey said.\";" + "<br>" +
    "Print: " + quotedText;

// Problem 3. Typeof variables
document.getElementById('problem-three').innerHTML =
    'arrayLiterals - Type: ' + typeof (arrayLiterals) + '<br>' +
    'boolLiteralTrue - Type: ' + typeof (boolLiteralTrue) + '<br>' +
    'boolLiteralFalse - Type: ' + typeof (boolLiteralFalse) + '<br>' +
    'integerLiteral - Type: ' + typeof (integerLiteral) + '<br>' +
    'floatingPointLiteral - Type: ' + typeof (floatingPointLiteral) + '<br>' +
    'octalNumericLiteral - Type: ' + typeof (octalNumericLiteral) + '<br>' +
    'hexadecimalNumericLiteral - Type: ' + typeof (hexadecimalNumericLiteral) + '<br>' +
    'objectLiterals - Type: ' + typeof (objectLiterals) + '<br>' +
    'stringLiteral - Type: ' + typeof (stringLiteral) + '<br>' +
    'nullLiteral - Type: ' + typeof (nullLiteral) + '<br>' +
    'undefinedLiteral - Type: ' + typeof (undefinedLiteral) + '<br>' +
    'functionLiteral - Type: ' + typeof (functionLiteral) + '<br>' +
    'quotedText - Type: ' + typeof (quotedText);

// Problem 4. Typeof null
document.getElementById('problem-four').innerHTML =
    'nullLiteral - Type: ' + typeof (nullLiteral) + '<br>' +
    'undefinedLiteral - Type: ' + typeof (undefinedLiteral);
if (!String.prototype.trimLeft) {
    String.prototype.trimLeft = function () {
        return this.replace(/^\s+/, '');
    };
}

if (!String.prototype.trimRight) {
    String.prototype.trimRight = function () {
        return this.replace(/\s+$/, '');
    };
}

if (!String.prototype.trim) {
    String.prototype.trim = function () {
        return this.trimLeft().trimRight();
    };
}

if (!String.prototype.trimLeftChars) {
    String.prototype.trimLeftChars = function (chars) {
        var regEx = new RegExp('^[' + chars + ']+');
        return this.replace(regEx, '');
    };
}

if (!String.prototype.trimRightChars) {
    String.prototype.trimRightChars = function (chars) {

        var regEx = new RegExp('[' + chars + ']+$');
        return this.replace(regEx, '');
    };
}

if (!String.prototype.trimChars) {
    String.prototype.trimChars = function (chars) {
        return this.trimLeftChars(chars).trimRightChars(chars);
    };
}

// Problem 1. Numbers
document.getElementById('button-p1').addEventListener('click', problem1);

function reverseString(str) {
    var i,
        len,
        result = '';

    for (len = str.length - 1, i = len; i >= 0; i -= 1) {
        result += str[i];
    }

    return result;
}

function problem1() {
    var output,
        input = document.getElementById('input-p1').value;

    if (input) {
        output = reverseString(input);
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p1').value = output;
}

// Problem 2. Correct brackets
document.getElementById('button-p2').addEventListener('click', problem2);

function areCorrectBrackets(input) {
    var i,
        len,
        balance = 0;

    for (i = 0, len = input.length - 1; i <= len; i += 1) {
        if (input[i] === '(') {
            balance += 1;
        } else if (input[i] === ')') {
            balance -= 1;
        }

        if ((i === 0 && input[i] === ')') || (i === len && input[i] === '(')) {
            return 'Incorrect brackets!';
        }

        if (((i > 0 && input[i] === ')') && !(input[i - 1].match(/[A-z0-9)]/))) ||
            ((i < len && input[i] === '(') && !(input[i + 1].match(/[A-z0-9(\-]/)))) {
            return 'Incorrect brackets!';
        }
    }

    return balance ? 'Incorrect brackets!' : 'Correct brackets!';
}

function problem2() {
    var output,
        input = document.getElementById('input-p2').value;

    if (input) {
        output = areCorrectBrackets(input);
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p2').value = output;
}

// Problem 3. Sub-string in text
document.getElementById('button-p3').addEventListener('click', problem3);

function countSubstringInText(text, substr) {
    var i,
        count = 0,
        substrLen = substr.length,
        len = text.length - substrLen;

    for (i = 0; i <= len; i += 1) {
        if (text.substr(i, substrLen).toLowerCase() === substr.toLowerCase()) {
            count += 1;
            i += substrLen - 1;
        }
    }

    return count;
}

function problem3() {
    var output,
        inputText = document.getElementById('input1-p3').value,
        inputSubstring = document.getElementById('input2-p3').value;

    if (inputText && inputSubstring){
        output = countSubstringInText(inputText, inputSubstring) + ' time(s)';
    } else if (!inputText){
        output = 'Invalid text!';
    } else {
        output = 'Invalid substring!';
    }

    document.getElementById('output-p3').value = output;
}

// Problem 4. Parse tags
document.getElementById('button-p4').addEventListener('click', problem4);

function changeTextInTags(text) {
    var i,
        len,
        tagsLen,
        result = [],
        tags = [];

    for (i = 0, len = text.length; i < len; i += 1) {
        if (i === text.indexOf('<upcase>', i)) {
            tags.push('up');
            i += 8;
        } else if (i === text.indexOf('</upcase>', i)) {
            tags.pop();
            i += 9;
        } else if (i === text.indexOf('<lowcase>', i)) {
            tags.push('low');
            i += 9;
        } else if (i === text.indexOf('</lowcase>', i)) {
            tags.pop();
            i += 10;
        } else if (i === text.indexOf('<mixcase>', i)) {
            tags.push('mix');
            i += 9;
        } else if (i === text.indexOf('</mixcase>', i)) {
            tags.pop();
            i += 10;
        }

        tagsLen = tags.length - 1;

        switch (tags[tagsLen]) {
            case 'up':
                result.push(text[i].toUpperCase());
                break;
            case 'low':
                result.push(text[i].toLowerCase());
                break;
            case 'mix':
                if (Math.round(Math.random())) {
                    result.push(text[i].toUpperCase());
                } else {
                    result.push(text[i].toLowerCase());
                }
                break;
            default:
                result.push(text[i]);
                break;
        }
    }

    return result.join('');
}

function problem4() {
    var output,
        input = document.getElementById('input-p4').value;

    if (input){
        output = changeTextInTags(input);
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p4').value = output;
}

// Problem 5. nbsp
document.getElementById('button-p5').addEventListener('click', problem5);

function problem5() {
    var i,
        len,
        output = [],
        input = document.getElementById('input-p5').value;

    if (input){
        for (i = 0, len = input.length; i < len; i += 1) {
            if (input[i] === ' ') {
                output.push('&nbsp;');
            } else {
                output.push(input[i]);
            }
        }
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p5').value = output.join('');
}

// Problem 6. Extract text from HTML
document.getElementById('button-p6').addEventListener('click', problem6);

function extractTextFromHTML(text) {
    var i,
        len,
        temp,
        result = '';

    for (i = 0, len = text.length; i < len; i += 1) {
        if (text[i] === '<') {
            i = text.indexOf('>', i);
            continue;
        }

        temp = text.substring(i, text.indexOf('<', i)).trim();
        result += temp;
        i = text.indexOf('>', i);
    }

    return result;
}

function problem6() {
    var output,
        input = document.getElementById('input-p6').value;

    if (input){
        output = extractTextFromHTML(input);
    } else {
        output = 'Enter HTML!';
    }

    document.getElementById('output-p6').value = output;
}

// Problem 7. Parse URL
document.getElementById('button-p7').addEventListener('click', problem7);

function parseURLToJSONObject(url) {
    var obj = {};

    obj.protocol = url.substring(0, url.indexOf(':'));
    obj.server = url.substring(url.indexOf('//') + 2, url.indexOf('/', url.indexOf('.')));
    obj.resourse = url.substring(url.indexOf('/', url.indexOf('.')));

    return obj;
}

function validateUrl(text){
    var reg = /^(https?|ftp):\/\/(((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)+(\/(([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)*)*)?)?(\?((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|[\uE000-\uF8FF]|\/|\?)*)?(#((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|\/|\?)*)?$/i.test(value);

    return reg.test(text);
}

function toString(obj) {
    var prop,
        str = '{ ';

    for (prop in obj) {
        if (obj.hasOwnProperty(prop)) {
            str += prop + ': ' + obj[prop] + '\n';
        }
    }

    str = str.trimRight();
    return str + ' }';
}

function problem7() {
    var output,
        validURL,
        object = {},
        input = document.getElementById('input-p7').value;

    validURL = validateUrl(input);

    if (validURL){
        object = parseURLToJSONObject(input);
        output = toString(object);
    } else {
        output = 'Invalid URL!';
    }

    document.getElementById('output-p7').value = output;
}

// Problem 8. Replace tags
document.getElementById('button-p8').addEventListener('click', problem8);

function replaceATag(str) {
    while (str.indexOf('<a') !== -1) {
        str = str.replace('<a href="', '[URL=');
        str = str.replace('">', ']');
        str = str.replace('</a>', '[/URL]');
    }

    return str;
}

function problem8() {
    var output,
        input = document.getElementById('input-p8').value;

    if (input){
        output = replaceATag(input);
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p8').value = output;
}

// Problem 9. Extract e-mails
document.getElementById('button-p9').addEventListener('click', problem9);

function extractEMails(text) {
    var i,
        len,
        result = '',
        matches = text.match(/([A-z0-9_.\-]+@[A-z0-9_.\-]+\.[A-z]{2,6})/gmi);

    for (i = 0, len = matches.length; i < len; i += 1) {
        result += matches[i] + '\n';
    }

    return result;
}

function problem9() {
    var output,
        input = document.getElementById('input-p9').value;

    if (input){
        output = extractEMails(input);
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p9').value = output;
}

// Problem 10. Find palindromes
document.getElementById('button-p10').addEventListener('click', problem10);

function findPalindromes(text) {
    var i,
        len,
        word,
        words,
        isPalindrome = true,
        palindromes = '';

    words = text.split(' ')
        .map(function (word) {
            return word.trimChars(/\W|_/);
        }).filter(function (word) {
            return (word !== '' && word.length > 1);
        });

    for (word in words) {
        if (words.hasOwnProperty(word)) {

            for (i = 0, len = words[word].length; i < len / 2; i += 1) {
                if (words[word][i] !== words[word][len - 1 - i]) {
                    isPalindrome = false;
                    break;
                }

                isPalindrome = true;
            }

            if (isPalindrome) {
                palindromes += words[word] + '\n';
            }
        }
    }

    return palindromes;
}

function problem10() {
    var output,
        input = document.getElementById('input-p10').value;

    if (input){
        output = findPalindromes(input);
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p10').value = output;
}

// Problem 11. String format
document.getElementById('button-p11').addEventListener('click', problem11);

function stringFormat() {
    var i,
        len;

    for (i = 0, len = arguments.length; i < len; i += 1) {
        arguments[0] = arguments[0].replace(/{\i}/g, arguments[i + 1]);
    }

    return arguments[0];
}

function problem11() {
    var output,
        input = document.getElementById('input-p11').value;

    if (input){
        output = input;
    } else {
        output = 'Invalid input!';
    }

    document.getElementById('output-p11').value = output;
}
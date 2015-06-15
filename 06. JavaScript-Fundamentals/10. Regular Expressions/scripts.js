// Problem 1. Format with placeholders

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        return this.replace(/#{(\w+)}/gm, function (match, word) {
            return typeof options[word] !== 'undefined' ? options[word] : match;
        });
    };
}

function problem1() {
    var firstOptions = {name: 'John'},
        secondOptions = {name: 'John', age: 13};

    console.log('***** Problem 1. Format with placeholders *****');
    console.log('Input:\nvar firstOptions = {name: "John"};');
    console.log('Hello, there! Are you #{name}?');
    console.log('Output:\nHello, there! Are you #{name}?'.format(firstOptions));
    console.log('Input:\nvar secondOptions = {name: "John", age: 13};');
    console.log('My name is #{name} and I am #{age}-years-old.');
    console.log('Output:\nMy name is #{name} and I am #{age}-years-old.'.format(secondOptions));
}

problem1();

// Problem 2. HTML binding

if (!String.prototype.bind) {
    String.prototype.bind = function (obj) {
        var regContent,
            regHref,
            regClass,
            prop,
            output = this;

        for (prop in obj) {
            if (obj.hasOwnProperty(prop)) {
                regContent = new RegExp('(<.+data-bind-content="' + prop + '".*>)(.*)(<.+>)', 'gm');
                regHref = new RegExp('(<.+data-bind-href="' + prop + '" data-bind-class=".+")', 'gm');
                regClass = new RegExp('(data-bind-class="' + prop + '")', 'gm');

                output = output.replace(regContent, function (a, openTag, content, closeTag) {
                    return openTag + obj[prop] + closeTag;
                });

                output = output.replace(regHref, function (content) {
                    return content + ' href="' + obj[prop] + '"';
                });

                output = output.replace(regClass, 'data-bind-class="' + obj[prop] + '"');
            }
        }

        return output;
    };
}

function problem2() {
    var str = '<div data-bind-content="name"></div>',
        output1 = str.bind({name: 'Steven'}),
        bindingString = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>',
        output2 = bindingString.bind({name: 'Elena', link: 'http://telerikacademy.com'});

    console.log('\n***** Problem 2. HTML binding *****');
    console.log('Input:');
    console.log("var str = '<div data-bind-content=\"name\"></div>';");
    console.log("str.bind({name: 'Steven'});");
    console.log('Output:');
    console.log(output1);
    console.log('Input:');
    console.log('var str = \'<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></à>;');
    console.log("bindingString.bind({name: 'Elena', link: 'http://telerikacademy.com'});");
    console.log('Output:');
    console.log(output2);
}

problem2();
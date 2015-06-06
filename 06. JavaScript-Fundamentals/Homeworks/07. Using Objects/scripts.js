// Problem 1. Planar coordinates

function createPoint(x, y) {
    return {
        x: x,
        y: y,
        toString: function () {
            return '(' + this.x + ', ' + this.y + ')';
        }
    };
}

function createLine(pointA, pointB) {
    return {
        start: pointA,
        end: pointB,
        toString: function () {
            return 'start point ' + this.start + ', end point ' + this.end;
        }
    };
}

function calculateDistance(pointA, pointB) {
    var startDist = pointB.x - pointA.x,
        endDist = pointB.y - pointA.y;

    return Math.sqrt((startDist * startDist) + (endDist * endDist));
}

function isTriangle(a, b, c) {
    if ((a + b > c) && (b + c > a) && (c + a > b)){
        return true;
    }
    return false;
}

function problem1() {
    var x1 = -1000,
        y1 = 12,
        x2 = -14.5,
        y2 = 15,
        x3 = 0,
        y3 = 20.3,
        p1 = createPoint(x1, y1),
        p2 = createPoint(x2, y2),
        p3 = createPoint(x3, y3),
        line1 = createLine(p1, p2),
        line2 = createLine(p2, p3),
        line3 = createLine(p3, p1),
        distanceP1P2 = calculateDistance(p1, p2),
        distanceP2P3 = calculateDistance(p2, p3),
        distanceP3P1 = calculateDistance(p3, p1),
        validTriangle = isTriangle(distanceP1P2, distanceP2P3, distanceP3P1);

    console.log('***** Problem 1. Planar coordinates *****');
    console.log('Point 1 ' + p1.toString());
    console.log('Point 2 ' + p2.toString());
    console.log('Point 3 ' + p3.toString());
    console.log('Line 1: ' + line1.toString());
    console.log('Line 2: ' + line2.toString());
    console.log('Line 3: ' + line3.toString());
    console.log('Distance between Point 1 and Point 2 is ' + distanceP1P2);
    console.log('Distance between Point 2 and Point 3 is ' + distanceP2P3);
    console.log('Distance between Point 3 and Point 1 is ' + distanceP3P1);
    console.log(validTriangle ? 'The three lines CAN form a triangle' : 'The three lines CAN NOT form a triangle');
}

// Problem 2. Remove elements

Array.prototype.removeAll = function(elementToRemove) {
    var i,
        len;

    for (i = 0, len = this.length; i < len; i += 1) {
        if (this[i] === elementToRemove) {
            this.splice(i, 1);
            i -= 1;
            len -= 1;
        }
    }
};

function problem2() {
    var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '\'1\''],
        remove = 1;

    console.log('\n\n***** Problem 2. Remove elements *****');
    console.log('Array[' + arr + ']');

    arr.removeAll(remove);

    console.log('Element to remove: ' + remove);
    console.log('After removing: Array[' + arr + ']');
}

// Problem 3. Deep copy

function clone(input) {
    var i,
        cloned = {};

    if (typeof input === 'object') {
        for (i in input) {
            if (input.hasOwnProperty(i)) {
                cloned[i] = clone(input[i]);
            }
        }
    } else {
        return input;
    }
    return cloned;
}

function problem3() {
    var clonedStr,
        clonedNum,
        clonedBool,
        clonedObj,
        str = 'string',
        num = 2,
        bool = true,
        obj = {
            name: 'Peter',
            age: 20,
            isStudent: true,
            university: 'SU',
            gpa: 5.00,
            toString: function () {
                return 'Name: ' + this.name + ', Age: ' + this.age + ', Student? ' + this.isStudent +
                    ', University: ' + this.university + ', GPA: ' + this.gpa.toFixed(2);
            }
        };

    console.log('\n\n***** Problem 3. Deep copy *****');
    console.log('--- Original:');
    console.log(str);
    console.log(num);
    console.log(bool);
    console.log(obj.toString());

    clonedStr = clone(str);
    clonedNum = clone(num);
    clonedBool = clone(bool);
    clonedObj = clone(obj);

    console.log('--- Cloned:');
    console.log(clonedStr);
    console.log(clonedNum);
    console.log(clonedBool);
    console.log(clonedObj.toString());

    clonedStr = 'newStr';
    clonedNum = 22;
    clonedBool = false;
    clonedObj = {
        name: 'Ivan',
        age: 30,
        isStudent: false,
        toString: function () {
            return 'Name: ' + this.name + ', Age: ' + this.age + ', Student? ' + this.isStudent;
        }
    };

    console.log('--- Cloned - changed:');
    console.log(clonedStr);
    console.log(clonedNum);
    console.log(clonedBool);
    console.log(clonedObj.toString());
    console.log('--- Original - not:');
    console.log(str);
    console.log(num);
    console.log(bool);
    console.log(obj.toString());
}

// Problem 4. Has property

function hasProperty(obj, property) {
    var prop;

    for (prop in obj) {
        if (prop === property) {
            return true;
        }
    }
    return false;
}

function problem4() {
    var obj = {
        color: 'blue',
        length: '5m'
    };

    console.log('\n\n***** Problem 4. Has property *****');
    console.log(obj);
    console.log('Has property "color"? ' + hasProperty(obj, 'color'));
    console.log('Has property "length"? ' + hasProperty(obj, 'length'));
    console.log('Has property "age"? ' + hasProperty(obj, 'age'));
}

// Problem 5. Youngest person

function findYoungest(arr) {
    arr.sort(function(a, b) {
        return a.age - b.age;
    });

    return arr[0].firstname + ' ' + arr[0].lastname;
}

function problem5() {
    var i,
        len,
        youngest,
        people = [
            {firstname: 'Anton', lastname: 'Petrov', age: 32},
            {firstname: 'Elena', lastname: 'Ivanova', age: 21},
            {firstname: 'Peter', lastname: 'Petrov', age: 41},
            {firstname: 'Genadi', lastname: 'Avramov', age: 51}
        ];

    console.log('\n\n***** Problem 5. Youngest person *****');

    for (i = 0, len = people.length; i < len; i += 1) {
        console.log(people[i].firstname + ' ' + people[i].lastname + ' ' + people[i].age);
    }

    youngest = findYoungest(people);
    console.log('The youngest of above is: ' + youngest);
}

// Problem 6. Group an array of people

function buildPerson(firstName, lastName, age) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        toString: function getFullName() {
            return this.firstName + " " + this.lastName + ' ' + this.age + ' years old';
        }
    };
}

function groupBy(array, prop) {
    var i,
        len,
        result = {};

    for(i = 0, len = array.length; i < len; i += 1){
        if(!result[array[i][prop]]) {
            result[array[i][prop]] = [];
        }
        result[array[i][prop]].push(array[i].toString());
    }
    return result;
}

function problem6(){
    var person,
        vasil = buildPerson('Vasil', 'Vasilev', 30),
        angel = buildPerson('Angel', 'Vasilev', 35),
        todor = buildPerson('Vasil', 'Donev', 20),
        stamen = buildPerson('Stamen', 'Donev', 30),
        vera = buildPerson('Vera', 'Peicheva', 30),
        people = [vasil, angel, todor, stamen, vera],
        groupedByFname = groupBy(people, 'firstName'),
        groupedByLname = groupBy(people, 'lastName'),
        groupedByAge= groupBy(people, 'age') ;

    console.log('\n\n***** Problem 6. Group an array of people *****');
    console.log('---- People:');

    for (person in people) {
        if (people.hasOwnProperty(person)) {
            console.log(people[person].toString());
        }
    }

    console.log('---- Grouped by first name:');
    console.log(groupedByFname);
    console.log('---- Grouped by last name:');
    console.log(groupedByLname);
    console.log('---- Grouped by age:');
    console.log(groupedByAge);

}

// In case you want to see only the result of certain problem - comment others
problem1();
problem2();
problem3();
problem4();
problem5();
problem6();
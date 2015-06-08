console.log('********** Problem 1. Make person **********');

var firstLetter,
    youngestMale,
    len,
    males,
    females,
    averageFemalesAge,
    underage,
    isAgeAbove17,
    i,
    count = 10,
    people = [],
    groupedPeople = {},
    gender = ['male', 'female'],
    names = ['Todor', 'Atanas', 'Ivan', 'Marin', 'Malin', 'Biser', 'Yoan', 'Yordan', 'Kostadin', 'Boyan'];

for (i = 0; i < count; i += 1) {
    if (!(i % 2)) {
        people.push(createPerson(names[i], names[Math.random() * 10 | 0] + 'ov', Math.random() * 100 | 0, gender[0]));
    } else {
        people.push(createPerson(names[i] + 'ka', names[Math.random() * 10 | 0] + 'ova', Math.random() * 100 | 0, gender[1]));
    }
}

function createPerson(firstName, lastName, age, gender) {
    return {
        fName: firstName,
        lName: lastName,
        age: age,
        gender: gender,
        toString: function () {
            return this.fName + ' ' + this.lName + ', age: ' + this.age + ', gender: ' + this.gender;
        }
    };
}

function printPerson(person) {
    console.log(person.toString());
}

people.forEach(printPerson);
console.log('\n\n********** Problem 2. People of age **********');

isAgeAbove17 = people.every(function (person) {
    return person >= 18;
});

console.log('Is every person\'s age 18 or greater? ' + isAgeAbove17);
console.log('\n\n********** Problem 3. Underage people **********');

underage = people.filter(function (person) {
    return person.age < 18;
});

underage.forEach(printPerson);
console.log('\n\n********** Problem 4. Average age of females **********');

females = people.filter(function (person) {
    return person.gender === 'female';
});

females.forEach(printPerson);

averageFemalesAge = females.reduce(function (ageSum, person) {
    return ageSum + person.age;
}, 0) / females.length;

console.log('*** Result: ' + averageFemalesAge + ' years');
console.log('\n\n********** Problem 5. Youngest male person **********');

if (!Array.prototype.find) {
    Array.prototype.find = function(callback) {
        len = this.length;

        for (i = 0; i < len; i+=1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    };
}

youngestMale = people.sort(function (personA, personB) {
    return personA.age - personB.age;
}).find(function (person) {
    return person.gender === 'male';
});

males = people.filter(function (person) {
    return person.gender === 'male';
}).forEach(printPerson);

console.log('*** Result: ' + youngestMale);
console.log('\n\n********** Problem 6. Group people **********');

groupedPeople = people.reduce(function (obj, person) {
    firstLetter = person.fName[0].toLowerCase();

    if(!obj[firstLetter]) {
        obj[firstLetter] = [];
    }

    obj[firstLetter].push(person);
    return obj;
}, {});

console.log(groupedPeople);
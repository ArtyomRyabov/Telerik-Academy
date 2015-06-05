// Problem 1. Planar coordinates
(function p1() {
    var x1 = -1000,
        y1 = 5,
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
}());

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
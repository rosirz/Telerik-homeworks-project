'use strict'
//Write functions for working with shapes in standard Planar coordinate system.

// Points are represented by coordinates
// Lines are represented by two points, marking their beginning and ending You will be given three line segments. 
// Calculate their length. Check if the line segments can form a triangle.
// Input

// The input will consist of an array containing twelve values
// Line 1, Point 1 X
// Line 1, Point 1 Y
// Line 1, Point 2 X
// Line 1, Point 2 Y
// Line 2, Point 1 X
// ...
// Output

// The output should be consisted of four lines
// Three lines showing the length of each line segment
// Use 2 digits of precision
// Fourth line should be one of:
// Triangle can be formed
// Triangle can't be formed

function solve (args) {
    let first = MakeLine(+args[0],+args[1],+args[2],+args[3]),
        second = MakeLine(+args[4],+args[5],+args[6],+args[7]),
        third = MakeLine(+args[8],+args[9],+args[10],+args[11]);
        

function MakeLine (x1,y1,x2,y2){
    return {
        x1 : x1,
        y1 : y1,
        x2 : x2,
        y2 : y2,
        length : function (){
            return Math.sqrt((this.x2-this.x1)*(this.x2-this.x1)+(this.y2-this.y1)*(this.y2-this.y1))
        }
    }
}
function IfTriangle (first,second,third){
    if (first.length() + second.length() > third.length() &&
        first.length() + third.length() > second.length() &&
        second.length() + third.length() > first.length() ){
            console.log('Triangle can be built')
        }
        else {
            console.log('Triangle can not be built')
        }
}
console.log(first.length().toFixed(2));
console.log(second.length().toFixed(2));
console.log(third.length().toFixed(2));
IfTriangle(first,second,third)
}

solve([
  '7', '7', '2', '2',
  '5', '6', '2', '2',
  '95', '-14.5', '0', '-0.123'
]);
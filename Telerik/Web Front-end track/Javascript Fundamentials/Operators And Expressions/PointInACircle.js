'use strict'
//Implement a javascript function that by given coordinates of a point x and y and using an expression checks if given point (x, y) is inside 
// a circle K({0, 0}, 2) - the center has coordinates (0, 0) and the circle has radius 2. The program should then print "yes DISTANCE" if the point 
// is inside the circle or "no DISTANCE" if the point is outside the circle.

// In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.
// Input

// You will receive an array as a parameter. The array will contain exactly 2 string elements, the first being the x coordinate and the second - the y coordinate.
// Output

// Output a single line in the format described above. The distance should always be printed with 2-digits of precision after the floating point.
// You can use console.log to print the results or you can use return to return the answer. Both are correct.

function solve (args) {
    let x = args[0];
    let y = args[1];
    let r = 2;
    let distance = Math.sqrt(x * x + y * y);
    if (x*x + y*y <= r*r) 
        {
            console.log('yes '+ distance.toFixed(2)); 
        }
        else
        {
            console.log('no '+ distance.toFixed(2));
        }

}
solve('-1','2')
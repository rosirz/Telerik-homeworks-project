'use strict'
//Implement a javascript function that takes an argument array as a parameter and calculates rectangle’s area and perimeter by given width and height. 
//The width and height will both be passed in the argument array.

// Input

// The array that will be passed as argument will always have exactly 2 elements:
// The first element - a floating-point number that will represent the width of the rectangle.
// The second element - another floating-point number that will represent the height of the rectangle.
// Output

// Output a single line - the rectangle's area and perimeter, separated by a whitespace.
// Print the area and perimeter values with exactly 2-digits precision after the floating point.
// You can use console.log to print the results or you can use return to return the answer. Both are correct.

function rectangles ([width,height]){
    let rectWidth = +width;
    let rectHeight = +height;
    let area = rectWidth * rectHeight;
    let perimeter = 2*rectWidth + 2*rectHeight;
    console.log(area.toFixed(2)+' '+ perimeter.toFixed(2))
}

rectangles([ '2.5', '3' ])
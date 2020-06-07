'use strict'
//Implement a javascript function that accepts an array with a pair of coordinates x and y and uses an expression to checks 
// for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

// Input

// You will receive the pair of coordinates as two elements of an array - the first element will be x, and the second - y.
// Output

// Print inside circle if the point is inside the circle and outside circle if it's outside. Then print a single whitespace followed 
// by inside rectangle if the point is inside the rectangle and outside rectangle otherwise. See the sample tests for a visual description.
// You can use console.log to print the results or you can use return to return the answer. Both are correct.

function solve (args){
    let Kx = 1, //x coord of the center of the circle
        Ky = 1, //y coord of the center of the circle
        Kr = 1.5, //radius of the circle
        Rx1 = -1, //x coord of top left corner of rectangle
        Ry1 = 1, //y coord of top left corner of rectangle
        width = 6,
        height = 2,
        Rx2 = Rx1 + width, //x coord of bottom right corner of rectangle
        Ry2 = Ry1 - height, //y coord of bottom right corner of rectangle
        resultCircle,
        resultRectangle,
        x = args[0],//x coord of the point
        y = args[1];//y coord of the point

        if((x-Kx)*(x-Kx)+(y-Ky)*(y-Ky)<=Kr*Kr){
            resultCircle = 'inside circle';
        }
        else{
            resultCircle = 'outside circle';
        }
        if (x >= Rx1 && x <= Rx2 && y<= Ry1 && y>= Ry2){
            resultRectangle = 'inside rectangle'
        }
        else {
            resultRectangle = 'outside rectangle'
             }
        console.log(resultCircle+' '+resultRectangle)

}
solve (['0', '1'])
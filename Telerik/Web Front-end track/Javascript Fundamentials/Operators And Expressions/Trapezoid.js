'use strict'
//Implement a javascript function that calculates trapezoid's area by given sides a and b and height h. 
// The three values should be read from the console in the order shown below. 
// All three value will be floating-point numbers.

function solve (args){
    let a = +args[0];
    let b = +args[1];
    let h = +args[2];
    let area = ((a+b)*h)/2;
    console.log(area.toFixed(7))
}
solve(['5', '7', '12'])
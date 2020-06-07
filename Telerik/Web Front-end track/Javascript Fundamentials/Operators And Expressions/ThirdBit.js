'use strict'
//Using bitwise operators, write a javascript function(that accepts a single array with arguments as a parameter) that uses 
//an expression to find the value of the bit at index 3 of an unsigned integer read from the console.

// The bits are counted from right to left, starting from bit 0.
// The result of the expression should be either 1 or 0. Print it on the console.

function solve (number) {
    let integer = +number;
    //console.log(integer.toString(2))
    let mask = 1 << 3;
    let bit = (mask & integer) >> 3;
    console.log(bit)

}

solve ('1024')
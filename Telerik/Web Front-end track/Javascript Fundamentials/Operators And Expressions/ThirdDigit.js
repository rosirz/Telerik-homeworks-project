'use strict'
//Implement a javascript function that takes an array with a single element - an integer N as parameter and prints true if the third digit of N is 7,
//  or "false THIRD_DIGIT", where you should print the third digits of N.

// The counting is done from right to left, meaning 123456's third digit is 4.
// Input

// The input will always consist of an array with exactly one element, the integer N as a string.
// Output

// The output should be a single line - print whether the third digit is 7, following the format described above.
// You can use console.log to print the results or you can use return to return the answer. Both are correct.

function solve (integer){
    let round = integer | 0;
    let digit = ((round/100) | 0) % 10;
    if (digit == 7){
        console.log('true')
    }
    else{
        console.log('false'+' '+digit)
    }
}
solve('5')
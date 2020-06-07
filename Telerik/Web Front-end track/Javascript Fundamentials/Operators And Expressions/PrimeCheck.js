'use strict'
//Implement a javascript function that accepts an array containing an integer N as string (which will always be less than 100
// or equal) and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).

//Note: You should check if the number is positive.

function solve(integer) {
    let counter = 0;
    for (let i = 2; i<+integer/2;i+=1){
        if (+integer % i ==0 && +integer>2){
            counter+=1;
        }
    }
    if (counter != 0 || +integer<=1){
            console.log('false')
        }
        else {
            console.log('true')
        }
}
solve('23')
'use strict'

//Implement a javascript function that does the following:

// Accepts an array containing a single integer number as string.
// Stores in a variable if the number can be divided by 7 and 5 without remainder.
// Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. 
// Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.

function divisibleBy5and7 (number){
    
    let divisible;
    if (+number % 5 == 0 && +number % 7 == 0){
        divisible = +number;
        console.log('true'+' ' + divisible)
    }
    else {
        console.log('false'+' '+ number)
    }
}
divisibleBy5and7 ('35')

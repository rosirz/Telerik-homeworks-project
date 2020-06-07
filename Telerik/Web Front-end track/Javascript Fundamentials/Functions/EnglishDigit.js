'use strict'
//Write a method that returns the last digit of given integer as an English word. 
// Write a program that reads a number and prints the result of the method.

// Input

// On the first line you will receive a number
// Output

// Print the last digit of the number as an English word

function solve (args){
    let array= args[0],
        num = +array[array.length -1];

   function DigitAsWord (number){
       switch (number) {
           case 0: console.log('zero'); break;
           case 1: console.log('one'); break;
           case 2: console.log('two'); break;
           case 3: console.log('three'); break;
           case 4: console.log('four'); break;
           case 5: console.log('five'); break;
           case 6: console.log('six'); break;
           case 7: console.log('seven'); break;
           case 8: console.log('eight'); break;
           case 9: console.log('nine'); break;
       
           default:
               break;
       }
   } 
DigitAsWord(num);

}
solve(['42']);
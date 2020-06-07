'use strict'
//Write a function that removes all elements with a given value. Attach it to the array type. 
// Read about prototype and how to attach methods.

// var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
// arr.remove(1); // arr = [2,4,3,4,111,3,2,'1'];
// You will be given an array of strings. Remove all occurrences of the first element in the array in itself.

// Input

// The input will consist of an array of strings
// Output

// The output should be the array with some elements removed
// Each string should be on a separate line
Array.prototype.remove = function (array,element){
    for (let i=0; i<array.length; i+=1){
        if (array[i]===element){
            array.splice(i,1);
        }
    }
    return array;
}
function solve(args){
    let element = args[0];
       let array = args;  

// function remove (array,element){
//     for (let i=0; i<array.length; i+=1){
//         if (array[i]===element){
//             array.splice(i,1);
//         }
//     }
//     return array;
// }
for (let i=0; i<array.length; i+=1){
    console.log(array.remove(array,element)[i]);
}
}
solve([
  '_h/_',
  '^54F#',
  'V',
  '^54F#',
  'Z285',
  'kv?tc`',
  '^54F#',
  '_h/_',
  'Z285',
  '_h/_',
  'kv?tc`',
  'Z285',
  '^54F#',
  'Z285',
  'Z285',
  '_h/_',
  '^54F#',
  'kv?tc`',
  'kv?tc`',
  'Z285'
]);
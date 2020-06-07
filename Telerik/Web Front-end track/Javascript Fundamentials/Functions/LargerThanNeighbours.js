'use strict'
//Write a method that checks if the element at given position in given array of integers is larger 
// than its two neighbours (when such exist). Write program that reads an array of numbers and prints how many of 
// them are larger than their neighbours.

// Input

// On the first line you will receive the number N - the size of the array
// On the second line you will receive N numbers separated by spaces - the array
// Output

// Print how many numbers in the array are larger than their neighbours

function solve(args){
    let length = args[0],
    array = args[1].split(' ').map(Number);

    function Larger (array){
        let counter =0;
        for (let i=1; i<array.length-1; i+=1){
            if(array[i]>array[i-1] && array[i]>array[i+1]){
                counter+=1;
            }
        }
        console.log(counter);
    }

    Larger(array);
}
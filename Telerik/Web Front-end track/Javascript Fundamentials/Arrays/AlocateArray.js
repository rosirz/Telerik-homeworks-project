'use strict'
//Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 
//and the prints the obtained array on the console.

function solve (args){
    let array = [];
    for (let i=0; i<+args[0]; i+=1){
    array.push(i*5);
    console.log(array[i])
    }
}
solve(['5']);
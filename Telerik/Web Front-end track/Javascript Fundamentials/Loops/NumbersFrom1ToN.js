'use strict'
//Implement a javascript function that accepts an array with a single element - positive integer N as string 
//and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.
function solve (args) {
    let N = +args[0];
    let str ="";
    for (let i=1; i<=N; i+=1){
        str+=i+" ";
        }
        console.log(str);
}
solve(['5']);
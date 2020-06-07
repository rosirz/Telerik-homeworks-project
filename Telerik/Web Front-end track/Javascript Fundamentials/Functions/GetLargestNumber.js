'use strict'
//Write a method GetMax() with two parameters that returns the larger of two integers. 
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

// Input

// On the first line you will receive 3 integers separated by spaces
// Output

// Print the largest of them
function solve(args){
    let array = args[0].split(" ").map(Number),
        first = array[0],
        second = array[1],
        third = array[2],
        max;
    max = GetMax(first,second);
    max = GetMax(max,third);

function GetMax (x,y){
    let max=x; 
    if(y>max){
        max=y;
    }
    return max;
}
    console.log(max);

}




solve(['3 9 19'])
'use strict'
//Write a program that compares two char arrays lexicographically (letter by letter).

// Input

// On the first line you will receive the first char array as a string
// On the second line you will receive the second char array as a string
// Output

// Print < if the first array is lexicographically smaller
// Print > if the second array is lexicographically smaller
// Print = if the arrays are equal
function solve(args){
    let first = args[0],//.split(''),
        second= args[1],//.split(''),
        minLength = Math.min(first.length,second.length)
        //console.log(minLength)
    for (let i=0; i< minLength;i+=1){
        
        if (first[i] < second[i]){
            console.log('<');
            return;   
            }
        if(first[i]>second[i]){
             console.log('>');
             return;
            }
    }
    if (first.length==second.length){
        console.log('=');
    }
    else if (first.length < second.length){
        console.log('<');
    }
    else {
        console.log('>');
    }
}

solve(['food', 'food1']);
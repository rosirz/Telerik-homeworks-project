'use strict'
//Write a method that counts how many times given number appears in a given array. 
// Write a test program to check if the method is working correctly.

// Input

// On the first line you will receive a number N - the size of the array
// On the second line you will receive N numbers separated by spaces - the numbers in the array
// On the third line you will receive a number X
// Output

// Print how many times the number X appears in the array
function solve (args){
    let N = +args[0];
        input = args[1].split(' ').map(Number);//console.log(input)
        let X = args[2];
        //  console.log(N);
        //  console.log(input);
        // console.log(X);
        function CountRepeat (input,X){
            let counter =0;
            for(let i=0; i<input.length; i+=1){
                if(input[i]===X){
                    counter+=1;
                }
            }
            return counter;
        }

       console.log(CountRepeat(args,X));

}
solve('8 28 6 21 6 -7856 73 73 -56 73');
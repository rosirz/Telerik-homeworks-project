'use strict'
//Write a program that finds the length of the maximal increasing sequence in an array of N integers.

// Input

// On the first line you will receive the number N
// On the next N lines the numbers of the array will be given
// Output

// Print the length of the maximal increasing sequence

function solve(args){
    let N = args.shift(),
        array = args.map(Number),
        counter = 1,
        maxCounter=1;
    // console.log(array);
    // console.log(N);
    for (let i=0; i<N-1; i+=1){
        if(array[i+1] > array[i]){
            counter+=1;
        }
       
        if (array [i+1] <= array[i] && counter>1 ){
            if(counter>maxCounter){
                maxCounter=counter;
            }
            counter=1;
        }


    }
     if(counter>maxCounter){
                maxCounter=counter;
    }
    console.log(maxCounter);
}
solve(['8', '7', '3', '2', '3', '4', '2', '2', '4']);
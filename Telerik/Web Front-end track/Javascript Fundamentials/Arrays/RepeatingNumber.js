'use strict'
//Write a program that finds the most frequent number in an array of N elements.

// Input

// On the first line you will receive the number N
// On the next N lines the numbers of the array will be given
// Output

// Print the most frequent number and how many time it is repeated
// Output should be REPEATING_NUMBER (REPEATED_TIMES times)
function solve (args){
     let N = args.shift(),
        array = args.map(Number),
        counter = 1,
        maxCounter=1,
        number;
    // console.log(array);
    // console.log(N);
    for (let i=0; i<N-1; i+=1){
        for(let j=i; j<N-1;j+=1){
            if(array[i]===array[j+1]){
                counter+=1;
            }
        }
        if(counter>maxCounter){
            maxCounter=counter;
            number=array[i];
        }
        counter=1;
    }
    console.log(`${number} (${maxCounter} times)`);
}
solve (['13', '4', '1', '1', '4', '2', '3', '4', '4', '1', '2', '4', '9', '3']);
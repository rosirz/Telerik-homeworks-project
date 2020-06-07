'use strict'
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
// Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest 
// from the rest, move it at the second position, etc.

// Input

// On the first line you will receive the number N
// On the next N lines the numbers of the array will be given
// Output

// Print the sorted array
// Each number should be on a new line

function solve(args){
     let N = args.shift(),
         array = args.map(Number),
         temp;
        
     for (let i = 0; i<N-1; i+=1){
         
         for (let j=i+1; j<N; j+=1){
             if (array[i] > array[j]){
                temp = array[i];
                array[i]=array[j];
                array[j]=temp; 
             }
         }
         
     }
     for(let i=0; i<N;i+=1){
         console.log(array[i]);
     }

}
solve(['6', '3', '4', '1', '5', '2', '6']);
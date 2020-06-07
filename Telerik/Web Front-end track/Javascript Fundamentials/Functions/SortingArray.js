'use strict'
//Write a method that returns the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

// Input

// On the first line you will receive the number N - the size of the array
// On the second line you will receive N numbers separated by spaces - the array
// Output

// Print the sorted array
// Elements must be separated by spaces
function solve (args) {
    let array = args[1].split(' ').map(Number);
        
    function sortArray (array){
        let sorted = [];

        function findMax (array, index){
            let maxElement=0,
                maxIndex=0;
                for (let i=index; i<array.length; i+=1){
                    if(array[i]>maxElement){
                        maxElement = array[i];
                        maxIndex = i;
                    }
                 }
                 array[maxIndex]=array[index];
                 array[index] = maxElement;
                 return maxElement;
        }

        for  (let i =0; i<array.length; i+=1){
            let element = findMax(array,i);
            sorted.unshift(element);
        }
        return sorted;
    }
    console.log(sortArray(array).join(" "))
    
}

solve(['6','3 4 1 5 2 6'])
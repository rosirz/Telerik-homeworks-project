'use strict'
//Write a method that returns the index of the first element in array that is larger than its neighbours, 
//or -1, if there is no such element.

function solve(args){
    let length = args[0],
    array = args[1].split(' ').map(Number);

    function Larger (array){
        let index =-1;
        for (let i=1; i<array.length-1; i+=1){
            if(array[i]>array[i-1] && array[i]>array[i+1]){
                index= i;
                return index;
            }
        }
        return index;
    }

    console.log(Larger(array));
}
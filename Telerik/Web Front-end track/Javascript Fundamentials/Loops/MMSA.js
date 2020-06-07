'use strict'
//Implement a javascript function that accepts an array of floating-point numbers as strings and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).

function solve (args){
    let length = args.length;
    let min = +args[0];
    let max = +args[0];
    let sum=0;
    let aver = 0;
    for (let i=0; i<length; i+=1){
        if(+args[i]<min){
            min = +args[i];
        }
        if(+args[i]>max){
            max = +args[i];
        }
        sum+=+args[i];
    }
    aver=sum/length;
    console.log("min="+min.toFixed(2));
    console.log("max="+max.toFixed(2));
    console.log("sum="+sum.toFixed(2));
    console.log("avg="+aver.toFixed(2));
}
solve(['2', '5', '1']);
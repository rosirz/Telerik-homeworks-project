'use strict'
//Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
function solve(args){
    let digit = args[0];
    if (digit.length === 1){
        switch (+digit) {
        case 0: console.log("zero"); break;
        case 1: console.log("one"); break;
        case 2: console.log("two"); break;
        case 3: console.log("three"); break;
        case 4: console.log("four"); break;
        case 5: console.log("five"); break;
        case 6: console.log("six"); break;
        case 7: console.log("seven"); break;
        case 8: console.log("eight"); break;
        case 9: console.log("nine"); break;
            default: console.log("not a digit")
                break;
        }
       }
     else if (digit.length === 2){
         let firstDig = +digit[0];
         let secondDig = +digit[1];
         if(firstDig === 1){
             switch (secondDig) {
            case 0: console.log("ten"); break;
            case 1: console.log("eleven"); break;
            case 2: console.log("twelve"); break;
            case 3: console.log("thirteen"); break;
            case 4: console.log("fourteen"); break;
            case 5: console.log("fifteen"); break;
            case 6: console.log("sixteen"); break;
            case 7: console.log("seventeen"); break;
            case 8: console.log("eightteen"); break;
            case 9: console.log("nineteen"); break;
            default: console.log("not a digit")
                break;
             }
            }
            else {
                
            }

     }
} 
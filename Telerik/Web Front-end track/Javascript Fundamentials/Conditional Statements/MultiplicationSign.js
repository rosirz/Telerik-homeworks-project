//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//  Use a sequence of if operators.

// Input

// The input will consist of an array containing three values - a, b and c represented as strings
// Output

// The output should be a single line containing +, - or 0

function solve (args) {
    let a = args[0];
    let b = args[1];
    let c = args[2];
    let counter = 0;
    if (a==0 || b==0 || c==0){
        console.log("0");
    }
    else {
    if (a<0){counter+=1;}
    if (b<0){counter+=1;}
    if (c<0){counter+=1;}
    if (counter % 2 == 0) {
        console.log("+")
    }
    else {
        console.log("-")
    }
    }
}
solve (['-2', '-2', '1'])
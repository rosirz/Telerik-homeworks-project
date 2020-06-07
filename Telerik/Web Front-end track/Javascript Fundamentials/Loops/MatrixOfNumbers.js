'use strict'
function solve (args){
    let length = +args[0];
    let str="";
    for (let i=1; i<=length;i+=1){
        for (let j = i; j<length+i;j+=1){
            str+= j+" ";
        }
        console.log(str);
        str="";
    }
}
solve(['10']);
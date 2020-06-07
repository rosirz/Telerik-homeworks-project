'use strict'
//Using loops implement a javascript function that converts a hex number number to its decimal representation.

function solve (args){
    let hex = args[0];
    let dec =0;
    for (let i=0; i<hex.length; i+=1){
        let digitValue;
        if(+hex[i]){
            digitValue = +hex[i];
        }
        else {
            switch (hex[i]){
                case 'A': digitValue=10; break
                case 'B': digitValue=11; break
                case 'C': digitValue=12; break
                case 'D': digitValue=13; break
                case 'E': digitValue=14; break
                case 'F': digitValue=15; break
                default: break
            }
        }
        dec = dec*16 + digitValue;
    }
    console.log(dec)
    // let str = dec.toString();
    // console.log(str);
}
solve(['4ED528CBB4']);
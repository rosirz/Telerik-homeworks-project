'use strict'
//Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.
function solve (args){
let name = args[0];
SayHello(name);
function SayHello (name){
    console.log(`Hello, ${name}!`)
}
SayHello (['Peter']);

}

//Write a script that finds the biggest of given 5 variables. Use nested if statements.
function solve (args){
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    let d = +args[3];
    let e = +args[4];
    let max = a;
    if (b>max){max=b;}
    if (c>max){max=c;}
    if (d>max){max=d;}
    if (e>max){max=e;}
    console.log(max);
    
}
solve(['-2', '-22', '1', '0', '0']);
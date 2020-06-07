//Sort 3 real values in descending order. Use nested if statements.

//Note: Don’t use arrays and the built-in sorting functionality.
function solve (args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    let max = a;
    let min = a;
    let middle = a;
    //determine max
    if (b>max) {max = b; }
    if (c>max) {max = c;}
    //determine min
    if (b<min) {min = b;}
    if (c<min) {min = c;}
    //determine middle
    if (b<max && b>min){middle = b;}
    if (c<max && c>min){middle = c;}
    console.log(max+" "+middle+" "+ min)
}

solve (['-2', '4', '3'])
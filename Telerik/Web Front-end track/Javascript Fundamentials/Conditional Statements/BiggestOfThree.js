//Write a script that finds the biggest of three numbers. Use nested if statements.
function solve (args) {
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    let max = a;

    if (b>max) {
        max = b;
    }
    if (c>max) {
        max = c;
    }
    console.log(max)
}
solve(['-0.1', '-0.5', '-1.1'])
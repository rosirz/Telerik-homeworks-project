//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 
//Calculates and prints its real roots.

// Note: Quadratic equations may have 0, 1 or 2 real roots.

// Input

// The input will consist of an array containing three values - a, b and c represented as strings
// Output

// The output should be a single line containing the real roots (see sample tests)
// Print numbers with two digits of precision after the floating point
// If there are two roots then x1 < x2
//Квадратното уравнение има следния вид: ax2 + bx + c = 0
//където a, b, c са реални числа, и a ≠ 0. Всяко квадратно уравнение може да има 0, 1 или 2 реални корена
//получени по следната формула:x=−b±√b 2−4ac/2a
//Числото D = b2 - 4ac се нарича дискриминанта.
//Ako D< 0, квадратното уравнение няма реални корени. Ako D = 0, уравнението има 1 реален корен x=−b/2a
//Ako D > 0, квадратното уравнение има 2 реални корена - -b+/-VD/2a

function solve (args){
    let a = +args[0];
    let b = +args[1];
    let c = +args[2];
    let Diskrim = b*b - 4*a*c;
    if (Diskrim < 0)
        {
            console.log("no real roots");
        }
        else if (Diskrim == 0)
        {
            let Onlyroot = -b / (2 * a);
            console.log("x1=x2="+Onlyroot.toFixed(2));
        }
        else
        {
            let root1 = (-b + Math.sqrt(Diskrim))/(2*a);
            let root2 =( -b - Math.sqrt(Diskrim))/(2*a) ;
            if (root1>root2) {
                console.log("x1="+root2.toFixed(2)+"; x2="+root1.toFixed(2));
            }
            else{
                console.log("x1="+root1.toFixed(2)+"; x2="+root2.toFixed(2));
            }
            
}
}

solve (['-1', '3', '0']);
//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
// As a result print the values a and b, separated by a space.

// Input

// The input will consist of an array containing two values - a and b represented as strings
// Output

// The output should be a single line containing two numbers

function  solve (args) {
   let first = args[0],
       second = args[1], 
       itermediate;;
   if (first > second) {
       intermediate = first;
       first = second;
       second = intermediate;
       
   }
   console.log(first+" "+second)
}

solve(['3', '4'])
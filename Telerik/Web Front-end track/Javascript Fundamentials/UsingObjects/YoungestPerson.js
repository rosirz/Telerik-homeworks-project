'use strict'
//Write a function that finds the youngest person in a given array of people and prints his/hers full name. 
// Each person has properties firstname, lastname and age.

// Example:

// var people = [
//     { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
//     { firstname: 'Bay', lastname: 'Ivan', age: 81 },
//     { firstname: 'John', lastname: 'Doe', age: 42 }
// ];
// Input

// The input will consist of an array containing 3 * N values
// N is the number of people
// Values represent firstname, lastname, age, ...
// Output

// The output should be consisted of one line
// The full name of the youngest person
function solve (args){
    let arrayOfPerson = [],
        youngest; 

    for (let i = 0, j=0; i<args.length; i+=3, j+=1){
        
        arrayOfPerson[j] =MakePerson(args[i],args[i+1],+args[i+2]);
    }
    //console.log(arrayOfPerson[0].age)

    function MakePerson (firstName,lastName,age){
        return {
            firstName : firstName,
            lastName : lastName,
            age : age,
            toString : function (){
                 return console.log(this.firstName + " " + this.lastName)
            }
        }
    }
        youngest = arrayOfPerson[0];
        for (let i=0; i<arrayOfPerson.length-1; i+=1)
        {
            if(arrayOfPerson[i].age < youngest.age){
                youngest = arrayOfPerson[i];
            }
        }
         youngest.toString();
    }
        // let youngest = first;
        // if (second.age < youngest.age){
        //     youngest = second;
        // }
        
    //     return youngest;
    // }
    // youngest= arrayOfPerson[0];
    // for (let i =0; i<arrayOfPerson.length-1; i+=1){
    //     youngest = GetYoungest(arrayOfPerson[i],youngest);
    // }
    

solve([
  'Penka', 'Hristova', '61',
  'System', 'Failiure', '88',
  'Bat', 'Man', '16',
  'Malko', 'Kote', '72'
]);
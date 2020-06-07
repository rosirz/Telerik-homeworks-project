using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to check if in a given expression the ( and ) brackets are put correctly.

//Input

//On the only line you will receive an expression
//Output

//Print Correct if the brackets are correct
//Incorrect otherwise
namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string Expression = Console.ReadLine();
           
            int counterOpenBracket = 0;
            int counterCloseBracket = 0;
            for (int i = 0; i < Expression.Length; i++)
            {
                if (Expression[i]== '(')
                {
                    counterOpenBracket++;
                    
                }
                if (Expression[i]==')')
                {
                    counterCloseBracket++;
                   
                }
                if (counterCloseBracket>counterOpenBracket)
                {
                    Console.WriteLine("Incorrect");
                    return;
                }
            }
            if (counterOpenBracket == counterCloseBracket)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
           
            
        }
    }
}

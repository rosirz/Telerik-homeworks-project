using System;
//Write a method that returns the last digit of given integer as an English word. Write a program that reads a number 
//and prints the result of the method.

//Input

//On the first line you will receive a number
//Output

//Print the last digit of the number as an English word
    class EnglishDigit
    {
    static void englishDigit (int a)
    {
        int number = a % 10;
        switch (number)
        {
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            case 0: Console.WriteLine("Zero"); break;
            default:
               
                break;
        }
    }
        static void Main()
        {
        englishDigit (int.Parse(Console.ReadLine()));
      
        }
    }


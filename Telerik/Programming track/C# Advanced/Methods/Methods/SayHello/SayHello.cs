﻿using System;
//Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.

//Input

//On the first line you will receive a name
//Output

//Print Hello, <name>!
    class SayHello
    {
    static void PrintHelloName()
    {
        //Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!",name);
    }
        static void Main()
        {
        PrintHelloName();
        }
    }


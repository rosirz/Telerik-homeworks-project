﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.
namespace DaysOfWeek
{
    class DaysOfWeek
    {
        static void Main(string[] args)
        {
            
            DateTime today = DateTime.Now;
            
            
            Console.WriteLine(today.DayOfWeek);
        }
    }
}

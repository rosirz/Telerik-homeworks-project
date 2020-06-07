using System;
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains 
//a digit; the last digit is kept in arr[0]). Write a program that reads two arrays representing positive integers and outputs 
//their sum.

//Input

//On the first line you will receive two numbers separated by spaces - the size of each array
//On the second line you will receive the first array
//On the third line you will receive the second array
//Output

//Print the sum as an array of digits(as described)
//Digits should be separated by spaces
class NumbersAsArray
{
    static void SumOfNumbersAsArray(int[] first, int[] second)
    {
        int smallerSize = Math.Min(first.Length, second.Length);
        int biggerSize = Math.Max(first.Length, second.Length);
        int[] result = new int[biggerSize + 1];//add one more element
        
        int counter = 0;
        for (int i = 0; i < smallerSize; i++) //add sum of the elements till the end of the smallest array
        {
            if (first[i] + second[i] + counter >= 10)
            {
                result[i] = (first[i] + second[i] + counter) % 10;
                counter = 1;
            }
            else
            {
                result[i] = first[i] + second[i] + counter;
                counter = 0;
            }
        }
        for (int j = smallerSize; j < biggerSize; j++) //add the elements of the biggest array after the length of the smaller array
        {
            if (first.Length > second.Length && first[j] + counter >= 10)
            {
                result[j] = (first[j] + counter) % 10;
                counter = 1;
            }
            else if (first.Length > second.Length && first[j] + counter < 10)
            {
                result[j] = first[j] + counter;
                counter = 0;
            }
            else if (second.Length > first.Length && second[j] + counter >= 10)
            {
                result[j] = (second[j] + counter) % 10;
                counter = 1;
            }
            else if (second.Length > first.Length && second[j] + counter < 10)
            {
                result[j] = second[j] + counter;
                counter = 0;
            }
        }
        if (counter==1) //if the sum of the last elements of the arrays is >10 set 1 to the last element of the new array
        {
            result[result.Length - 1] = 1;
        }

        //print the new array
        if (result[result.Length - 1] == 0) //removing the last digit if zero
        {
            for (int i = 0; i < result.Length-1; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }
        else
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }
    }
    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(' ');
        int FirstSize = int.Parse(sizes[0]);
        int SecondSize = int.Parse(sizes[1]);
        string[] FirstArray = Console.ReadLine().Split(' ');
        string[] SecondArray = Console.ReadLine().Split(' ');
        int[] first = new int[FirstSize];
        int[] second = new int[SecondSize];
        for (int i = 0; i < first.Length; i++)
        {
            first[i] = int.Parse(FirstArray[i]);
        }
        for (int j = 0; j < second.Length; j++)
        {
            second[j] = int.Parse(SecondArray[j]);
        }
        SumOfNumbersAsArray(first, second);
    }
}


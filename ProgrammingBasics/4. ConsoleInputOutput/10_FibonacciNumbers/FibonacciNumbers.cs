﻿//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
// (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
// Note that you may need to learn how to use loops.

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        Console.Write(firstNumber + " ");
        for (int i = 1; i < n; i++)
        {

            Console.Write("{0} ", secondNumber);
            int temp = secondNumber;
            secondNumber = secondNumber + firstNumber;
            firstNumber = temp;
        }
        Console.WriteLine();
    }
}

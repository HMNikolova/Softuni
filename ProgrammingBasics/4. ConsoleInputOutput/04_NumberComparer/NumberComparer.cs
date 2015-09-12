// Write a program that gets two numbers from the console and prints the greater of them. 
// Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Write a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Write b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The greater number is: " + Math.Max(a, b));
    }
}
using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        /*
         This problem come from C# Basics practical exam (10 April 2014 Morning). You may submit your solution here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
        Petya often plays with numbers. Her recent game was to play with 9-digit numbers and calculate their sums of digits, as well as to split them into triples with special properties. Help her to calculate very special numbers called “nine-digit magic numbers”.
        You are given two numbers: diff and sum. Using the digits from 1 to 7 generate all 9-digit numbers in format abcdefghi, such that their sub-numbers abc, def and ghi have a difference diff (ghi-def = def-abc = diff), their sum of digits is sum and abc ≤ def ≤ ghi. Numbers holding these properties are also called “nine-digit magic numbers”.
        Your task is to write a program to print these numbers in increasing order.
         */

        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int resultsCount = 0;
        for (int num1 = 111; num1 <= 777; num1++)
        {
            int num2 = num1 + diff;
            int num3 = num2 + diff;

            if (AllowedValues(num1) && AllowedValues(num2) && AllowedValues(num3) &&
                 num3 <= 777 && (SumOfDigits(num1) + SumOfDigits(num2)
                + SumOfDigits(num3)) == sum)
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                resultsCount++;
            }
        }
        if (resultsCount == 0)
            Console.WriteLine("No");
    }

    private static bool AllowedValues(int num)
    {
        string digits = num.ToString();

        foreach (var element in digits)
        {
            if (element < '1' || element > '7')
            {
                return false;
            }
        }
        return true;
    }

    private static int SumOfDigits(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }
}
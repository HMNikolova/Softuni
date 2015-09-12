using System;
using System.Collections.Generic;

    class HalfSum
    {
        static void Main()
        {
            /*
             This problem comes from C# Basics practical exam (10 April 2014 Morning). You may submit your solution here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
            Nakov likes numbers. He often plays with their sums and differences. Once he invented the following game. He takes a sequence of numbers, splits them into two subsequences with the same number of elements and sums the left and right sub-sums, and compares the sub-sums. Please help him.
            You are given a number n and 2*n numbers. Write a program to check whether the sum of the first n numbers is equal to the sum of the second n numbers. Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the left and the right sums.

             */

            int n = Int32.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int x = 0; x < 2 * n; x++)
            {
                numbers.Add(Int32.Parse(Console.ReadLine()));
            }
            int group1 = 0;
            int group2 = 0;
            for (int z = 0; z < 2 * n / 2; z++)
            {
                group1 = group1 + numbers[z];
            }
            for (int y = 2 * n / 2; y < 2 * n; y++)
            {
                group2 = group2 + numbers[y];
            }
            if (group1 == group2)
            {
                Console.WriteLine("Yes, sum=" + group1);
            }
            else
            {
                int diff = Math.Abs(group1 - group2);
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }


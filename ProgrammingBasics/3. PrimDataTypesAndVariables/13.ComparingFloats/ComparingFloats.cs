using System;
using System.Collections.Generic;

    class ComparingFloats
    {
        static void Main()
        {
            //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. 

            List<double> floatPointNumb1 = new List<double> { 5.3, 5.00000001, 5.00000005, -0.0000007, -4.999999, 4.999999 };
            List<double> floatPointNumb2 = new List<double> { 6.01, 5.00000003, 5.00000001, 0.00000007, -4.999998, 4.999998 };

            double eps = 0.000001;
            for (int i = 0; i < 6; i++)
            {
                double diff = Math.Abs(floatPointNumb1[i] - floatPointNumb2[i]);
                if (diff <= eps)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }


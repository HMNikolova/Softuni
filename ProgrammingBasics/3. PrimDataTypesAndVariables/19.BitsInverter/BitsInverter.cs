using System;

    class BitsInverter
    {
        static void Main()
        {
            /*
             This problem come from C# Basics practical exam (10 April 2014 Morning). You may submit your solution here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
            Once Teodor played the following game: he started from a sequence of white and black balls and flipped the color of the 1st ball, then the color of the 4th ball, then the color of the 7th ball, etc. until the last ball. Flipping was performed by replacing a black b all with a white ball and vice versa. Teodor was a smart mathematician so he wanted to generalize his game in a formal way. This is what he invented.
            You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.  You are given also a number step. Write a program to invert the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
            Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 1.
             */

            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            short[] num = new short[n];
            int pos = 7;
            for (int index = 0; index < n; index++)
            {
                num[index] = byte.Parse(Console.ReadLine());
                for ( ; ; )
                {
                    if (pos >= 0)
                    {
                        num[index] = changeValue(num[index], pos);
                        pos -= step;
                    }
                    else
                    {
                        pos += 8;
                        break;
                    }
                }
            }
            foreach (int x in num)
            {
                Console.WriteLine(x);
            }
        }
 
    private static short changeValue(short num, int pos)
    {
        if ((num & (1 << pos)) != 0)
        {
            num -= (short)(1 << pos);
        }
        else
        {
            num += (short)(1 << pos);
        }
        return num;
    }
 }
    

using System;

class IsoscelesTriangle
    {
        static void Main()
        {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = Int32.Parse(Console.ReadLine());
            char copyright = '\u00A9';

            //Drawning first line
            Console.Write(new string(' ', n - 1));
            Console.Write(copyright);
            Console.WriteLine(new string(' ', n - 1));

            //Drawning form line 2 to n -1

            for (int i = 2; i <= n - 1; i++)
            {
                int numbersOfCopy = i;
                int numbersOfSpaces = n - numbersOfCopy; // Number of spaces before and after copyright symbol
                int spacesBetweenCopy = (i * 2) - 3; // Spaces between copyright symbols 

                Console.Write(new string(' ', numbersOfSpaces));
                Console.Write(copyright);
                Console.Write(new string(' ', spacesBetweenCopy));
                Console.Write(copyright);
                Console.WriteLine(new string(' ', numbersOfSpaces));

            }

            for (int j = 0; j <= n - 1; j++) // Drawning last line
            {
                Console.Write(new string(copyright, 1));
                Console.Write(new string(' ', 1));

            }

            Console.WriteLine();
        }
    }


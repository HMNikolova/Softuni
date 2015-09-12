using System;

class Sunglasses
    {
        static void Main()
        {
            /*
             This problem come from C# Basics practical exam (10 April 2014 Morning). You may submit your solution here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
             Do you know that the next solar eclipse will occur on April 29, 2014? It will be observable from South Asia, Australia, the Pacific and the Indian Oceans and Antarctica. Spiro is an entrepreneur who wants to cash in on this natural phenomenon. Help him produce protective sunglasses of different sizes. You will get 5% of the profit.
             */

            int N = Int32.Parse(Console.ReadLine());
            int width = N * 2;

            Console.Write(new string('*', width));
            Console.Write(new string(' ', N));
            Console.WriteLine(new string('*', width));

            for (int i = 1; i < N - 1; i++)
            {
                int lenses = (N * 2) - 2;

                Console.Write("*");
                Console.Write(new string('/', lenses));
                Console.Write("*");
                if (i == N / 2)
                {
                    Console.Write(new string('|', N));
                }
                else
                {
                    Console.Write(new string(' ', N));
                }
                Console.Write("*");
                Console.Write(new string('/', lenses));
                Console.WriteLine("*");

            }
            Console.Write(new string('*', width));
            Console.Write(new string(' ', N));
            Console.WriteLine(new string('*', width));
        }
    }


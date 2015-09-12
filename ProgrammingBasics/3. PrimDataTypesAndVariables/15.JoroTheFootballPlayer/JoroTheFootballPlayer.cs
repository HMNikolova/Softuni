using System;

    class JoroTheFootballPlayer
    {
        static void Main()
        {
            /*
             This problem comes from C# Basics practical exam (10 April 2014 Morning). You may submit your solution here: http://judge.softuni.bg/Contests/2/CSharp-Basics-Exam-10-April-2014-Morning.
            Joro loves a lot to play football. He used to play for his local village club “Pantera” Kaloyanovets. However, he is a programmer now and he is very busy. Now he is able to play only in the holidays and in the weekends. Joro plays in 1/2 of the holidays and once in the weekends, but not every weekend – only when he is not tired and only when he is not going to his hometown. Joro goes at his hometown h weekends in the year. The other weekends are considered “normal”. Joro is tired in 1/3 of the normal weekends. When Joro is at his hometown, he always plays football with his old friends once, at Sunday. In addition, if the year is leap, Joro plays football 3 more times additionally, in non-weekend days. We assume the year has exactly 52 weekends.
            Your task is to write a program that calculates how many times Joro plays football (rounded down to the nearest integer number).
             */

            string t = Console.ReadLine(); // The string “t” for leap year or “f” for year that is not leap.
            int p = Int32.Parse(Console.ReadLine()); //The number p – number of holidays in the year (which are not Saturday or Sunday).
            int h = Int32.Parse(Console.ReadLine()); //The number h – number of weekends that Joro spends in his hometown.

            if (t == "t")
            {
                double hometownPlays = h;
                double weekends = (52 - h) * 2 / 3;
                double holliday = (p / 2);
                int addForLeapYear = 3;
                int howManyPlays = (int)hometownPlays + (int)weekends + (int)holliday + addForLeapYear; //sum of played games from Joro
                Console.WriteLine(howManyPlays);
            }
            else
            {
                double hometownPlays = h;
                double weekends = (52 - h) * 2 / 3;
                double holliday = (p / 2);
                int howManyPlays = (int)hometownPlays + (int)weekends + (int)holliday; //sum of played games from Joro
                Console.WriteLine(howManyPlays);
            }
        }
    }


using System;

class QuotesInStrings
    {
        static void Main()
        {
            //Declare two string variables and assign them with following value:The "use" of quotations causes difficulties.Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.

            string one = "The \"use\" of quotations causes difficulties.";
            string two = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("{0}{1}{2}", one, Environment.NewLine, two);
        }
    }

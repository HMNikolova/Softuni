using System;

class ExchangeVariableValues
    {
        static void Main()
        {
            //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.

            int a = 5;
            int b = 10;
            int c;

            Console.WriteLine("a = {0} and b= {1}", a, b);
            if (b > a)
            {
                c = b;
                b = a;
                a = c;
                Console.WriteLine("After exchange (if b > a) a = {0} and b = {1}", a, b);
            }
            else
            {
                Console.WriteLine("a = {0} and b = {1}", a, b);
            }
        }
    }


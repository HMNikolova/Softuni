﻿using System;
using System.Text;

    class PrintTheASCII_Table
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently. You may need to use for-loops (learn in Internet how).

            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 256; i++)
            {
                char symbolFromASCII = (char)i;
                Console.WriteLine("Decimal code {0} is this symbol {1} from ASCII table", i, symbolFromASCII);
            }
        }
    }


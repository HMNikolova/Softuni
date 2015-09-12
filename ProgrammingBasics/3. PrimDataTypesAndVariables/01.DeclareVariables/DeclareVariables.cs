using System;

    class declareVariables
    {
        static void Main()
        {
            //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.
            
            ushort one = 52130;
            sbyte two = -115;
            int three = 4825932;
            byte four = 97;
            short five = -10000;

            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}", one, Environment.NewLine, two, Environment.NewLine, three, Environment.NewLine, four, Environment.NewLine, five);

        }
    }


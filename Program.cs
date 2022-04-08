using System;

namespace OfflineCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables initialization
            InputProcessor processor = new InputProcessor();
            string stringInputA = "123456";
            string stringInputB = "456";

            int intInputA = 123;
            int intInputB = 456789;

            string result1 = processor.ProcessInput(stringInputA, stringInputB);
            Console.WriteLine(result1);
            Console.WriteLine();
            string result2 = processor.ProcessInput(intInputA, intInputB);
            Console.WriteLine(result2);
            Console.WriteLine();

            string stringNegativeInputA = "-123456";
            string stringNegativeInputB = "-456";

            int intNegativeInputA = -123;
            int intNegativeInputB = -456789;

            string result3 = processor.ProcessInput(stringNegativeInputA, stringNegativeInputB);
            Console.WriteLine(result3);
            Console.WriteLine();
            string result4 = processor.ProcessInput(intNegativeInputA, intNegativeInputB);
            Console.WriteLine(result4);
            Console.WriteLine();


            string stringMixedInputA = "-12abc3";
            string stringMixedInputB = "-12abc3";

            string result5 = processor.ProcessInput(stringMixedInputA, stringMixedInputB);
            Console.WriteLine(result5);
            Console.WriteLine();


            string result6 = processor.ProcessInput(" ", " ");
            Console.WriteLine(result6);
            Console.WriteLine();
        }
    }
}

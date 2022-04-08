using System;

namespace OfflineCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables initialization
            InputProcessor processor = new InputProcessor();
            string stringInputA = "123";
            string stringInputB = "123";

            int intInputA = 123;
            int intInputB = 123;

            string result1 = processor.ProcessInput(stringInputA, stringInputB);
            Console.WriteLine();
            string result2 = processor.ProcessInput(intInputA, intInputB);
            Console.WriteLine();

            string stringNegativeInputA = "-123";
            string stringNegativeInputB = "-123";

            int intNegativeInputA = -123;
            int intNegativeInputB = -123;

            string result3 = processor.ProcessInput(stringNegativeInputA, stringNegativeInputB);
            Console.WriteLine();
            string result4 = processor.ProcessInput(intNegativeInputA, intNegativeInputB);
            Console.WriteLine();


            string stringMixedInputA = "-12abc3";
            string stringMixedInputB = "-12abc3";

            string result5 = processor.ProcessInput(stringMixedInputA, stringMixedInputB);
            Console.WriteLine();
        }
    }
}

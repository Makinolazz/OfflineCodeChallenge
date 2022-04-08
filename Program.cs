using System;

namespace OfflineCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            InputProcessor processor = new InputProcessor();

            //Example 1: string inputs + different size
            string stringInputA = "4321";
            string stringInputB = "34";

            string result1 = processor.ProcessInput(stringInputA, stringInputB);
            Console.WriteLine(result1);
            Console.WriteLine();


            //Example 2: int inputs + different size
            int intInputA = 123;
            int intInputB = 2345;
            
            string result2 = processor.ProcessInput(intInputA, intInputB);
            Console.WriteLine(result2);
            Console.WriteLine();


            //Example 3: negative string inputs + different size
            string stringNegativeInputA = "-4321";
            string stringNegativeInputB = "-54";

            string result3 = processor.ProcessInput(stringNegativeInputA, stringNegativeInputB);
            Console.WriteLine(result3);
            Console.WriteLine();


            //Example 4: negative int inputs + different size
            int intNegativeInputA = -12;
            int intNegativeInputB = -2345;
            
            string result4 = processor.ProcessInput(intNegativeInputA, intNegativeInputB);
            Console.WriteLine(result4);
            Console.WriteLine();


            //Example 5: positive + negative string inputs + different size
            string result5 = processor.ProcessInput(stringInputA, stringNegativeInputB);
            Console.WriteLine(result5);
            Console.WriteLine();


            //Example 6: mixed string inputs
            string stringMixedInputA = "12abc3";
            string stringMixedInputB = "-12abc3";

            string result6 = processor.ProcessInput(stringMixedInputA, stringMixedInputB);
            Console.WriteLine(result6);
            Console.WriteLine();


            //Example 7: empty string inputs
            string result7 = processor.ProcessInput(" ", " ");
            Console.WriteLine(result7);
            Console.WriteLine();
        }
    }
}

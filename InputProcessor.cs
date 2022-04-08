using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OfflineCodeChallenge
{
    public class InputProcessor
    {
        private int[] FirstArray { get; set; }
        private int[] SecondArray { get; set; }
        private int[] ResultArray { get; set; }
        private bool isInputANegative;
        private bool isInputBNegative;
        private bool HasInvalidData;
        public string Result { get; set; }


        public string ProcessInput(string inputA, string inputB)
        {
            ValidateEmptyInputs(inputA, inputB);
            VerifyNegativeInputs(ref inputA, ref inputB);

            FirstArray = BuildIntArray(inputA);
            SecondArray = BuildIntArray(inputB);

            if (!HasInvalidData)
            {
                if (isInputANegative)
                {
                    SetNegativeValues(FirstArray);
                }

                if (isInputBNegative)
                {
                    SetNegativeValues(SecondArray);
                }

                Array.Reverse(SecondArray);
                SumArraysItems();
                PrintResult();
                return ResultArray.ToString();
            }
            else
            {
                Console.WriteLine("Invalid input data");
                return "Invalid input data";
            }            
        }

        private void SetNegativeValues(int[] storedArray)
        {
            for (int i = 0; i < storedArray.Length; i++)
            {
                storedArray[i] = storedArray[i] * -1;
            }
        }

        private void ValidateArray(int[] array)
        {
            HasInvalidData = array.Any(x => x == -1) ? true : false;
        }

        private void VerifyNegativeInputs(ref string inputA, ref string inputB)
        {
            isInputANegative = IsNegative(inputA);
            isInputBNegative = IsNegative(inputB);

            inputA = RemoveMinusSign(inputA);
            inputB = RemoveMinusSign(inputB);
        }

        private static bool IsNegative(string input)
        {
            return input[0].Equals('-') ? true : false;
        }

        private string RemoveMinusSign(string input)
        {
            input = input.Replace('-', ' ');
            return input.Trim();
        }

        public string ProcessInput(int inputA, int inputB)
        {
            return ProcessInput(inputA.ToString(), inputB.ToString());
        }

        private void PrintResult()
        {
            for (int i = 0; i < ResultArray.Length; i++)
            {
                Console.Write(ResultArray[i]);
            }
        }

        private void SumArraysItems()
        {
            int[] shortestArray;

            if (FirstArray.Length <= SecondArray.Length)
            {
                ResultArray = SecondArray;
                shortestArray = FirstArray;
            }
            else
            {
                ResultArray = FirstArray;
                shortestArray = SecondArray;
            }

            for (int i = 0; i < shortestArray.Length; i++)
            {
                ResultArray[i] += shortestArray[i];
            }
        }

        private int[] BuildIntArray(string input)
        {
            var resultArray = input.Trim().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            ValidateArray(resultArray);
            return resultArray;
        }

        private void ValidateEmptyInputs(string inputA, string inputB)
        {
            if (string.IsNullOrEmpty(inputA) || string.IsNullOrEmpty(inputB))
            {
                Console.WriteLine("Inputs can't be empty");
            }
        }
    }
}

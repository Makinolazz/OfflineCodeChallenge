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


        public string ProcessInput(string inputA, string inputB)
        {
            //Checks if any input is empty
            if (InputValidator.IsEmptyInput(inputA) || InputValidator.IsEmptyInput(inputB))
            {
                return Messages.EmptyInput();
            }
            
            //Checks if any input is negative or contains a minus sign (-) at the first position
            isInputANegative = InputValidator.IsNegativeInput(inputA);
            isInputBNegative = InputValidator.IsNegativeInput(inputB);

            //Removes minus sign (-) from the input to handle it easier
            if (isInputANegative)
            {
                inputA = StringFormatHelper.RemoveMinusSign(inputA);
            }

            if(isInputBNegative)
            {
                inputB = StringFormatHelper.RemoveMinusSign(inputB);
            }
            
            //Returns an int[] from the input string
            FirstArray = InputArrayTool.BuildIntArray(inputA);
            SecondArray = InputArrayTool.BuildIntArray(inputB);
            
            //Checks if non numeric chars (-1 value) were found in the int[]
            if (InputValidator.HasInvalidData(FirstArray) || InputValidator.HasInvalidData(SecondArray))
            {
                return Messages.InvalidData();
            }

            //If the input was a negative number, change the int[] values to negative
            if (isInputANegative)
            {
                FirstArray = InputArrayTool.SetNegativeValues(FirstArray);
            }

            if (isInputBNegative)
            {
                SecondArray = InputArrayTool.SetNegativeValues(SecondArray);
            }

            //Reverse the second array
            Array.Reverse(SecondArray);

            //Sum arrays values
            ResultArray = InputArrayTool.SumArraysItems(FirstArray, SecondArray);

            return string.Join("", ResultArray);                
        }
        
        public string ProcessInput(int inputA, int inputB)
        {
            return ProcessInput(inputA.ToString(), inputB.ToString());
        }
        
    }
}

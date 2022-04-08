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
            if (InputValidator.IsEmptyInput(inputA) || InputValidator.IsEmptyInput(inputB))
            {
                return Messages.EmptyInput();
            }
            
            isInputANegative = InputValidator.IsNegativeInput(inputA);
            isInputBNegative = InputValidator.IsNegativeInput(inputB);

            if (isInputANegative)
            {
                inputA = StringFormatHelper.RemoveMinusSign(inputA);
            }

            if(isInputBNegative)
            {
                inputB = StringFormatHelper.RemoveMinusSign(inputB);
            }
            
            FirstArray = InputArrayTool.BuildIntArray(inputA);
            SecondArray = InputArrayTool.BuildIntArray(inputB);
            
            if (InputValidator.HasInvalidData(FirstArray) || InputValidator.HasInvalidData(SecondArray))
            {
                return Messages.InvalidData();
            }

            if (isInputANegative)
            {
                FirstArray = InputArrayTool.SetNegativeValues(FirstArray);
            }

            if (isInputBNegative)
            {
                SecondArray = InputArrayTool.SetNegativeValues(SecondArray);
            }

            Array.Reverse(SecondArray);

            ResultArray = InputArrayTool.SumArraysItems(FirstArray, SecondArray);

            return string.Join("", ResultArray);                
        }
        
        public string ProcessInput(int inputA, int inputB)
        {
            return ProcessInput(inputA.ToString(), inputB.ToString());
        }
        
    }
}

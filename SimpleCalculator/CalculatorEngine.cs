using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public static double Calculate(string operation, double firstNumber, double secondNumber)
        {
            var result = operation.ToLower() 
                
            switch
            {
                "add" or "+" => firstNumber + secondNumber,
                "subtract" or "-" => firstNumber - secondNumber,
                "multiply" or "*" => firstNumber * secondNumber,
                "divide" or "/" => firstNumber / secondNumber,
                _ => throw new InvalidOperationException("Specified operation is not recognized."),
            };

            return result;
        }
    }
}
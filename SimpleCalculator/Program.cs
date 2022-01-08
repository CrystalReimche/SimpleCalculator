﻿using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();

            CalculatorEngine calculatorEngine = new CalculatorEngine();

            double firstNumber = inputConverter.ConvertInputToNum(Console.ReadLine());
            double secondNumber = inputConverter.ConvertInputToNum(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            Console.WriteLine(result);
        }
    }
}

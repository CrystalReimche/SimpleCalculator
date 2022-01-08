using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNum(string argTextInput) 
        {
            double convertedNumber;

            // check to see if user input sucessfully converted to number
            if (!double.TryParse(argTextInput, out convertedNumber))
            {
                throw new ArgumentException("Expected a numeric value");
            }
            return convertedNumber;
        }
    }
}
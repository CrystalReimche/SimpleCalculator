using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Test.Unit
{
    public class CalculatorEngineTest
    {
     

        [TestMethod()]
        public void AddTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = CalculatorEngine.Calculate("add", number1, number2);

            // takes in an expected result and an actual result.  If they are equal, it will pass.
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void AddTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = CalculatorEngine.Calculate("+", number1, number2);

            // takes in an expected result and an actual result.  If they are equal, it will pass.
            Assert.AreEqual(3, result);
        }
    }
}
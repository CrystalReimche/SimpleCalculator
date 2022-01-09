using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Test.Unit
{
    [TestClass()]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod()]
        public void AddTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);

            // takes in an expected result and an actual result.  If they are equal, it will pass.
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void AddTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);

            // takes in an expected result and an actual result.  If they are equal, it will pass.
            Assert.AreEqual(3, result);
        }

        
    }
}
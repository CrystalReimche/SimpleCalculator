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
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod()]
        public void ConvertValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNum(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertValidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.ConvertInputToNum(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }
    }
}
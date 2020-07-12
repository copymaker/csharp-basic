using NUnit.Framework;
using RoadBook.CsharpBasic.Chapter05.Works;

namespace RoadBook.CsharpBasic.Test.Chapter05
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void RunTest()
        {
            Calculator calculator = new Calculator();
            
            calculator.FourArithmeticOperation(50, 20);
        }
    }
}
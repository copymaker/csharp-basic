using System;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex004
    {
        private delegate void RunCalc(int a, int b);
        
        private static void Sum(int number1, int number2)
        {
            Console.WriteLine($"SUM : {number1 + number2}");
        }
        
        private static void Multiply(int number1, int number2)
        {
            Console.WriteLine($"MULTI : {number1 * number2}");
        }
        
        private static void Divide(int number1, int number2)
        {
            Console.WriteLine($"DIV : {number1 / number2}");
        }

        public void Run()
        {
            RunCalc calc = (RunCalc) Delegate.Combine(new RunCalc(Sum), new RunCalc(Multiply), new RunCalc(Divide));
            calc(20, 4);
        }
    }
}
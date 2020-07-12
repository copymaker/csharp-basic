using System;

namespace RoadBook.CsharpBasic.Chapter05.Works
{
    public class Calculator
    {
        public void FourArithmeticOperation(int operand1, int operand2)
        {
            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, Sum(operand1, operand2));
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, Substract(operand1, operand2));
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, Multiple(operand1, operand2));
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, Divide(operand1, operand2));
        }

        private int Sum(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        private int Substract(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        private int Multiple(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        private double Divide(int operand1, int operand2)
        {
            return (double) operand1 / operand2;
        }
    }
}
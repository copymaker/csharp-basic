using System;

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    /*
     * 사용자에게 두개의 수를 입력 받아
     * 사칙연산의 결과를 알려주는 프로그램을 만들어보세요.
     */
    public class Exam002
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("첫번째 숫자를 입력해 주세요!");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("두번째 숫자를 입력해 주세요!");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, firstNumber + secondNumber);
                Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, firstNumber - secondNumber);
                Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, firstNumber * secondNumber);
                Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, (double) firstNumber / secondNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
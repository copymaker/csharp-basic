using System;

namespace RoadBook.CsharpBasic.Chapter02.Works
{
    /*
     * 사용자에게 두개의 수를 입력 받아
     * 처음 입력한 값이 두번째 입력한 값보다 클 경우
     * True를 출력하는 프로그램을 만들어보세요.
     */
    public class Exam001
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("첫번째 숫자를 입력해 주세요!");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("두번째 숫자를 입력해 주세요!");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} 가 {1} 보다 큽니다. ({2})", firstNumber, secondNumber, firstNumber > secondNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
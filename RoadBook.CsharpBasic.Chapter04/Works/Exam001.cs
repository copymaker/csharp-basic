using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam001
    {
        public void Run()
        {
            Console.WriteLine("숫자를 입력해주세요.");
            int number = Convert.ToInt32(Console.ReadLine());
            
            long result = 1;
            int index = number;
            while (index > 0)
            {
                result *= index;
                index--;
            }
            
            Console.WriteLine("{0} 팩토리얼 값은 {1} 입니다.", number, result);
        }
    }
}
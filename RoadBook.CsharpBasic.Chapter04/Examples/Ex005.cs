using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex005
    {
        public void Run()
        {
            int factorial = 1;
            int initial = 5;
            for (int i = initial; i > 0; i--)
            {
                factorial *= i;
            }
            
            Console.WriteLine("{0} 팩토리얼 값은 {1} 입니다.", initial, factorial);
        }
    }
}
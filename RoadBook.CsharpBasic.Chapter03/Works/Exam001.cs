using System;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    public class Exam001
    {
        public void Run()
        {
            Random random = new Random();
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);
            int rightAnswer = number1 + number2;
            
            Console.WriteLine("{0} + {1} 의 값을 입력해주세요.", number1, number2);
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == rightAnswer)
            {
                Console.WriteLine("정답입니다.");
            }
            else
            {
                Console.WriteLine("오답입니다. 답은 {0} 입니다.", rightAnswer);
            }
        }
    }
}
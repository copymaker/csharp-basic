using System;

namespace RoadBook.CsharpBasic.Chapter04.Works
{
    public class Exam002
    {
        public void Run()
        {
            Random random = new Random();
            int number = random.Next(1, 50);
            
            Console.WriteLine("1 ~ 50 까지의 숫자중 하나를 맞춰주세요.");

            bool isMatched = false;
            do
            {
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == number)
                {
                    isMatched = true;
                }
                else
                {
                    Console.WriteLine("틀렸습니다. {0}!", answer > number ? "DOWN" : "UP");
                }
            } while (!isMatched);
            Console.WriteLine("정답입니다.!");
        }
    }
}
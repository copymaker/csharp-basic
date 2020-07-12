using System;

namespace RoadBook.CsharpBasic.Chapter07.Works
{
    public class Exam002
    {
        public void Run()
        {
            Random random = new Random();
            int number = random.Next(0, 255);
            
            Console.Write("0 ~ 255 사이의 숫자를 입력해주세요.");

            while (true)
            {
                try
                {
                    byte answer = Convert.ToByte(Console.ReadLine());

                    if (answer == number)
                    {
                        break;
                    }
                
                    Console.WriteLine(answer > number ? "DOWN!" : "UP!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("숫자 형식이 아닙니다.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("숫자의 범위를 벗어났습니다.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            
            Console.WriteLine("정답입니다.");
        }
    }
}
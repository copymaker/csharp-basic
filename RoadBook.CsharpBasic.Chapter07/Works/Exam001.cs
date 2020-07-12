using System;

namespace RoadBook.CsharpBasic.Chapter07.Works
{
    public class Exam001
    {
        public void Run()
        {
            Console.Write("숫자를 입력해주세요 : ");

            int number = 0;
            bool isException = false;

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                isException = true;
                Console.WriteLine("숫자의 형식이 아닙니다.");
            }
            catch (OverflowException)
            {
                isException = true;
                Console.WriteLine("숫자의 범위를 벗어났습니다.");
            }
            catch (Exception e)
            {
                isException = true;
                Console.WriteLine(e);
            }
            finally
            {
                if (isException)
                {
                    number = -1;
                }
                Console.WriteLine($"입력한 정수는 {number} 입니다.");
            }
        }
    }
}
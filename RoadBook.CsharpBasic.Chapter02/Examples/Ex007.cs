using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex007
    {
        public void Run()
        {
            int korean = 100;
            int english = 100;
            int math = 98;
            int sports = 97;

            int total = korean + english + math + sports;
            int average = total / 4;
            
            Console.WriteLine("시험 총 점수는 {0} 점 입니다.", total);
            Console.WriteLine("시험 평균은 {0} 점 입니다.", average);
        }
    }
}
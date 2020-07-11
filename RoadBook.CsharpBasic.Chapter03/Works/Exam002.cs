using System;

namespace RoadBook.CsharpBasic.Chapter03.Works
{
    public class Exam002
    {
        public void Run()
        {
            Console.WriteLine("중간고사 점수를 입력해주세요.");
            int midScore = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("기말고사 점수를 입력해주세요.");
            int finalScore = Convert.ToInt32(Console.ReadLine());
            
            double average = midScore + finalScore / 2.0;

            Console.WriteLine("평균은 {0}이며 {1}학점 입니다.", average, CalculateGrade(average));
        }

        private static char CalculateGrade(double average)
        {
            if (average >= 90)
            {
                return 'A';
            }

            if (average >= 80)
            {
                return 'B';
            }
            
            if (average >= 70)
            {
                return 'C';
            }

            return 'F';
        }
    }
}
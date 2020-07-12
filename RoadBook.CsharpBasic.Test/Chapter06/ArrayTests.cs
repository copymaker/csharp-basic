using System;
using NUnit.Framework;

namespace RoadBook.CsharpBasic.Test.Chapter06
{
    [TestFixture]
    public class ArrayTests
    {
        [Test]
        public void ArrayWeatherRunTest()
        {
            // step1 배열 선언
            string[] weathers = new string[7];
            
            // step2 배열 초기 값 입력
            weathers[0] = "sunny";
            weathers[1] = "sunny";
            weathers[2] = "rainy";
            weathers[3] = "cloudy";
            weathers[4] = "rainy";
            weathers[5] = "snow";
            weathers[6] = "sunny";

            // step3 배열 가져오기
            int dayCnt = weathers.Length;

            int sunnyCnt = 0;
            int rainyCnt = 0;
            int cloudyCnt = 0;
            int snowCnt = 0;

            for (int idx = 0; idx < dayCnt; idx++)
            {
                string weather = weathers[idx];

                if (weather == "sunny")
                {
                    sunnyCnt++;
                }
                else if (weather == "rainy")
                {
                    rainyCnt++;
                }
                else if (weather == "cloudy")
                {
                    cloudyCnt++;
                }
                else if (weather == "snow")
                {
                    snowCnt++;
                }
            }
            
            Console.WriteLine("맑음: {0} / 흐림 : {1} / 비 : {2} / 눈 : {3}", sunnyCnt, cloudyCnt, rainyCnt, snowCnt);
        }

        [Test]
        public void IndexOutOfRangeExceptionTest()
        {
            string[] arr = new string[2];
            arr[0] = "a";
            arr[1] = "b";

            Assert.Throws<IndexOutOfRangeException>(() => { arr[2] = "c"; });
        }

        [Test]
        public void GradeOfStudentTest()
        {
            int[][] gradeOfStudent =
            {
                new int[] {100, 98, 95},
                new int[] {90, 100, 100},
                new int[] {95, 96, 95},
                new int[] {88, 92, 98}
            };

            for (int i = 0; i < gradeOfStudent.Length; i++)
            {
                for (int j = 0; j < gradeOfStudent[i].Length; j++)
                {
                    Console.WriteLine("{0}번째 학생의 {1}번째 과목의 성적은 {2}", i + 1, j + 1, gradeOfStudent[i][j]);
                }
            }
        }
    }
}
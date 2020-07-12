using System;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam001
    {
        public void Run()
        {
            int[] ages = {15, 20, 34, 35, 42, 44, 55, 2, 65, 72};

            int  countUnder20 = 0;
            int  count20 = 0;
            int  count30 = 0;
            int  count40 = 0;
            int  count50 = 0;
            int  countOver60 = 0;
            
            for (int i = 0; i < ages.Length; i++)
            {
                int ageBand = ages[i] / 10;

                if (ageBand < 2)
                {
                    countUnder20++;
                }
                else if (ageBand == 2)
                {
                    count20++;
                }
                else if (ageBand == 3)
                {
                    count30++;
                }
                else if (ageBand == 4)
                {
                    count40++;
                }
                else if (ageBand == 5)
                {
                    count50++;
                }
                else
                {
                    countOver60++;
                }
            }
            
            Console.WriteLine($"20대 미만 {countUnder20}명");
            Console.WriteLine($"20대 {count20}명");
            Console.WriteLine($"30대 {count30}명");
            Console.WriteLine($"40대 {count40}명");
            Console.WriteLine($"50대 {count50}명");
            Console.WriteLine($"60대 이상 {countOver60}명");
        }
    }
}

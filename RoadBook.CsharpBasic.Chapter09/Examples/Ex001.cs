using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex001
    {
        public void Run()
        {
            int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> tmpNumbers = new List<int>();
            
            // 짝수 찾기
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    tmpNumbers.Add(number);
                }
            }
            Console.WriteLine("짝수");
            tmpNumbers.ForEach(Console.WriteLine);
            tmpNumbers.Clear();
            
            // 홀수 찾기
            tmpNumbers = numbers.Where(n => (n % 2) == 1).ToList();
            
            Console.WriteLine("홀수");
            tmpNumbers.ForEach(Console.WriteLine);
        }
    }
}
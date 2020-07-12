using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam002
    {
        public void Run()
        {
            int[] numbers = {105, 100, 13, 5, 1};
            
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    int left = numbers[j];
                    int right = numbers[j + 1];
                    if (left > right)
                    {
                        numbers[j] = right;
                        numbers[j + 1] = left;
                    }
                }
            }
            
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            
            List<int> list = new List<int> {105, 100, 13, 5, 1};
            list.Sort();
            
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }

        }
    }
}
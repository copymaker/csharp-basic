﻿using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex007
    {
        public void Run()
        {
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("{0} 단 시작!", i);
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
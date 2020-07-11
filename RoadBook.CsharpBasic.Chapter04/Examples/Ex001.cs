using System;

namespace RoadBook.CsharpBasic.Chapter04.Examples
{
    public class Ex001
    {
        public void Run()
        {
            int dan = 2;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", dan, i, dan * i);
            }
        }
    }
}
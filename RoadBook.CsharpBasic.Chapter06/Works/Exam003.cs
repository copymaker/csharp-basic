using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam003
    {
        public void Run()
        {
            int count = 2;
            
            Console.WriteLine("무료 영화 선착순 예매 시스템입니다.");
            
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Dexter");
            queue.Enqueue("Jeffrey");
            queue.Enqueue("Khan");
            queue.Enqueue("Pil");
            queue.Enqueue("Sven");
            
            Console.WriteLine("무료 영화 관람권 당첨자는");
            while (count > 0)
            {
                Console.WriteLine(queue.Dequeue());
                count--;
            }
            Console.WriteLine("입니다.");
        }
    }
}
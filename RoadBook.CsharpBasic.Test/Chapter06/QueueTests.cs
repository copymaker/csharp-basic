using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace RoadBook.CsharpBasic.Test.Chapter06
{
    [TestFixture]
    public class QueueTests
    {
        [Test]
        public void QueueTest()
        {
            Queue<string> queue = new Queue<string>();

            for (int idx = 1; idx < 11; idx++)
            {
                queue.Enqueue($"{idx}번 승객");
            }
            
            Console.WriteLine("* 정류장 승객 현황");
            foreach (string passenger in queue)
            {
                Console.WriteLine(passenger);
            }
            Console.WriteLine("===============================");
            Console.WriteLine("버스가 도착했습니다. (6명 승차 가능)");

            for (int i = 0; i < 6; i++)
            {
                queue.Dequeue();
            }
            
            Console.WriteLine("버스가 출발했습니다.");
            Console.WriteLine("===============================");
            
            Console.WriteLine("새로운 승객이 줄을 섭니다.");
            queue.Enqueue("새로운 승객");
            
            Console.WriteLine("* 정류장 승객 현황");
            foreach (string passenger in queue)
            {
                Console.WriteLine(passenger);
            }
            Console.WriteLine("===============================");
        }
    }
}
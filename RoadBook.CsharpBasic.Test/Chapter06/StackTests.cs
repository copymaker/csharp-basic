using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace RoadBook.CsharpBasic.Test.Chapter06
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void StackTest()
        {
            Stack<string> stack = new Stack<string>();
            
            Console.WriteLine("* 시작점");
            for (int idx = 1; idx < 11; idx++)
            {
                Console.WriteLine($"{idx} 선수 도착");
                stack.Push($"{idx}번 선수");
            }
            
            Console.WriteLine("=====");
            Console.WriteLine("5~10등 선수는 탈락합니다.");
            for (int idx = 0; idx < 6; idx++)
            {
                stack.Pop();
            }
            Console.WriteLine("=====");
            
            Console.WriteLine("* 올림픽 대표선수 명단");
            foreach (var player in stack)
            {
                Console.WriteLine(player);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter06.Works
{
    public class Exam004
    {
        public void Run()
        {
            Dictionary<char, List<string>> dictionary = new Dictionary<char, List<string>>();
            dictionary.Add('A', new List<string> {"대한민국", "프랑스", "미국", "이집트"});
            dictionary.Add('H', new List<string> {"일본", "브라질", "독일", "스페인"});

            Console.WriteLine("A조에 속한 나라는");
            foreach (string nation in dictionary['A'])
            {
                Console.WriteLine(nation);
            }
            Console.WriteLine("입니다.");
            
            Console.WriteLine("H조에 속한 나라는");
            foreach (string nation in dictionary['H'])
            {
                Console.WriteLine(nation);
            }
            Console.WriteLine("입니다.");
        }
    }
}
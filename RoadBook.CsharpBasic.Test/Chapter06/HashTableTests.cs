using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace RoadBook.CsharpBasic.Test.Chapter06
{
    [TestFixture]
    public class HashTableTests
    {
        [Test]
        public void HashTableTest()
        {
            Hashtable hst = new Hashtable();
            hst.Add("korea", "한국");
            hst.Add("japan", "일본");
            hst.Add("brazil", "브라질");
            hst.Add("china", "중국");
            hst.Add("canada", "캐나다");
            hst.Add("america", "미국");
            hst.Add("spain", "스페인");
            
            Console.Write("단어를 입력하세요: ");
            string word = "korea";

            if (hst.Contains(word))
            {
                Console.WriteLine($"{word} : {hst[word]}");
            }
            else
            {
                Console.WriteLine("단어 검색결과가 없습니다.");
            }
        }

        [Test]
        public void DictionaryTest()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("korea", "한국");
            dict.Add("japan", "일본");
            dict.Add("brazil", "브라질");
            dict.Add("china", "중국");
            dict.Add("canada", "캐나다");
            dict.Add("america", "미국");
            dict.Add("spain", "스페인");

            foreach (KeyValuePair<string,string> pair in dict)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}
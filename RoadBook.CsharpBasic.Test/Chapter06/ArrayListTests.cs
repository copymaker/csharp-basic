using System;
using System.Collections;
using NUnit.Framework;

namespace RoadBook.CsharpBasic.Test.Chapter06
{
    [TestFixture]
    public class ArrayListTests
    {
        [Test]
        public void AddTest()
        {
            ArrayList aList = new ArrayList();

            for (int idx = 0; idx < 10; idx++)
            {
                aList.Add(idx);
            }
            
            for (int idx = 10; idx < 15; idx++)
            {
                aList.Add(idx.ToString());
            }
            
            for (int idx = 0; idx < aList.Count; idx++)
            {
                Console.WriteLine("Value: {0} / Type: {1}", aList[idx], aList[idx].GetType());
            }
        }

        [Test]
        public void InsertTest()
        {
            ArrayList aList = new ArrayList();

            aList.Add(1);
            aList.Add(3);
            aList.Add(4);
            
            aList.Insert(1, 2);

            foreach (var n in aList)
            {
                Console.WriteLine(n);
            }
        }
    }
}
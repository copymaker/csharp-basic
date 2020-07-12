using System;
using NUnit.Framework;

namespace RoadBook.CsharpBasic.Test.Chapter06
{
    [TestFixture]
    public class SplitTests
    {
        [Test]
        public void ShouldReturnArrayTypeWhenSplit()
        {
            string weather = "sunny,sunny,rainy,cloudy,rainy,snow,sunny";
            var weathers = weather.Split(',');
            
            Console.WriteLine(weather.GetType());
            Console.WriteLine(weathers.GetType());
            
            Assert.IsInstanceOf(typeof(string), weather);
            Assert.IsInstanceOf<string[]>(weathers);
        }
    }
}
using System;
using NUnit.Framework;
using RoadBook.CsharpBasic.Chapter05.Examples;

namespace RoadBook.CsharpBasic.Test.Chapter05
{
    [TestFixture]
    public class CarTests
    {
        [Test]
        public void RunTest()
        {
            Car car = new Car();
            car.Size = "세단";
            car.Color = "하얀";
            
            Console.WriteLine("고객님의 차, {0} {1}이...", car.Color, car.Size);
            
            car.Engine_on();
            car.Go();
            car.Back();
            car.Left();
            car.Right();
            car.Engine_off();
        }

        [Test]
        public void InheritanceTest()
        {
            GasolineCar gasolineCar = new GasolineCar();
            gasolineCar.Color = "검정";
            gasolineCar.Size = "SUV";
            
            ElectronicCar electronicCar = new ElectronicCar();
            electronicCar.Color = "초록";
            electronicCar.Size = "경차";
            
            Console.WriteLine("{0}색 {1}가", gasolineCar.Color, gasolineCar.Size);
            gasolineCar.Go();
            gasolineCar.InputGas();
            
            Console.WriteLine("{0}색 {1}가", electronicCar.Color, electronicCar.Size);
            electronicCar.Left();
            electronicCar.InputGas();
        }
    }
}
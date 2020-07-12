using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class ElectronicCar : Car
    {
        public override void InputGas()
        {
            Console.WriteLine("전기를 넣습니다.");
        }
    }
}
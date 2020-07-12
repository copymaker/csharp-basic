using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class GasolineCar : Car
    {
        public override void InputGas()
        {
            Console.WriteLine("휘발유를 넣습니다.");
        }
    }
}
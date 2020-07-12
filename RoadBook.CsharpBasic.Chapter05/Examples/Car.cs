using System;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    public class Car
    {
        public string Size { get; set; }
        public string Color { get; set; }
        
        public void Engine_on()
        {
            Console.WriteLine("시동을 켭니다.");
        }
        public void Engine_off()
        {
            Console.WriteLine("시동을 끕니다.");
        }
        
        public void Go()
        {
            Console.WriteLine("전진합니다.");
        }
        
        public void Back()
        {
            Console.WriteLine("후진합니다.");
        }
        
        public void Left()
        {
            Console.WriteLine("좌회전합니다.");
        }
        
        public void Right()
        {
            Console.WriteLine("우회전합니다.");
        }

        public virtual void InputGas()
        {
            Console.WriteLine("기름을 넣습니다.");
        }
    }
}
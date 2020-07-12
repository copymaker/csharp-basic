using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex011
    {
        private int _globalValue = 20;

        public void Run()
        {
            int localValue = 10;

            Sum();
            Multiple();
            
            Console.WriteLine("local: {0} / global: {1}", localValue, _globalValue);
        }
        
        private void Sum()
        {
            _globalValue += 10;
        }

        private void Multiple()
        {
            _globalValue *= 2;
        }
    }
}
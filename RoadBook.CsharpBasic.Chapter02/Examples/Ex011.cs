﻿using System;

namespace RoadBook.CsharpBasic.Chapter02.Examples
{
    public class Ex011
    {
        private int globalValue = 20;

        public void Run()
        {
            int localValue = 10;

            Sum();
            Multiple();
            
            Console.WriteLine("local: {0} / global: {1}", localValue, globalValue);
        }
        
        private void Sum()
        {
            globalValue += 10;
        }

        private void Multiple()
        {
            globalValue *= 2;
        }
    }
}
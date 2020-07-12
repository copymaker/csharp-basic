using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex002
    {
        private readonly string _currentDirectory = Environment.CurrentDirectory;
        
        public void Run()
        {
            using (StreamWriter sw = new StreamWriter(_currentDirectory + @"\data\log.txt", true))
            {
                sw.WriteLine($"프로그램 실행 시간: {DateTime.Now}");
            }
        }
    }
}
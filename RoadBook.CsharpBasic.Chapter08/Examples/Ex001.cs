using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex001
    {
        private readonly string _currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(_currentDirectory + @"\data");
            
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
                Console.WriteLine("디렉토리가 생성되었습니다.");
            }
            
            Console.WriteLine($"생성 경로 {directoryInfo.FullName}");
        }
    }
}
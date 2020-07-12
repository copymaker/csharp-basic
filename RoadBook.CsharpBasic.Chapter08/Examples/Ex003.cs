using System;
using System.IO;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex003
    {
        private readonly string _currentDirectory = Environment.CurrentDirectory;

        public void Run()
        {
            FileInfo fileInfo = new FileInfo(_currentDirectory + @"\data\log.txt");

            Console.WriteLine($"저장경로 : {fileInfo.DirectoryName}");
            Console.WriteLine($"파일명 : {fileInfo.Name}");

            Console.WriteLine("=== 파일 내용 ===");
            using (StreamReader sr = new StreamReader(fileInfo.FullName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
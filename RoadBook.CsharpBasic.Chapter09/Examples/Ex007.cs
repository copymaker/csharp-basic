using System;
using System.Collections.Generic;
using System.Linq;
using RoadBook.CsharpBasic.Chapter09.Model;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex007
    {
        public void Run()
        {
            List<Student> students = StudentRepository.Students();

            students
                .Where(s => s.Grade == 1 | s.Grade == 3)
                .ToList()
                .ForEach(Console.WriteLine);
            
        }
    }
}
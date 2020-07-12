using System;
using System.Collections.Generic;
using System.Linq;
using RoadBook.CsharpBasic.Chapter09.Model;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex008
    {
        public void Run()
        {
            List<Student> students = StudentRepository.Students();

            int greaterThanGrade3Count = students
                .Count(s => s.Grade >= 3);
            
            Console.WriteLine(greaterThanGrade3Count);

        }
    }
}
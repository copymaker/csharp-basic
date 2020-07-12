using System;
using System.Collections.Generic;
using RoadBook.CsharpBasic.Chapter09.Model;

namespace RoadBook.CsharpBasic.Chapter09.Examples
{
    public class Ex006
    {
        public void Run()
        {
            List<Student> students = StudentRepository.Students();

            foreach (Student student in students)
            {
                if (student.Grade == 1 || student.Grade == 3)
                {
                    Console.WriteLine(student);
                }
            }
            
        }
    }
}
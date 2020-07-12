using System;
using System.Collections.Generic;
using NUnit.Framework;
using RoadBook.CsharpBasic.Chapter06.Examples.Model;

namespace RoadBook.CsharpBasic.Test.Chapter06
{
    [TestFixture]
    public class GenericStudent
    {
        [Test]
        public void RunTest()
        {
            List<Student> students = new List<Student>();
            
            Student student = new Student();
            student.Id = "S001";
            student.Name = "홍길동";
            student.Department = "국어국문학과";
            student.Grade = 1;
            student.Age = 21;
            
            students.Add(student);

            foreach (var s in students)
            {
                Console.WriteLine(s.Id);
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Department);
                Console.WriteLine(s.Grade);
                Console.WriteLine(s.Age);
            }
        }
    }
}
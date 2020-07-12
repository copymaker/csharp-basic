using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using RoadBook.CsharpBasic.Chapter09.Model;


namespace RoadBook.CsharpBasic.Test.Chapter09
{
    [TestFixture]
    public class StudentLambda
    {
        private readonly List<Student> _students = StudentRepository.Students();
        
        [Test]
        public void SortByGradeTest()
        {
            _students
                .OrderBy(s => s.Grade)
                .ToList()
                .ForEach(Console.WriteLine);
        }

        [Test]
        public void StudentCountByMajorTest()
        {
            _students.GroupBy(s => s.Major, (key, group) => new {Major = key, Count = group.Count()})
                .ToList()
                .ForEach(Console.WriteLine);
        }

        [Test]
        public void GradeSumAndMaxAndMinAndAverageTest()
        {
            int gradeSum = _students.Sum(s => s.Grade);
            int gradeMax = _students.Select(s => s.Grade).Max();
            int gradeMin = _students.Min(s => s.Grade);
            double gradeAverage = _students.Average(s => s.Grade);
            
            Console.WriteLine($"학년의 합: {gradeSum}");
            Console.WriteLine($"최고 학년: {gradeMax}");
            Console.WriteLine($"최저 학년: {gradeMin}");
            Console.WriteLine($"평균 학년: {gradeAverage}");
        }

        [Test]
        public void FindByGrade1And3Test()
        {
            var resultList = 
                from s in _students
                where s.Grade == 1 || s.Grade == 3
                select s;

            resultList.ToList().ForEach(Console.WriteLine);
        }
    }
}
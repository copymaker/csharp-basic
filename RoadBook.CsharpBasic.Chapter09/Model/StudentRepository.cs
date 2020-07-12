using System.Collections.Generic;

namespace RoadBook.CsharpBasic.Chapter09.Model
{
    public class StudentRepository
    {
        public static List<Student> Students()
        {
            return new List<Student>
            {
                new Student("S001", "Dexter", 3, "Software"),
                new Student("S002", "Jeffrey", 4, "Software"),
                new Student("S003", "Pil", 4, "Software"),
                new Student("S004", "Khan", 2, "Software"),
                new Student("S005", "Sven", 2, "Software"),
                new Student("D001", "Ellen", 3, "Design"),
                new Student("D002", "Sienna", 4, "Design"),
                new Student("S006", "Clint", 3, "Software"),
                new Student("A001", "Mike", 2, "Advertisement"),
                new Student("T001", "Peter", 1, "Theater")
            };
        }
    }
}
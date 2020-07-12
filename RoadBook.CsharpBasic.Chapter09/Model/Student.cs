namespace RoadBook.CsharpBasic.Chapter09.Model
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Major { get; set; }

        public Student()
        {
        }

        public Student(string id, string name, int grade, string major)
        {
            Id = id;
            Name = name;
            Grade = grade;
            Major = major;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Grade)}: {Grade}, {nameof(Major)}: {Major}";
        }
    }
}
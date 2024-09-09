namespace ConsoleApp2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}

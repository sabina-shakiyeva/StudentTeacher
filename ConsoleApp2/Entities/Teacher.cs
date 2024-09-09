namespace ConsoleApp2
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<StudentTeacher> StudentTeachers { get; set; }
    }
}

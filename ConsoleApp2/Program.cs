using ConsoleApp2.Context;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            SchoolContext context = new SchoolContext();

            //ADD TEACHER
            Teacher newTeacher = new Teacher
            {
                Name = "Sabina Shakiyeva"
            };

            await context.Teachers.AddAsync(newTeacher);
            await context.SaveChangesAsync();
            //UPDATE TEACHER

            var teacher = await context.Teachers.FirstOrDefaultAsync(t => t.Id == 1);
            if (teacher != null)
            {
                teacher.Name = "Nargiz aliyeva";
                await context.SaveChangesAsync();
            }

            //DELETE TEACHER
            var teacher2 = await context.Teachers.FirstOrDefaultAsync(t => t.Id == 2);
            if (teacher2 != null) { 
                context.Teachers.Remove(teacher2);
                await context.SaveChangesAsync();
            
            }

            //ADD STUDENT
            Student newStudent = new Student
            {
                Name = "Leyla Guliyeva"
            };

            await context.Students.AddAsync(newStudent);
            await context.SaveChangesAsync();
            //UPDATE STUDENT

            var student = await context.Students.FirstOrDefaultAsync(s => s.Id == 1);
            if (student != null)
            {
                student.Name = "Nigar aliyeva";
                await context.SaveChangesAsync();
            }

            //DELETE STUDENT
            var student2 = await context.Students.FirstOrDefaultAsync(s => s.Id == 2);
            if (student2 != null)
            {
                context.Students.Remove(student2);
                await context.SaveChangesAsync();

            }

            StudentTeacher studentTeacher = new StudentTeacher
            {
                StudentId = newStudent.Id,
                TeacherId = newTeacher.Id,
            };
            await context.StudentTeachers.AddAsync(studentTeacher);
            await context.SaveChangesAsync();




        }
    }
}

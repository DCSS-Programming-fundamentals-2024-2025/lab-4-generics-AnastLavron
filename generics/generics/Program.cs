using generics.Interfaces;
using generics.Models;
using generics.Repositories;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        Faculty fpm = new Faculty { Id = 1, Name = "ФПМ" };

        Group kp41 = new Group { Id = 41, Name = "КП-41" };
        Group kp42 = new Group { Id = 42, Name = "КП-42" };
        Group kp43 = new Group { Id = 43, Name = "КП-43" };

        fpm.AddGroup(kp41);
        fpm.AddGroup(kp42);
        fpm.AddGroup(kp43);

        Student s1 = new Student { Id = 1, Name = "Лавріненко Анастасія" };
        Student s2 = new Student { Id = 2, Name = "Ковальчук Вадим" };
        Student s3 = new Student { Id = 3, Name = "ференцюк Назар" };
        Student s4 = new Student { Id = 4, Name = "Клименко Кирило" };
        Student s5 = new Student { Id = 5, Name = "Парфенюк Вікторія" };

        fpm.AddStudentToGroup(41, s1);
        fpm.AddStudentToGroup(41, s2);
        fpm.AddStudentToGroup(42, s3);
        fpm.AddStudentToGroup(43, s4);
        fpm.AddStudentToGroup(42, s5);

        Console.WriteLine("Студенти у групі КП-41:");
        foreach (var student in fpm.GetAllStudentsInGroup(41))
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}
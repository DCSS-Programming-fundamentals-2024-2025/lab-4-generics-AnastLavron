class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Faculty fpm = new Faculty { Id = 1, Name = "ФПМ" };

        Group KP41 = new Group { Id = 41, Name = "KП-41" };
        Group KP42 = new Group { Id = 42, Name = "KП-42" };
        Group KP43 = new Group { Id = 43, Name = "KП-43" };

        fpm.AddGroup(KP41);
        fpm.AddGroup(KP42);
        fpm.AddGroup(KP43);

        Student student1 = new Student { Id = 1, Name = "Лавріненко" };
        Student student2 = new Student { Id = 2, Name = "Зайцев" };
        Student student3 = new Student { Id = 3, Name = "Шевченко" };
        Student student4 = new Student { Id = 4, Name = "Коваль" };
        Student student5 = new Student { Id = 45, Name = "Кот" };

        fpm.AddStudentToGroup(KP41.Id, student1);
        fpm.AddStudentToGroup(KP43.Id, student2);
        fpm.AddStudentToGroup(KP42.Id, student3);
        fpm.AddStudentToGroup(KP43.Id, student4);
        fpm.AddStudentToGroup(KP42.Id, student5);

        Console.WriteLine($"Студенти в групі {KP41.Name}:");
        foreach (var student in fpm.GetAllStudentsInGroup(KP41.Id))
        {
            student.SayName();
        }

        Console.WriteLine($"Студенти в групі {KP42.Name}:");
        foreach (var student in fpm.GetAllStudentsInGroup(KP42.Id))
        {
            student.SayName();
        }

        Console.WriteLine($"Студенти в групі {KP43.Name}:");
        foreach (var student in fpm.GetAllStudentsInGroup(KP43.Id))
        {
            student.SayName();
        }
        IReadOnlyRepository<Student, int> studRepo = new InMemoryRepository<Student, int>();
        IReadOnlyRepository<Person,int>  persRepo = studRepo;

        var tt =  new InMemoryRepository<Person, int>();
        
        IWriteRepository<Person,int> persWrite = tt;
        IWriteRepository<Student,int> studWrite = persWrite;
    }
}
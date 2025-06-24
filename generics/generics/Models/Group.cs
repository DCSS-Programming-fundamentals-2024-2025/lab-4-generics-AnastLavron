using System.Data.Common;
using System.Runtime.InteropServices;
using generics.Interfaces;
class Group
{

    public int Id;
    public string Name;

    private IRepository<Student, int> _students = new InMemoryRepository<Student, int>();
    public void AddStudent(Student s)
    {
        _students.Add(s.Id, s);
    }
    public void RemoveStudent(int studentId)
    {
        _students.Remove(studentId);
    }
    public IEnumerable<Student> GetAllStudents()
    {
        return _students.GetAll();
    }
    public Student FindStudent(int studentId)
    {
        return _students.Get(studentId);
    }
    public void PrintStudents()
    {
        foreach (Student s in _students.GetAll())
        {
            Console.WriteLine($"Student id: {s.Id}, name: {s.Name}");
        }
    }
}
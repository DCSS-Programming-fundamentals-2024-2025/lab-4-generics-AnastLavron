class Student : Person
{
    // private bool _disposed = false;
    public void SayName()
    {
        Console.WriteLine(Name);
    }

    public void SubmitWork()
    {
        Console.WriteLine($"{Name} submitted the work");
    }
}
public class Student : Person
{
    public string Study()
    {
        return $"The student is studying";
    }
    public Student(string name) : base(name)
    {
    }
    public Student() { }
}
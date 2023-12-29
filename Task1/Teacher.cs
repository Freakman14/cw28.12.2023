public class Teacher : Person
{

    public string Explain()
    {
        return "The teacher is explaining";
    }
    public Teacher(string name) : base(name)
    {
    }
    public Teacher() { }
}
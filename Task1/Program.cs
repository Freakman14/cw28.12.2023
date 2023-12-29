List<string> cip = new List<string>() { };
var per = new Person();
Console.Write("Enter your name: ");
per.Name = Console.ReadLine();
cip.Add(per.Name);

var st1 = new Student();
Console.Write("Enter your name: ");
st1.Name = Console.ReadLine();
cip.Add(st1.Name);

var t1 = new Teacher();
Console.Write("Enter your name: ");
t1.Name = Console.ReadLine();
cip.Add(t1.Name);

System.Console.WriteLine(t1.Explain());
System.Console.WriteLine(st1.Study());


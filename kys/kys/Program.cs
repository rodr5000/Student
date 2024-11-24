using kys;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Student s1 = new Student(123456789,"asdfgh","A3",'e');
        s1.setgrade(50);
        
        string write = s1.ToString();
        Console.WriteLine(write);

        Student s2 = new Student(134679852, "zxcqwe", "A3", 't');
        s2.setgrade(30);

        string write2 = s2.ToString();
        Console.WriteLine(write2);

        if (s1.bestGrade(s2)) {
            Console.WriteLine(s1.name + " has the biggest grade ");
        } else {
            Console.WriteLine(s2.name + " has the biggest grade ");
        }
    }
    
} 

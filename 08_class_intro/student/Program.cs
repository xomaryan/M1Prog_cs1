namespace student;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Student student = new Student();
        student.naam = "Bart Simpson";
        student.leeftijd = 14;
        student.studentnummer = 123456;

        student.name = "Lise Simpson";
        student.lifetime = 13;
        student.studentnumber = 67890;

        Console.WriteLine(student);

        Console.WriteLine("Student: " + student.naam);
        Console.WriteLine("Leeftijd: " + student.leeftijd);
        Console.WriteLine("Studentnummer: " + student.studentnummer);

        Console.WriteLine("Student: " + student.name);
        Console.WriteLine("Leeftijd: " + student.lifetime);
        Console.WriteLine("Studentnummer: " + student.studentnumber);
    }
}

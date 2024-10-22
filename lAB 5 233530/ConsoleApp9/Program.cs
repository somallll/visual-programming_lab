// See https://aka.ms/new-console-template for more information
using System;

public enum Department
{
    Science,
    Arts,
    Commerce,
    Engineering
}

public class Person
{
    // Instance variable
    private string name;

    // No-argument constructor
    public Person()
    {
        name = null; // Default value
    }

    // Multi-argument constructor
    public Person(string name)
    {
        this.name = name;
    }

    // Public property for name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Student : Person
{
    // Instance variables
    private string regNo;
    private int age;
    private Department program;

    // No-argument constructor
    public Student() : base() // Call to the base class constructor
    {
        regNo = null; // Default value
        age = 0; // Default value
        program = Department.Science; // Default value
    }

    // Multi-argument constructor
    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

    // Public property for regNo
    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    // Public property for age
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    // Public property for program
    public Department Program
    {
        get { return program; }
        set { program = value; }
    }
}

class Program
{
    static void Main()
    {
        // Creating a Student object using no-argument constructor
        Student student1 = new Student();
        Console.WriteLine("Student 1:");
        Console.WriteLine($"Name: {student1.Name}, RegNo: {student1.RegNo}, Age: {student1.Age}, Program: {student1.Program}");

        // Creating a Student object using multi-argument constructor
        Student student2 = new Student("Alice", "S123", 20, Department.Engineering);
        Console.WriteLine("\nStudent 2:");
        Console.WriteLine($"Name: {student2.Name}, RegNo: {student2.RegNo}, Age: {student2.Age}, Program: {student2.Program}");
    }
}


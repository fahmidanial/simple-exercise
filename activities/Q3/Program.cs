using System;

class Student
{
    private string studentID;
    private string name;
    private int intakeYear;
    private int english;
    private int math;
    private int chemistry;
    private int biology;
    private int history;

    // Default constructor
    public Student()
    {
        // Initialize default values
        studentID = "";
        name = "";
        intakeYear = 0;
        english = 0;
        math = 0;
        chemistry = 0;
        biology = 0;
        history = 0;
    }

    // Overloaded constructor
    public Student(string studentID, string name, int intakeYear)
    {
        this.studentID = studentID;
        this.name = name;
        this.intakeYear = intakeYear;
        // Initialize marks to 0 by default
        english = 0;
        math = 0;
        chemistry = 0;
        biology = 0;
        history = 0;
    }

    // Accessor methods
    public string GetStudentID()
    {
        return studentID;
    }

    public string GetName()
    {
        return name;
    }

    public int GetIntakeYear()
    {
        return intakeYear;
    }

    public int GetEnglish()
    {
        return english;
    }

    public int GetMath()
    {
        return math;
    }

    public int GetChemistry()
    {
        return chemistry;
    }

    public int GetBiology()
    {
        return biology;
    }

    public int GetHistory()
    {
        return history;
    }

    // Mutator methods
    public void SetStudentID(string studentID)
    {
        this.studentID = studentID;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetIntakeYear(int intakeYear)
    {
        this.intakeYear = intakeYear;
    }

    public void SetEnglish(int english)
    {
        this.english = english;
    }

    public void SetMath(int math)
    {
        this.math = math;
    }

    public void SetChemistry(int chemistry)
    {
        this.chemistry = chemistry;
    }

    public void SetBiology(int biology)
    {
        this.biology = biology;
    }

    public void SetHistory(int history)
    {
        this.history = history;
    }

    // Method to enter marks for subjects
    public void EnterMarks()
    {
        Console.Write("Enter English marks: ");
        english = int.Parse(Console.ReadLine());

        Console.Write("Enter Math marks: ");
        math = int.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter Biology marks: ");
        biology = int.Parse(Console.ReadLine());

        Console.Write("Enter History marks: ");
        history = int.Parse(Console.ReadLine());
    }

    // Method to display individual grades for subjects
    public void DisplayGrades()
    {
        Console.WriteLine("English Grade: " + GetGrade(english));
        Console.WriteLine("Math Grade: " + GetGrade(math));
        Console.WriteLine("Chemistry Grade: " + GetGrade(chemistry));
        Console.WriteLine("Biology Grade: " + GetGrade(biology));
        Console.WriteLine("History Grade: " + GetGrade(history));
    }

    // Method to calculate the average of marks
    public double CalculateAverage()
    {
        int totalMarks = english + math + chemistry + biology + history;
        return (double)totalMarks / 5;
    }

    // Helper method to determine the grade based on marks
    private string GetGrade(int marks)
    {
        if (marks >= 80 && marks <= 100)
            return "A";
        else if (marks >= 60 && marks < 80)
            return "B";
        else if (marks >= 50 && marks < 60)
            return "C";
        else
            return "D";
    }
}

class Program
{
    static void Main()
    {
        // Create a Student object using the default constructor
        Student student1 = new Student();

        // Set student information using mutator methods
        student1.SetStudentID("S001");
        student1.SetName("John Doe");
        student1.SetIntakeYear(2023);

        // Enter marks for subjects
        Console.WriteLine("Enter marks for Student 1:");
        student1.EnterMarks();

        // Display individual grades
        Console.WriteLine("\nIndividual Grades for Student 1:");
        student1.DisplayGrades();

        // Calculate and display the average
        Console.WriteLine("\nAverage Marks for Student 1: " + student1.CalculateAverage());

        // Create another Student object using the overloaded constructor
        Student student2 = new Student("S002", "Jane Smith", 2022);

        // Enter marks for subjects
        Console.WriteLine("\nEnter marks for Student 2:");
        student2.EnterMarks();

        // Display individual grades
        Console.WriteLine("\nIndividual Grades for Student 2:");
        student2.DisplayGrades();

        // Calculate and display the average
        Console.WriteLine("\nAverage Marks for Student 2: " + student2.CalculateAverage());
    }
}

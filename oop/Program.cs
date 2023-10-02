using System;

class Program
{
        static void Main(string[] args)
        {

            Student stud1 = new Student();
            stud1.name = "David Lee";
            stud1.id = "A1234";
            stud1.age = 20;

            Console.WriteLine($"Student Name: {stud1.name}, ID: {stud1.id} , Age: {stud1.age}");
        }

    public class Student

    {
        //data
        public string name;
        public string id;
        public int age;


        //method/funtions
        public void Display()
        {
            Console.WriteLine($"Student Name: {name}, ID: {id} , Age: {age}");
        }
    }

}
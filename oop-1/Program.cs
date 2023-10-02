//get and set!

using System;

class Program
{
    static void Main(string[] args)
    {

        Student stud1 = new Student();
        //stud1.name = "David Lee";
        //stud1.id = "A1234";
        //stud1.age = 20;
        //Console.WriteLine($"Student Name: {stud1.name}, ID: {stud1.id} , Age: {stud1.age}");
        stud1.setName("David Lee");
        stud1.setID("A1234");
        stud1.setAge(20);
        Console.WriteLine($"Student Name: {stud1.getName()}, ID: {stud1.getID()} , Age: {stud1.getAge()}");




    }

    public class Student
    {
        //data
        //public string name;
        //public string id;
        //public int age; 
        private string name;
        private string id;
        private int age;



        //method/funtions
        public void Display()
        {
            Console.WriteLine($"Student Name: {name}, ID: {id} , Age: {age}");
        }

        public void setName(string na)
        {
            name = na;
        }
        public void setID(string idee)
        {
            id = idee;
        }
        public void setAge(int ag)
        {
            age = ag;
        }
        public string getName()
        {
            return name;
        }
        public string getID()
        {
            return id;
        }
        public int getAge()
        {
            return age;
        }


    }
}

    
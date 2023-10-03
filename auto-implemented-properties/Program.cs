using System;

class Program
{
    static void Main(string[] args)
    {

        Student stud1 = new Student();
        stud1.Display();
        //stud1.name = "David Lee";
        //stud1.id = "A1234";
        //stud1.age = 20;
        //Console.WriteLine($"Student Name: {stud1.name}, ID: {stud1.id} , Age: {stud1.age}");
        stud1.Name = "David Lee";  // vs stud1.setName ("David Lee"); 
        stud1.setID("A1234");
        stud1.setAge(20);
        Console.WriteLine($"Student Name: {stud1.Name}, ID: {stud1.getID()} , Age: {stud1.getAge()}");
        stud1.Display();

        Student stud2 = new Student("Jenny Lim", "B1115", 22);

        int stud2Age = stud2.Age;

        stud2.Display();
    }


    public class Student
    {
        //data
        //public string name;
        //public string id;
        //public int age; 
        private string name;
        private string id;
        //private int age;

        public Student() //Builder of the object-start point of creation of object - to set initial values
        {
            name = "Empty";
            id = "000000";
            Age = -1111;
        }

        public Student(string na, string id, int age)
        {
            name = na;
            this.id = id;
            Age = age;
        }

        //public named property to reduce the needs of getter and setter methods
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }

        //Auto Implemented properties for get and set
        public int Age
        {
            get;
            set;
        }

        //method/funtions
        public void Display()
        {
            Console.WriteLine($"Student Name: {name}, ID: {id} , Age: {Age}");
        }

        //public void setName (string na)
        //{
        //    name = na;
        //}
        public void setID(string idee)
        {
            id = idee;
        }
        public void setAge(int ag)
        {
            Age = ag;
        }
        //public string getName()
        //{
        //    return name;
        //}
        public string getID()
        {
            return id;
        }
        public int getAge()
        {
            return Age;
        }


    }


}








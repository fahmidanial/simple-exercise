using System;

class Program
{
    static void Main(string[] args)
    {

        Parttime pt = new Parttime();
        pt.Name = "David Lee";
        pt.Age = 24;
        pt.Id = "B1234";
        pt.Room = "LotB124";
        pt.toDisplay();


        Console.Read();
    }

    class Student
    {
        protected string name, id;
        protected int age;
        public Student()
        {
            name = "None";
            id = "None";
            age = 0;
        }
        public Student(string na, string i, int ag)
        {
            name = na;
            id = i;
            age = 0;

        }
        public string Name
        {
            get;
            set;
        }
        public string Id
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }

    }
    class Parttime : Student
    {
        private string room;
        public string Room
        {
            get;
            set;
        }
        public void toDisplay()
        {
            Console.WriteLine("Name: {0} , Age: {1}, Id: {2}, Room: {3}"
                                , name, age, id, room);
        }
    }

}








using System;

class Program
{
    static void Main(string[] args)
    {


        Man henry = new Man();

        Malay enri = new Malay();

        henry.speak();
        henry.speak("It's a beautiful evening");

        enri.speak("Selamat Pagi");

        ((Man)enri).speak("Selamat Datang ke Malaysia");
        Console.Read();
    }
    public class Man
    {
        public void speak()
        {
            Console.Write("Hello: ");
        }

        public void speak(string message)
        {
            Console.WriteLine(message + "! Wow !\n");
        }
    }

    public class Malay : Man
    {
        public new void speak(string message)
        {
            base.speak();
            Console.WriteLine(message);
        }
    }
}
﻿using System;

class Program
{
    static void Main(string[] args)
    {


        Pigeon joey = new Pigeon();
        Chicken lola = new Chicken();

        describe(joey);
        describe(lola);
        Console.ReadKey();
        Console.Read();
    }
    static void describe(Bird obj)
    {
        obj.talk();
        obj.fly();
    }
    public class Bird
    {
        public virtual void talk()
        { Console.WriteLine("A Bird Talks..."); }

        public virtual void fly()
        { Console.WriteLine("A Bird Flies...\n"); }
    }

    public class Pigeon : Bird
    {
        public override void talk()
        { Console.WriteLine("Pigeon Says: Coo! Coo!"); }

        public override void fly()
        {
            Console.WriteLine("A Pigeon Flies Away...");
            base.fly();
        }
    }

    public class Chicken : Bird
    {
        public override void talk()
        { Console.WriteLine("Chicken Says: Cluck! Cluck!"); }

        public override void fly()
        {
            Console.WriteLine("I'm A Chicken - I Can't Fly!");
            base.fly();
        }
    }
}
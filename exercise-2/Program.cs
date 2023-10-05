using System;

class Program
{
    //Implement a Method (AddPerson) which contains the default/optional parameter for Name = "Empty", Age = -111, Gender = "Empty"
    //In the AddPerson display the result of details 
    //Call the method in the Main without any parameters
    // Call the method with named parameter starting from age:20 , name:"David" , gender:"male"
    static void Main(string[] args)
    {
        // Call the AddPerson method without any parameters
        AddPerson();

        // Call the AddPerson method with named parameters
        AddPerson(age: 20, name: "David", gender: "male");
    }

    static void AddPerson(string name = "Empty", int age = -111, string gender = "Empty")
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Gender: {gender}");
    }


}











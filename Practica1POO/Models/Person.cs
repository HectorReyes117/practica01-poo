using System.Reflection.Metadata.Ecma335;

namespace Practica1POO.Models;

public class Person
{
    protected string Name { get; set; }
    protected int Age { get; set; }
    protected string City { get; set; }
    public Person(string name, int age, string city)
    {
        this.Name = name;
        this.Age = age;
        this.City = city;
    }

    public void ViewName()
    {
        Console.WriteLine(Name);
    }
    
    public void ViewAge()
    {
        Console.WriteLine(Age);
    }
    
    public void ViewCity()
    {
        Console.WriteLine(City);
    }

    public void CalculateAgeInYears()
    {
        Console.WriteLine($"{Age} years.");
    }
}
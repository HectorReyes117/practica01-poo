namespace Practica1POO.Models;

public class Student : Person
{
    private string Career { get; set; }
    private string Enrolment  { get; set; }
    
    public Student(string name, int age, string city, string career, string enrolment) : base(name, age, city)
    {
        Career = career;
        Enrolment = enrolment;
    }
    
    public void ViewAllInformation()
    {
        Console.WriteLine(
            $"My name is {Name}, i live in {City} city and my age is {Age}. I study {Career} and my enrolment is {Enrolment}"
        );
    }
}
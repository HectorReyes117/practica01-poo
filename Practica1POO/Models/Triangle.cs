namespace Practica1POO.Models;

public class Triangle : Figure
{
    public double Base { get; set; }
    public double Height { get; set; }


    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }
}
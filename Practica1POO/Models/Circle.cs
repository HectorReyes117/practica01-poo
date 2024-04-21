namespace Practica1POO.Models;

public class Circle : Figure
{
    public double Radius { get; set; }
    
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
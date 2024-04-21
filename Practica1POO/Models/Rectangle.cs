namespace Practica1POO.Models;

public class Rectangle : Figure
{
    public double Broad { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return (Broad * Height);
    }
}
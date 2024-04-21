using Practica1POO.Utils;

namespace Practica1POO.Models;

public class Circle : Figure
{
    public double Radius { get; set; }
    
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Process()
    {
        bool radiusIsNumber = false;
        
        while (!radiusIsNumber)
        {
            Console.Clear();
            Console.WriteLine("Introduzca la radio: ");
            (radiusIsNumber, Radius) = ParseInt.ParseStringToInt(Console.ReadLine());
        }

        Console.Clear();
        Console.WriteLine($"El resultado es {CalculateArea()} {Environment.NewLine}");
        Console.WriteLine("Presione una tecla para volver al menu.");
        Console.ReadKey();
    }
}
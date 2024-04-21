using Practica1POO.Utils;

namespace Practica1POO.Models;

public class Triangle : Figure
{
    public double Base { get; set; }
    public double Height { get; set; }
    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }

    public override void Process()
    {
        bool baseIsNumber = false;
        
        while (!baseIsNumber)
        {
            Console.Clear();
            Console.WriteLine("Introduzca la base: ");
            (baseIsNumber, Base) = ParseInt.ParseStringToInt(Console.ReadLine());
        }
        
        bool heightIsNumber = false;
        
        while (!heightIsNumber)
        {
            Console.Clear();
            Console.WriteLine("Introduzca la altura: ");
            (heightIsNumber, Height) = ParseInt.ParseStringToInt(Console.ReadLine());
        }

        Console.Clear();
        Console.WriteLine($"El resultado es {CalculateArea()} {Environment.NewLine}");
        Console.WriteLine("Presione una tecla para volver al menu.");
        Console.ReadKey();
    }
}
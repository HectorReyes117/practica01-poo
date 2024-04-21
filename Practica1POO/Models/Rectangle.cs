using Practica1POO.Utils;

namespace Practica1POO.Models;

public class Rectangle : Figure
{
    public double Broad { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return (Broad * Height);
    }

    public override void Process()
    {
        bool broadIsNumber = false;
        
        while (!broadIsNumber)
        {
            Console.Clear();
            Console.WriteLine("Introduzca el ancho: "); ;
            (broadIsNumber, Broad) = ParseInt.ParseStringToInt(Console.ReadLine());
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
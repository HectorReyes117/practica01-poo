// See https://aka.ms/new-console-template for more information

using Practica1POO.Models;
using Practica1POO.Utils;

string menu = @$"
    Menu {Environment.NewLine} 
    Introduzca el número de la figura de la cual desea calcular el área {Environment.NewLine}
    1) Rectángulo
    2) Triángulo
    3) Círculo {Environment.NewLine}{Environment.NewLine} Opcion: ";

bool isNumber = false;
int number = 0;

while (true)
{
    while (!isNumber || number <= 0 || number > 3)
    {
        Console.Clear();
        Console.WriteLine(menu);
        (isNumber, number) = ParseInt.ParseStringToInt(Console.ReadLine());
    }

    Figure figure;
    Console.Clear();
    
    switch (number)
    {
        case 1:
            figure = new Rectangle();
            figure.Process();
            break;
        case 2:
            figure = new Triangle();
            figure.Process();
            break;
        case 3:
            figure = new Circle();
            figure.Process();
            break;
    }
    
    number = 0;
}








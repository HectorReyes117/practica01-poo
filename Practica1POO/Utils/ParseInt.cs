namespace Practica1POO.Utils;

public static class ParseInt
{
    public static (bool, int) ParseStringToInt(string? value)
    {
        bool isNumer = int.TryParse(value, out int number);
        return (isNumer, number);
    }
}
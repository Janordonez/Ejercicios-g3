using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un año:");
        int año = int.Parse(Console.ReadLine());

        if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
        {
            Console.WriteLine($"{año} es un año bisiesto.");
        }
        else
        {
            Console.WriteLine($"{año} no es un año bisiesto.");
        }
    }
}

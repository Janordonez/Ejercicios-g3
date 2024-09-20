using System;
class Program
{
    static void Main()
    {
        int edad;
        Console.WriteLine("Programa que clasifica la edad del usuario");
        Console.Write("Bienvenido, Ingrese su edad: ");
        while(!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
        {
            Console.WriteLine("Numero Invalido!");
        }
            if (edad < 13)
            {
                Console.WriteLine("Usted es menor de edad");
            }
            else if (edad >= 13 && edad <= 19)
            {
                Console.WriteLine("Usted es Adolescente");
            }
            else if (edad >= 20 && edad <= 64)
            {
                Console.WriteLine("Usted es Adulto");
            }
            else if (edad >= 65)
            {
                Console.WriteLine("Usted es Anciano");
            }
            else
            {
                Console.WriteLine("Edad no válida");
            }
        
    }
}
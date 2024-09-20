using System;
using System.Numerics;  // Necesario para usar BigInteger

class Program
{
    static void Main()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("El factorial no está definido para números negativos.");
        }
        else
        {
            BigInteger factorial = 1;
            int i = 1;

            while (i <= numero)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
        }
    }
}

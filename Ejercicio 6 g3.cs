using System;

class Program
{
    static void Main()
    {
        string continuar;

        do
        {
            int suma = 0;
            int numero;

            // Solicitar al usuario que ingrese un número
            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Iterar sobre los números del 1 hasta el número ingresado
            for (int i = 1; i <= numero; ++i)
            {
                // Verificar si el número es par
                if (i % 2 == 0)
                {
                    suma += i; // Sumar el número par a la suma total
                }
            }

            // Mostrar el resultado
            Console.WriteLine("La suma de los números pares es: " + suma);

            // Preguntar si el usuario desea continuar
            Console.Write("¿Desea repetir el programa? (s/n): ");
            continuar = Console.ReadLine().ToLower();

        } while (continuar == "s");
    }
}
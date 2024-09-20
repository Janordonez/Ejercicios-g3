using System;

class EvaluacionCal
{
    static void Main()
    {
        int calificacion;

        do
        {
            Console.WriteLine("Introduzca la calificación del 0 al 100: ");
            calificacion = int.Parse(Console.ReadLine());

            if (calificacion < 0 || calificacion > 100)
            {
                Console.WriteLine("Favor ingrese una calificación válida entre 0 y 100.");
            }

        } while (calificacion < 0 || calificacion > 100);

        char letra;

        if (calificacion >= 90)
        {
            letra = 'A';
        }
        else if (calificacion >= 80)
        {
            letra = 'B';
        }
        else if (calificacion >= 70)
        {
            letra = 'C';
        }
        else if (calificacion >= 60)
        {
            letra = 'D';
        }
        else
        {
            letra = 'F';
        }

        Console.WriteLine($"La letra de la calificación es: {letra}");
    }
}

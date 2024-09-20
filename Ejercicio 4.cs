using System;

class Program
{
    static void Main()
    {
        float precio;
        float descuento1 = 0.10f; // Descuento para clientes regulares
        float descuento2 = 0.20f; // Descuento para clientes VIP
        float descuento;
        int opc;

        Console.WriteLine("Bienvenido");

        do
        {
            Console.WriteLine("¿Usted es cliente VIP?");
            Console.WriteLine("1. Sí");
            Console.WriteLine("2. No");
            Console.Write("Seleccione una opción: ");

            // Intentar leer la opción del usuario
            if (!int.TryParse(Console.ReadLine(), out opc))
            {
                Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
                continue; // Volver a mostrar el menú si la entrada no es válida
            }

            switch (opc)
            {
                case 1:
                    Console.Write("Gracias por ser VIP. Ingrese el precio del producto: ");
                    if (!float.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.WriteLine("Entrada de precio no válida. Inténtelo de nuevo.");
                        continue; // Volver a mostrar el menú si la entrada de precio no es válida
                    }
                    descuento = precio * descuento2;
                    Console.WriteLine("El precio total a pagar con descuento VIP es de: " + (precio - descuento) + " Córdobas");
                    break;

                case 2:
                    Console.Write("Usted es un miembro regular. Ingrese el precio del producto: ");
                    if (!float.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.WriteLine("Entrada de precio no válida. Inténtelo de nuevo.");
                        continue; // Volver a mostrar el menú si la entrada de precio no es válida
                    }
                    descuento = precio * descuento1;
                    Console.WriteLine("El precio total a pagar con descuento regular es de: " + (precio - descuento) + " Córdobas");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        } while (opc != 1 && opc != 2); // Repetir hasta que el usuario ingrese una opción válida
    }
}


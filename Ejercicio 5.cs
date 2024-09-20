using System;

namespace tarifa
{
    class LasTarifas
    {
        int edad;
        float tarifa;
        int CostoTarifa = 20; // Asignar un valor inicial a CostoTarifa
        float CalcularDescTarifa;
        float CalcularTarifa;

        static void Main(string[] args)
        {
            LasTarifas lasTarifas = new LasTarifas();

            Console.WriteLine("Digite su edad:");
            while (!int.TryParse(Console.ReadLine(), out lasTarifas.edad) || lasTarifas.edad <= 0 )
            {
                Console.WriteLine("Numero invalido! Intente de nuevo:");
            }

            // Condiciones para calcular la tarifa según la edad
            if (lasTarifas.edad < 5)
            {
                lasTarifas.tarifa = 0; // Tarifa gratis
                Console.WriteLine("Su tarifa es gratis.");
            }
            else if (lasTarifas.edad >= 5 && lasTarifas.edad <= 12)
            {
                lasTarifas.tarifa = lasTarifas.CostoTarifa / 2;
                Console.WriteLine($"Su tarifa es de: {lasTarifas.tarifa}");
            }
            else if (lasTarifas.edad >= 13 && lasTarifas.edad <= 64)
            {
                lasTarifas.tarifa = lasTarifas.CostoTarifa;
                Console.WriteLine($"Su tarifa es completa: {lasTarifas.tarifa}");
            }
            else if (lasTarifas.edad >= 65)
            {
                lasTarifas.tarifa = lasTarifas.CostoTarifa * 0.3f;
                lasTarifas.CalcularDescTarifa = lasTarifas.CostoTarifa - lasTarifas.tarifa;
                Console.WriteLine($"Su tarifa con descuento es: {lasTarifas.CalcularDescTarifa}");
            }
        }
    }
}

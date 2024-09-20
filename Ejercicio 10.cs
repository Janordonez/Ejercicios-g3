using System;
namespace MayorOMenor
{
    class MayorOmenor
    {
        public int numero;
        public int menor;
        public int mayor;
        public bool primernumero = true;

        static void Main(string[] args)
        {
            MayorOmenor mayorOMenor = new MayorOmenor();
            Console.WriteLine("Ingrese numeros para terminar ingrese 0");

            for(; ; ) { 
                Console.WriteLine("Digite un numero:");
                while (!int.TryParse(Console.ReadLine(), out mayorOMenor.numero))
                {
                    Console.WriteLine("Numero invalido!");
                }

                if(mayorOMenor.numero == 0)
                {
                    break;
                }

                if (mayorOMenor.primernumero)
                {
                    mayorOMenor.mayor = mayorOMenor.numero;
                    mayorOMenor.menor = mayorOMenor.numero;
                    mayorOMenor.primernumero = false;
                }
                else {

                    if(mayorOMenor.numero > mayorOMenor.mayor)
                    {
                        mayorOMenor.mayor = mayorOMenor.numero;
                    }
                    if(mayorOMenor.numero < mayorOMenor.menor)
                    {
                        mayorOMenor.menor = mayorOMenor.numero;
                    }
                }
            }

            Console.WriteLine($"El numero mayor es: {mayorOMenor.mayor}");
            Console.WriteLine($"El numero menor  es: {mayorOMenor.menor}");

        }
    }
}
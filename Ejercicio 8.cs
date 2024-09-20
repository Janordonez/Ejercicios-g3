using System;
namespace ejercicio8
{
    class mult5
    {
        public int Delimitador;
        static void Main(string[] args)
        {
            mult5 mult5 = new mult5();
            Console.WriteLine("Digite hasta que numero desea saber los multiplos de 5:");
            while((!int.TryParse(Console.ReadLine(), out mult5.Delimitador)))
            {
                Console.WriteLine("Numero no valido!");
            }

            Console.WriteLine("Los numeros multiplos de 5 son:");
            for (int i = 1; i < mult5.Delimitador + 1; i++)
            {
                
                if(i % 5 == 0)
                {
                    
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("No existen numeros multiplos de 5 hasta el numero que digito!");
                    break;
                }
            }
        }
    }
}
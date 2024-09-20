using System;
using System.Security.Cryptography.X509Certificates;
namespace Fibonacci
{
    class Fibonaccicalc
    {
        public int n;
        public int m;
        public int c;
        public int d;
        static void Main(string[] args)
        {
            Fibonaccicalc fibonaccicalc = new Fibonaccicalc();  
            Console.WriteLine("Digite hasta que numero desea la secuencia de Fibonacci:");
            while(!int.TryParse(Console.ReadLine(), out fibonaccicalc.n))
            {
                Console.WriteLine("Numero no valido!");
            }

            int primernum = 0, segundonum = 1;

            if(fibonaccicalc.n > primernum)
            {
                Console.WriteLine(primernum);
                Console.WriteLine(segundonum);
            }

            fibonaccicalc.m = segundonum;

            for(int i = 0; i < fibonaccicalc.n; i++)
            {
                    fibonaccicalc.d = fibonaccicalc.m + fibonaccicalc.c;
                    fibonaccicalc.c = fibonaccicalc.m;
                    fibonaccicalc.m = fibonaccicalc.d;
                    

                    if (fibonaccicalc.d > fibonaccicalc.n)
                    {
                        break;
                    }
                    
                    
                    Console.WriteLine(fibonaccicalc.d);
                    
                    

                }

            }
        }
    }

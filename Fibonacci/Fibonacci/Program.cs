using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, n, proximo, atual=1, anterior = 0;
                       
            Console.WriteLine("Digite um numero limite: ");
            n = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("0");
            Console.WriteLine("1");

            for (i = 0; i < n; i++)
            {
                                
                proximo = anterior + atual;
                Console.WriteLine(proximo);

                anterior = atual;

                atual = proximo;                
            }


            Console.ReadLine();





        }
    }
}

/*Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n, proximo = 1, atual, anterior=0;

            Console.WriteLine("Digite um numero: ");
            n = Convert.ToInt16(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                if (i == 0)
                {                    
                    Console.WriteLine("0");
                }
                else if (i == 1)
                {
                    atual = proximo;

                    Console.WriteLine(atual);

                    proximo = proximo + anterior;

                    Console.WriteLine(proximo);

                    anterior = atual;
                }
                else
                {
                    atual = proximo;

                    proximo = proximo + anterior;

                    Console.WriteLine(proximo);

                    anterior = atual;
                }
            }

            
            Console.ReadLine();
            
        }
    }
}

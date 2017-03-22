using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, valorUm;

            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine("Digite o 1º Valor: ");
                valorUm = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine(valorUm);
            }

            
            Console.ReadLine();

           

        }
    }
}

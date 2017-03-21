using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinacoes
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, n, j;

            Console.WriteLine("Digite um numero para ver a combinacao: ");
            n = Convert.ToInt16(Console.ReadLine());

            
            for (i=1 ; i <= n; i++)
            {
                
                for (j=1; j<=n; j++)
                {
                    Console.WriteLine($"{i},{j}"); 
                }
            }

            Console.ReadLine();
            


        }
    }
}

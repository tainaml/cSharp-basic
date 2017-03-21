using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {

            int c = 1, n, contDiv=0;

            Console.WriteLine("Digite um numero: ");
            n = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.WriteLine(c);
                if (n%c == 0){
                    contDiv = contDiv + 1;
                }
                c++;
            } while (c <= n);

            if (contDiv > 2)
            {
                Console.WriteLine($"o valor {n} nao e primo!");
            }else
            {
                Console.WriteLine($"o valor {n} e primo!");
            }
            
            Console.ReadLine();
        }

    }
                
	
            
	
    }


